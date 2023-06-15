using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AModifiers
{
    //Access modifiers are the keywords with specifies the accessability or scope of variable
    //it will control the visibilty of a class
     public class Public
    {
        public string name = "satya";
        public void PublicIntro()
        {
            int a = 10;
            int b = 20;
            Console.WriteLine(a + b +" "+ name);
            Console.WriteLine("It is public Access Modifier");
        }
       
    }
}
