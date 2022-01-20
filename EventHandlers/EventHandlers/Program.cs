using System;

/* This example show a capabilities of event function member
 */

public class PlayingEventHandlers
{
    public int counter = 0;

    public event EventHandler AddToCounterEventHandler;


    public void AddToCounter()
    {
        counter++;
        AddToCounterEventHandler?.Invoke(this, EventArgs.Empty);

    }

}

class Program
{
    static void Main(string[] args)
    {
        var playingEventHandlers = new PlayingEventHandlers();

        // Attach static method as event handler 
        playingEventHandlers.AddToCounterEventHandler += new EventHandler(staticMethod);
        
        // Attach instant method as event handler
        var instantClass = new InstantClass();
        playingEventHandlers.AddToCounterEventHandler += new EventHandler(instantClass.instantMethod);

        // Attach anynonym function as event handler 
        playingEventHandlers.AddToCounterEventHandler += new EventHandler((object sender, EventArgs e) => Console.WriteLine("Anonymous function called"));

     
        // Invoke all event handlers
        playingEventHandlers.AddToCounter();

    }


    static void staticMethod(object sender, EventArgs e)
    {
        var senderCasted = sender as PlayingEventHandlers;
        Console.WriteLine("Static method is invoked");
        Console.WriteLine(senderCasted.counter);
    }

    
}

class InstantClass
{
    public void instantMethod(object sender, EventArgs e) => Console.WriteLine("Instant method invoked");
}


