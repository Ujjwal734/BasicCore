using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCore
{
    public class Alphabet
    {
        public void VowCon()
        {
            Console.WriteLine("Enter a Alphabet : ");
            char cha = Console.ReadKey().KeyChar;
            Console.WriteLine("Your Input Alphabet is :- "+ cha);
            if (cha == 'a' || cha == 'u' || cha == 'o' || cha == 'i' || cha == 'e' || cha == 'A' || cha == 'E' || cha == 'I' || cha == 'O' || cha == 'U')
            {
                Console.WriteLine("Its a Vowel :- "+ cha);
            }
            else
            {
                Console.WriteLine("Its a Consonent :- "+ cha);
            }
        }
    }
}
