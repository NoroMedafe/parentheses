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
            int numberOfLeftBrackets=0;
            int numberOfRightBrackets=0;
            int currentNestingDepthOfLeftParenthesis = 0;
            int maxNestingDepthOfLeftParenthesis = 0;
            int currentNestingDepthOfRightParenthesis = 0;
            int maxNestingDepthOfRightParenthesis = 0;

            workingLine = Console.ReadLine();

            if (workingLine.Length % 2 == 0 && workingLine[0] == '(')
            {

                for (int i = 0; i < workingLine.Length; i++)
                {

                    if (workingLine[i] == '(')
                    {
                        numberOfLeftBrackets++;
                        currentNestingDepthOfLeftParenthesis++;

                        if (currentNestingDepthOfRightParenthesis > maxNestingDepthOfRightParenthesis)
                            maxNestingDepthOfRightParenthesis = currentNestingDepthOfRightParenthesis;

                        currentNestingDepthOfRightParenthesis = 0;
                    }
                    else
                    {

                        if (currentNestingDepthOfLeftParenthesis > maxNestingDepthOfLeftParenthesis)
                            maxNestingDepthOfLeftParenthesis = currentNestingDepthOfLeftParenthesis;

                        currentNestingDepthOfLeftParenthesis = 0;
                        numberOfRightBrackets++;
                        currentNestingDepthOfLeftParenthesis++;
                    }

                }

                if (numberOfLeftBrackets == numberOfRightBrackets)

                    if (maxNestingDepthOfRightParenthesis> maxNestingDepthOfLeftParenthesis)
                        Console.WriteLine("Строка корректная и максимальная глубина:" + maxNestingDepthOfRightParenthesis);
                    else
                        Console.WriteLine("Строка корректная и максимальная глубина:" + maxNestingDepthOfLeftParenthesis);

            }
            else
            {
                Console.WriteLine("Строка неверная");
            }

            Console.ReadKey();
        }
    }
}
