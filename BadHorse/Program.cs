using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        public static bool trouble = false;
        static void Main(string[] args) {
            int T = int.Parse(Console.ReadLine());
            for (int x = 0; x < T; x++) {
                int M = int.Parse(Console.ReadLine());
                List<string> left = new List<string>(M);
                List<string> right = new List<string>(M);
                for (int i = 0; i < M; i++) {
                    string[] names = Console.ReadLine().Split(new char[] { ' ' });
                    if (!trouble) {
                        if (!left.Contains(names[0]) && !right.Contains(names[0])) {
                            if (!left.Contains(names[1]) && !right.Contains(names[1])) {
                                left.Add(names[0]);
                                right.Add(names[1]);
                            } else if (left.Contains(names[1])) {
                                right.Add(names[0]);
                            } else if (right.Contains(names[1])) {
                                left.Add(names[0]);
                            }
                        } else if (left.Contains(names[0])) {
                            right.Add(names[1]);
                        } else if (right.Contains(names[0])) {
                            left.Add(names[1]);
                        }

                        if (left.Contains(names[0]) && left.Contains(names[1]) || right.Contains(names[0]) && right.Contains(names[1])) {
                            trouble = true;
                        }
                    }
                }
                if (trouble) {
                    Console.WriteLine("Case #" + (x+1) + ": No");
                } else {
                    Console.WriteLine("Case #" + (x + 1) + ": Yes");
                }
            }

            
        }
    }
}
