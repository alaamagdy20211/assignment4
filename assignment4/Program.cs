
namespace assignment4
{
    internal class Program

    {
        static void ChangeChar(string text, int index)
        {
            char[] word = text.ToCharArray();
            for (int i = 0; i < word.Length; i++)
            {
                if (i == index)
                {
                    word[i] = 'A';
                }
            }
            foreach (char c in word)
            {
                Console.Write(c);
            }
        }

        //static int factorial(int x)
        //{
        //    int sum = 0;
        //    for (int i = x; i > 0; i--)
        //    {
        //        sum += i;

        //    }
        //    return sum;
        //}

        //static void minmaxelements (int[] arr , out int max, out int min)
        //{
        //    max  = arr.Max();
        //    min = arr.Min();
        //}
        //static bool isprime (int x)
        //{
        //    int counter =0;
        //    for (int i = 2; i <= x; i++)
        //    {
        //        if(x%i ==0)
        //        {
        //            counter++;
        //        }
        //    }
        //    if (counter == 1)
        //    {

        //    return true;

        //    }
        //    else
        //    {
        //        return false;
        //    }

        //}

        //static int CalculateSumOfDigits(int num)
        //{
        //    int sum = 0;
        //    while (num != 0)
        //    {
        //        sum += num % 10; 
        //        num /= 10;       
        //    }
        //    return sum;
        //}
        //static  string  passingvaluebyvalue(int x , int y)
        //  {
        //      int temp;
        //      temp = x;
        //      x = y;
        //      y = temp;
        //      return $"the value of x = {x} and the value of y = {y}";

        //  }
        //static string passingvaluebyreference( ref int  x,ref int y)
        //{
        //    int temp;
        //    temp = x;
        //    x = y;
        //    y = temp;
        //    return $"the value of x = {x} and the value of y = {y}";
        //}

        //static void Passingreferencebyvalue(int[] num )
        //{
        //    for (int i = 0; i < num.Length; i++)
        //    {
        //        num[i] = num[i] + 1;
        //        Console.WriteLine(num[i]);
        //    }
        //}

        //static void Passingreferencebyrefeence( ref int[] num)
        //{
        //    for (int i = 0; i < num.Length; i++)
        //    {
        //        num[i] = num[i] + 1;
        //        Console.WriteLine(num[i]);
        //    }
        //}

        //static void calculate (int num1, int num2, out int sum , out int sub)
        //{
        //    sum = num1 + num2;
        //    sub = num1 - num2;

        //}
        static void Main(string[] args)
        {
            #region q1
            // when  i pass numbers as value i pass actual value not the address , so i just take a copy of it ,so when i change on it i change only on the copy not the original one 

            // int x = 2; int y = 3;
            // string result = passingvaluebyvalue(x, y);
            // Console.WriteLine(x);
            // Console.WriteLine(y);
            // Console.WriteLine(result);
            // // when  i pass numbers as refererence i pass it's address(reference) , so when i change on it i change the original one 

            // int num1 = 2; int num2 = 3;
            //string result2 = passingvaluebyreference(ref num1, ref num2);
            // Console.WriteLine(num1);
            // Console.WriteLine(num2);
            // Console.WriteLine(result2);

            #endregion
            #region q2
            /*  int[] numbers = {1,2,3};
              int[] nums = new int[numbers.Length];
               Passingreferencebyvalue(numbers);
              foreach (int num in numbers)
              {
                  Console.WriteLine(num);
              }*/

            //int[] numms = { 1, 2, 3 };
            //int[] numm = new int[numms.Length];
            //Passingreferencebyrefeence(ref numms);
            //foreach (int num in numms)
            //{
            //    Console.WriteLine(num);
            //}

            #endregion
            #region q3
            //int sum , sub ;
            //int num1 = 5; int num2 = 3;
            //calculate(num1, num2, out sum, out sub);
            //Console.WriteLine(sum);
            //Console.WriteLine(sub);
            #endregion
            #region q4
            //int number = 25;
            //int sum = CalculateSumOfDigits(number);
            //Console.WriteLine(sum);
            #endregion
            #region q5
            //int num = 4;
            //bool flag = isprime (num);
            //Console.WriteLine (flag ? "number is prime" : "number is not  prime");
            #endregion
            #region q6
            //int[] numbers = { 2, 8, 1 };
            //minmaxelements(numbers, out int max, out int min);
            //Console.WriteLine($"max number is {max} and min number is {min}");
            #endregion
            #region q7
            //int num = 4;
            //int sum = factorial(num);
            //Console.WriteLine(sum);
            #endregion
            #region q8
            //string word = "youssef";
            //ChangeChar(word, 2);
            #endregion
        }
    }
}