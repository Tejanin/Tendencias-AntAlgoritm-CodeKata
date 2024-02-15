using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace AntAlgorithm
{
    internal class Program
    {
        public static int antCounter = 0;
        public static bool head = false;
        public static bool body = false;
        public static bool tail = false;
        static void Main(string[] args)
        {
            string aliveAnts = "..ant..ant.ant...ant.ant..ant.ant....ant..ant.ant.ant...ant..";
            string deadAnts = "...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t";

            for (int j = 0; j < deadAnts.Length; j++)
            {
                if (deadAnts[j] == '.') continue;
                if (j+2 < deadAnts.Length && VerifiyLivingAnt(deadAnts[j], deadAnts[j+1], deadAnts[j + 2]))
                {
                    j += 2;
                    continue;
                }

                switch(deadAnts[j])
                {
                    case 'a':
                        VerifyHead();   
                        break;

                    case 'n':
                        VerifyBody();
                        break;
                    case 't':
                        VerifyTail();
                        break;
                }

                if(head && body && tail)
                {
                    antCounter++;
                    head = false;
                    body = false;
                    tail = false;
                }
            }
            LastParts();
            Console.WriteLine($"En este string: {deadAnts} hay {antCounter} Hormigas muertas");
            Console.ReadKey();

        }

        public static void LastParts()
        {
            if (head || body || tail) antCounter++;
        }

        public static bool VerifiyLivingAnt(char head, char body ,char tail)
        {
            if(head =='a' &&  body == 'n'&& tail == 't') return true;
            return false;
        }

        public static void VerifyBody()
        {
            if (body)
            {
                antCounter++;
            }
            else
            {
                body = true;
            }

            
        }

        public static void VerifyHead()
        {
            if (head)
            {
                antCounter++;
            }
            else
            {
                head= true; 
            }

        }

        public static void VerifyTail()
        {
            if (tail)
            {
                antCounter++;
            }
            else
            {
                tail = true;    
            }
            

        }

    }
}
