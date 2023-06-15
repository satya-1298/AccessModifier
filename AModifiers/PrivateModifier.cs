using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AModifiers
{
    public class PrivateModifier
    {
        //It restricate other program part from accessing its type and its members.
        private void PrivateIntro()

        {
            Console.WriteLine("It is Private Modifier");

        }
        public void intro()
        {
            PrivateModifier privateModifier = new PrivateModifier();
            privateModifier.PrivateIntro();
        }
    }
}
