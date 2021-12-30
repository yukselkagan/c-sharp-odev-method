using System;

namespace c_sharp_odev_metot
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 4;
            int b = 5;



            int result = SumNum(a, b);


            Console.WriteLine(a + b);            
            Console.WriteLine(result);

            Methods methods = new Methods();
            methods.WriteString(result.ToString());


            Console.WriteLine("Without ref");
            int result2 = methods.IncreaseAndSum(a, b);
            methods.WriteString(Convert.ToString(result2));
            methods.WriteString(Convert.ToString(a+b));

            Console.WriteLine("Ref");
            int result3 = methods.IncreaseAndSumRef(ref a, ref b);
            methods.WriteString(Convert.ToString(result3));
            methods.WriteString(Convert.ToString(a + b));


        }



        static int SumNum(int num1, int num2)
        {
            return num1 + num2;
        }






    }


    class Methods
    {
        public void WriteString(string text)
        {
            Console.WriteLine(text);
        }

        public int IncreaseAndSum(int num1, int num2)
        {
            num1 += 1;
            num2 += 1;
            return num1 + num2;
        }


        public int IncreaseAndSumRef(ref int num1, ref int num2)
        {
            num1 += 1;
            num2 += 1;
            return num1 + num2;
        } 







    }








}
