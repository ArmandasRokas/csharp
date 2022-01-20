using System;

class Program
{
    static void Main(string[] args)
    {
        // This shows if reference type is Base class
        // and instance type is Base class, so it executes
        // original method.
        MyBaseClass mybaseRef = new MyBaseClass();
        mybaseRef.Name = "";
        Console.WriteLine(mybaseRef.Name);

        // This shows that although the reference type is
        // Base class, but the type of instance is Derived class
        // so it executed overrided method. 
        MyBaseClass mybaseRefDerivedInstance = new MyDerivedClass();
        mybaseRefDerivedInstance.Name = "";
        Console.WriteLine(mybaseRefDerivedInstance.Name);
    }
}

