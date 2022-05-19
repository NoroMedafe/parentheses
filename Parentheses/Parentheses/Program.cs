using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string workingLine;
            int maxNestingDepthParenthesis = 0;
            int depthParentgesis = 0;

            workingLine = Console.ReadLine();

            if (workingLine.Length % 2 == 0 && workingLine[0] == '(')
            {

                for (int i = 0; i < workingLine.Length; i++)
                {

                    if (workingLine[i] == '(')
                    {
                        depthParentgesis++;

                        if (maxNestingDepthParenthesis<depthParentgesis)
                            maxNestingDepthParenthesis = depthParentgesis;

                    }
                    else
                    {
                        depthParentgesis--; 

                        if (depthParentgesis<0)
                        {
                            Console.WriteLine("Строка некоректна");
                            Console.ReadKey();
                            return;
                        }
                    }
                }

                Console.WriteLine("Максимальаня глубина:" + maxNestingDepthParenthesis);
            }
            else
            {
                Console.WriteLine("Строка неверная");
            }

            Console.ReadKey();
        }
    }
}
