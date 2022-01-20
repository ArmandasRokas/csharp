using System;

namespace enum_flags
{
    [Flags]
    enum  FileAttributes
    {
        None = 0,
        Chached = 1,
        Current = 2,
        Obsolete = 4
    }
    class Program
    {
        static void Main(string[] args)
        {
            FileAttributes onlyNone = FileAttributes.None;

            if(onlyNone == FileAttributes.None)
            {
                Console.WriteLine("None works");
            }
            
            FileAttributes attributes = FileAttributes.Chached | FileAttributes.Current;
            
            Console.WriteLine("All attributes: " + attributes);

            if((attributes & FileAttributes.Chached) == FileAttributes.Chached)
            {
                Console.WriteLine("Chached");
            } 
            if ((attributes & FileAttributes.Current) == FileAttributes.Current)
            {
                Console.WriteLine("Current");
            }
        }
    }
}
