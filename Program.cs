using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_For04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 20; i++)
            {
                if (i % 3 == 0)
                {
                    if (i % 5 == 0)
                    {
                        if (i % 15 == 0)
                        {
                            Console.WriteLine(i + ":foo-bar-foobar");
                        }
                        else
                        {
                            Console.WriteLine(i + ":foo-bar");
                        }
                    }
                    else
                    {
                        Console.WriteLine(i + ":foo");
                    }
                }
                else if (i % 5 == 0)
                {
                    if (i % 15 == 0)
                    {
                        Console.WriteLine(i + ":bar-foobar");
                    }
                    else
                    {
                        Console.WriteLine(i + ":bar");
                    }
                }
                else if (i % 15 == 0)
                {
                    Console.WriteLine(i + ":foobar");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            Console.Read();
        }
    }
}
