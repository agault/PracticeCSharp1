using System;

namespace PracticeCSharp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*          byte number = 4;
                        int count = 20;
                        float littleGuy = 1.5f;
                        char character = 'A';
                        string nameFirst = "Asia";
                        bool isWorking = true;
                                                    Retuned correct values
             */
           /* Replace types with var*/
                        var number = 4;
                        var count = 20;
                        var littleGuy = 1.5f;
                        var character = 'A';
                        var nameFirst = "Asia";
                        var isWorking = true;
           


                        Console.WriteLine(number + count + littleGuy);
                        Console.WriteLine(character);
                        Console.WriteLine(nameFirst);
                        Console.WriteLine(isWorking);

                        Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
                        Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

            /*impicit type conversion*/

            /* less bytes converted to more, no data loss so it works*/
            byte b = 1;
            int i = b;
            Console.WriteLine(i);



        }
    }
}
