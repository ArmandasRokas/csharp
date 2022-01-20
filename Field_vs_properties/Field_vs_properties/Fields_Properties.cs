
var p1 = new Person("Jonas");
Console.WriteLine(p1.Name);

p1.Age = 10;
Console.WriteLine(p1.Age);

class Person
{

    // This is Field.  It is private to your class and stores the actual data.
    private string _name;
    // This a property(or just getter/setter in Java's case).When accessed it uses the underlying field. 
    public string Name => _name;



    // AutoProperty. Private field is automatically generated.
    public int Age { get; set; }

    public Person(string name)
    {
        _name = name;
    }
}
