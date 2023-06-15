using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AModifiers
{
    public class Program:ProtectedAccessModifier
    {
        static void Main(string[] args)
        {
            Public p = new Public();
            p.PublicIntro();
            
           
             
            PrivateModifier privateModifier = new PrivateModifier();
            privateModifier.intro();
            

            ProtectedAccessModifier protectedAccessModifier=new ProtectedAccessModifier();
            Program program = new Program();
            program.ProtectedIntro();
            

            InternalAccessModifier internalAccessModifier=new InternalAccessModifier();
            internalAccessModifier.InternalIntro();

        }
    }
}
