using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HW12
{
    
    internal class MainProgram
    {
        static void Main(string[] args)
        {
            List<Family> families = new List<Family>()
            {
                new Family("Воронины"),
                new Family("Соколовы"),
                new Family("Ожерельевы"),
                new Family("Берендсены"),
                new Family("Васильевы"),
                new Family("И ещё кто-то"),
            };
            
            Publisher firstPublisher = new Publisher("Комсомольская правда");
            Publisher secondPublisher = new Publisher("Фазенда");
            Publisher thirdPublisher = new Publisher("Майор Гром");
            Publisher fourthPublisher = new Publisher("Автолегенды СССР");
            
            for(int i = 0, j = 0; i < 11; i++)
            {
                if (j >= 6) j = 0;
                if (i < 5)
                {
                    firstPublisher.PostEvent += families[j].GetPost;
                    j++;
                }
                else if (i < 8)
                {
                    secondPublisher.PostEvent += families[j].GetPost;
                    j++;
                }
                else if (i < 10)
                {
                    thirdPublisher.PostEvent += families[j].GetPost;
                    j++;
                }
                else if (i < 11) 
                {
                    fourthPublisher.PostEvent += families[j].GetPost;
                    j++;
                }
            }

            firstPublisher.SendPost(firstPublisher.Name);
            secondPublisher.SendPost(secondPublisher.Name);
            thirdPublisher.SendPost(thirdPublisher.Name);
            fourthPublisher.SendPost(fourthPublisher.Name);
            Console.WriteLine("\n");
            foreach (Family i in families)
            {
                if(i.GettedPost >= 1) Console.WriteLine($"{i.Name} получили хотя-бы одно письмо от издательства");
            }
        }
    }
}
