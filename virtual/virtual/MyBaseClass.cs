using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MyBaseClass
{
    // virtual property. Without virtual it is not possible to override.
    public virtual string Name { get; set; }
}

class MyDerivedClass : MyBaseClass
{
    private string _name;
    public override string Name
    {
        get
        {
            return _name;
        }
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                _name = value;
            }
            else
            {
                _name = "Unknown";
            }
        }
    }
}


