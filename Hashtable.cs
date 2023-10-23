using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class HashtableEx
    {
        public void Display()
        {
            Hashtable hashtable = new Hashtable();

            hashtable.Add(1, "Student1");

            hashtable.Add(2, "Student2");

            hashtable.Add(3, "Student3");

            hashtable.Add("four", 234);





            //ICollection keys = hashtable.Keys;



            foreach (var a in hashtable.Keys)

            {

                Console.WriteLine($"{hashtable[a]}");

            }
        }
    }
}
