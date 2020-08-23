using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_OOP
{
    class NameisCannotBeEmpty : Exception
    {
        public override string Message
        {
            get
            {
                return "Name is cannot be empty!";
            }
        }
    }

    class Person
    {
        public void Detail(string name)
        {
            try
            {
                if (name.Length == 0)
                {
                    throw new NameisCannotBeEmpty();
                }
                Console.WriteLine($"Hi, {name}");
            }
            catch (NameisCannotBeEmpty err)
            {
                Console.WriteLine(err.Message);
            }
        }
    }
}
