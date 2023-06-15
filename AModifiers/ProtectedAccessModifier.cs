using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AModifiers
{
    public class ProtectedAccessModifier
    {
        //Allow code within the same class and inherited
        protected void ProtectedIntro()
        {
            Console.WriteLine("This is Protected Modifier");
        }
    }
}
