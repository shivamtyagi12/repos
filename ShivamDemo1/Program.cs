using System;

namespace ShivamDemo1
{
    class Program
    {
        static void Main(string[] args)
        {

            String str1;
            String []str;

            Console.WriteLine("Enter a string");
            str1 = Console.ReadLine();

            str = str1.Split(',');

            Console.WriteLine("String after splits");

            for(int i=0;i<str.Length;i++)
            {
                Console.WriteLine(str[i] + "");
            }







            //String s1;
            //String s2;

            //Console.WriteLine("Enter a String");
            //s1 = Console.ReadLine();

            //Console.WriteLine("enter a substring");
            //s2 = Console.ReadLine();

            //int index = s1.IndexOf(s2);

            //Console.WriteLine("Index = " + index);





            //String s1;

            //Console.WriteLine("Enter a String");
            //s1 = Console.ReadLine();

            //String s2 = String.Copy(s1);

            //Console.WriteLine("Value of ist string is =" + s1);
            //Console.WriteLine("Value of 2nd string is =" + s2);

            // String s2 = "Shivam";

            //if(s1.CompareTo("Shivam")== 0)
            //{
            //    Console.WriteLine("Equal");
            //}else
            //{
            //    Console.WriteLine("Not Equal");
            //}

            //int num1, num2;

            //Console.WriteLine("Enter numbers");
            //num1 = Convert.ToInt16(Console.ReadLine());
            //num2 = Convert.ToInt16(Console.ReadLine());

            //if(num1>num2)
            //{
            //    Console.WriteLine("Ist number is greater");
            //}
            //else
            //{
            //    Console.WriteLine("2nd number is greater");
            //}

            //int dy;

            //Console.WriteLine("Enter a num from 0-6");
            //dy = Convert.ToInt16(Console.ReadLine());

            //switch(dy)
            //{
            //    case 0:
            //        Console.WriteLine("Monday");
            //        break;
            //    case 1:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case 2:
            //        Console.WriteLine("wednesday");
            //        break;
            //    case 3:
            //        Console.WriteLine("Thursday");
            //        break;
            //    case 4:
            //        Console.WriteLine("Friday");
            //        break;
            //    case 5:
            //        Console.WriteLine("Saturday");
            //        break;
            //    case 6:
            //        Console.WriteLine("Sunday");
            //        break;
            //      default:
            //        Console.WriteLine("Please enter correct number");
            //        break;
            //}






            //int num;
            //try
            //{
            //    Console.WriteLine("Enter a number");
            //    num = Convert.ToInt16(Console.ReadLine());

            //    Console.WriteLine("num = " + num);
            //}catch(Exception ex)
            //{
            //    Console.WriteLine("Num = " + ex.ToString());
            //    Console.WriteLine("Please enter only integer value");
            //}


            //int[] arr = new int[3];
            //arr[0] = 1;
            //arr[1] = 2;
            //arr[2] = 3;

            //for(int i=0;i<arr.Length;i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}


            //int num,m,flag=0;
            //Console.WriteLine("Enter a number to check whether it is prime or not");
            //num = Convert.ToInt16(Console.ReadLine());
            //m = num / 2;

            //for(int i=2;i<=m;i++)
            //{
            //    if(num % i == 0)
            //    {
            //        Console.WriteLine("Not a prime number");
            //         flag = 1;
            //    }
            //}

            //if(flag == 0)
            //{
            //    Console.WriteLine("It is primenumber");
            //}



            //char c;
            //Console.WriteLine("Enter a character");
            //c = (char)Console.Read();

            //if (Char.IsLetter(c))
            //{
            //    if (Char.IsLower(c))
            //    {
            //        Console.WriteLine("chareacter is lowerCAse");
            //    }
            //    else
            //    {
            //        Console.WriteLine("character is uppercase");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Need a Alphabetical letter");
            //}




            //int num1, num2;
            //Console.WriteLine("enter ist no");
            //num1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("enter 2nd no");
            //num2 = Convert.ToInt32(Console.ReadLine());

            //int sum = num1 + num2;

            //Console.WriteLine("Sum of two num is = " +  sum);

            //int num1, num2;

            //Console.WriteLine("two numbers");
            //num1 = Convert.ToInt16(Console.ReadLine());
            //num2 = Convert.ToInt16(Console.ReadLine());


            //Console.WriteLine("Ist Num = " + num1+" 2nd Num=" +num2);
            ////Console.WriteLine("2nd Num before swapping 2nd = " + num2);

            ////temp = num1;
            ////num1 = num2;
            ////num2 = temp;

            //num1 = num1 + num2;
            //num2 = num1 - num2;
            //num1 = num1 - num2;

            //Console.WriteLine("\n Num After Swapping \n");

            //Console.WriteLine("Ist Num = " + num1+ " 2nd Num = "+num2);
            ////Console.WriteLine("2nd Num before swapping = " + num2);






        }
    }
}
