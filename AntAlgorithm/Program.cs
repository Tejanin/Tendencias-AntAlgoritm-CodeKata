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

            for (int j = 0; j < aliveAnts.Length; j++)
            {
                if (aliveAnts[j] == '.') continue;
                if (j+2 < aliveAnts.Length && VerifiyLivingAnt(aliveAnts[j], aliveAnts[j+1], aliveAnts[j + 2]))
                {
                    j += 2;
                    continue;
                }

                switch(aliveAnts[j])
                {
                    case 'a':
                        break;
                    case 'n':
                        break;
                    case 't':
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


        }

        public static bool VerifiyLivingAnt(char head, char body ,char tail)
        {
            if(head =='a' &&  body == 'n'&& tail == 't') return true;
            return false;
        }
       
    }
}
