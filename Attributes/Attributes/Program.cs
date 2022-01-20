public class Program
{
    public static void Main()
    {
        // Getting class attributes
        Type widgetType = typeof(Widget);
        object[] widgetClassAttributes = widgetType.GetCustomAttributes(typeof(HelpAttribute), false);
        HelpAttribute attr = (HelpAttribute) widgetClassAttributes[0];
        Console.WriteLine($"Widget class help url: {attr.Url} -  Related topic : {attr.Topic}");

        // Getting mthod attributes
        System.Reflection.MethodInfo displayMethod = widgetType.GetMethod(nameof(Widget.Display));
        object[] displayMethodAttributes = displayMethod.GetCustomAttributes(typeof(HelpAttribute), false);
        HelpAttribute methodAttr = (HelpAttribute)displayMethodAttributes[0];
        Console.WriteLine($"Widget class help url: {methodAttr.Url} -  Related topic : {methodAttr.Topic}");
    }
}

public class HelpAttribute : Attribute
{
    string _url;
    string? _topic;

    public HelpAttribute(string url) => _url = url;

    public string Url => _url;

    public string Topic
    {
        get => _topic?? "unknown topic";
        set => _topic = value;
    }

}

// Attribute in HelpAttribute can be ommited
[Help("https://class.com")]
public class Widget
{
    [Help("http://method.com", Topic = "topic")]
    public void Display()
    {
        Console.WriteLine("Display function executed");
    }
}