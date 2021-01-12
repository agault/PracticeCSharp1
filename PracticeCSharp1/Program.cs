using System;

namespace PracticeCSharp1
{/*Future Reference We want one class per file.*/
    public class Person
    {
        public string FirstName;
        public string LastName;

        public void Introduce()
        {
            Console.WriteLine("My name is " + FirstName + " " + LastName );
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var Asia = new Person();
            Asia.FirstName = "Asia";
            Asia.LastName = "Gault";
            Asia.Introduce();

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


                        Console.WriteLine("Different Data types: ");
                        Console.WriteLine(number + count + littleGuy);
                        Console.WriteLine(character);
                        Console.WriteLine(nameFirst);
                        Console.WriteLine(isWorking);
                        
                        Console.WriteLine("Min and Max of byte : ");
                        Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
                        Console.WriteLine("Min and Max of float : ");
                        Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

            /*impicit type conversion*/
            /* less bytes converted to more, no data loss so it works*/
           
            byte b = 1;
            int i = b;
            Console.WriteLine("Implicit type conversion: ");
            Console.WriteLine(i);

            /*explicit type conversion ( too  many bytes into not enough spaces)*/
            /*have to use a cast*/
            int n = 1; /*max is 255 bec byte. so if it was 1000 it wont work*/
            byte e = (byte)n;
            Console.WriteLine("Explicit type conversion: ");
            Console.WriteLine(e);


            /*Non Compatible types*/
            string numberString = "12345";/*Could also use var*/
            int k = Convert.ToInt32(numberString);/*if it was byte wouldnt work cuz number too big*/
            Console.WriteLine(k);

            /*Try Catch blocks*/
            /*if code doesnt work it will use the code in the exception block*/
            try
            {
                var numberString2 = "123456";/* var reps an int*/
                byte l = Convert.ToByte(numberString2);
                Console.WriteLine(l);
            }
            catch (Exception)
            {
                Console.WriteLine("The number 'l' could not be converted to a byte. Showing Try Catch");
              
            }


            /*Operators*/
            var valOne = 10;
            var valTwo = 22;

            Console.WriteLine((float)valOne / (float)valTwo);/*since both valOne and valTwo are int the result wil be an int*/
            /*To solve that we must float */
            Console.WriteLine("Compare if Val 2 is Greater :  " + Convert.ToString(valTwo > valOne));
            Console.WriteLine("Compare if vals are = : "+ Convert.ToString(valTwo == valOne));
        }
    }
}
 
