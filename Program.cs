using System;
using System.Collections.Generic;
using System.Linq;
//using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 Write a C# Sharp program to print Hello and your name in a separate line.
            /*Console.WriteLine("Hello");
            Console.WriteLine("Tirtha here");
            
            //2 Write a C# Sharp program to print the sum of two numbers. 
            int a = 6;
            int b = 9;
            Console.WriteLine("a + b= "+(a+b));

            //3 Write a C# Sharp program to print the result of dividing two numbers. 
            int k = 6;
            int j = 9;
            Console.WriteLine(j + "/" + k + "=" + (j / k));
            
            //4 Write a C# Sharp program to print the result of the specified operations. 
            Console.WriteLine(-1 + 4 * 6);
            Console.WriteLine((35 + 5) % 7);
            Console.WriteLine(14 + -4 * 6 / 11);
            Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
           
            //5 Write a C# Sharp program to swap two numbers.
            int a = 5, b = 6;
            Console.WriteLine("Before swap a= " + a + " b= " + b);
            a = a * b; //a=30 (5*6)      
            b = a / b; //b=.. (5/6)      
            a = a / b; //a=.. (5/6)    
            Console.WriteLine("After swap a= " + a + " b= " + b);       

            //6  Write a C# Sharp program to print the output of multiplication of three numbers which will be entered by the user. 
            int x, y, z, r; 
            Console.WriteLine("Input the first number to multiply");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the second number to multiply");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the third number to multiply");
            z = Convert.ToInt32(Console.ReadLine());
            r = x * y * z ;
            Console.WriteLine("Output: {0} x {1} x {2} = {3}", x, y, z, r);*/

            //7 Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing of two numbers which will be entered by the user
            /*float j, k;
            Console.WriteLine("Input the first number");
            j = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the second number");
            k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(j+ "+"+ k + "=" +( j + k));
            Console.WriteLine(j+ "-" +k +"="+( j - k));
            Console.WriteLine(j + "*" + k + "=" + (j * k));
            Console.WriteLine(j + "/" + k + "=" + (j / k));
            Console.WriteLine(j + "%" + k + "=" + (j % k));*/

            //8 Write a C# Sharp program that takes a number as input and print its multiplication table. 
            /* Console.Write("Input the number= ");
             int n = Convert.ToInt32(Console.ReadLine());
             for (int i = 1; i < 11; i++)
             {
                 Console.Write(n + " * " + i +" = " + n * i + "\n");
             }

             //9 Write a C# Sharp program that takes four numbers as input to calculate and print the average. 
             Console.Write("Input the first number= ");
             int f = Convert.ToInt32(Console.ReadLine());
             Console.Write("Input the second number= ");
             int s = Convert.ToInt32(Console.ReadLine());
             Console.Write("Input the third number= ");
             int t = Convert.ToInt32(Console.ReadLine());
             Console.Write("Input the four number= ");
             int o = Convert.ToInt32(Console.ReadLine());
             Console.Write("the average of"+ f +"," + s +"," + t+ ","+ o+ ", "+"is:"+(f+s+t+o/4)+"/n");

             //10 Write a C# Sharp program to that takes three numbers(x,y,z) as input and print the output of (x+y).z and x.y + y.z. 
             Console.Write("Input the first number= ");
             int f = Convert.ToInt32(Console.ReadLine());
             Console.Write("Input the second number= ");
             int s = Convert.ToInt32(Console.ReadLine());
             Console.Write("Input the third number= ");
             int t = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("result of specified numbers" + f + "," + s + "and" + t + ",(x+y).z is " + (f+s)*t + " and x.y+y.z is " + (f*s+s*t) +" ");

             //11 Write a C# Sharp program that takes an age (for example 20) as input and prints something as "You look older than 20".
             Console.Write("Input the age= ");
             int a = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("you look older than " +a);

             //12 Write a C# program to that takes a number as input and display it four times in a row
             //(separated by blank spaces), and then four times in the next row, with no separation. You should
             //do it two times: Use Console. Write and then use {0}.
             Console.Write("Input a digit: ");
             int a = Convert.ToInt32(Console.ReadLine());
             string s = "", ns = "";
             for (int i = 0; i < 2; i++)
             {
                 for (int j = 0; j < 4; j++)
                 {
                     if (i == 0)
                     {
                         s += string.Format("{0} ", a);
                     }
                     else
                     {
                         ns += a;
                     }
                 }
             }
             Console.WriteLine("{0}\n{1}\n{0}\n{1}",s,ns);
             Console.Read();*/

            //13 Write a C# program that takes a number as input and then displays a rectangle of 3 columns wide and 5 rows tall using that digit. 
            //int num = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("\n\n");
            //for (int i = 0; i < 5; i++)
            //{
            //    if (i == 0 || i == 4)
            //    {
            //        Console.WriteLine("{0}{0}{0}", num);
            //    }
            //    else
            //    {
            //        Console.WriteLine("{0} {0}", num);
            //    }
            //}
            //Console.Read();

            //14 Write a C# program to convert from celsius degrees to Kelvin and Fahrenheit. 
            //Console.Write("Enter amount of celsius  : ");
            //int celsius = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Kelvin = {0}", celsius + 273);
            //Console.WriteLine("Fahrenheit = {0}", celsius * 18 / 10 + 32);
            //Console.ReadLine();

            ////15 Write a C# program remove specified a character from a non-empty string using index of a character.
            //String s = "Atmiya University";
            //String s1 = s.Remove(2, 1);
            //Console.WriteLine(s1);
            //String s2 = s.Remove(7, 1);
            //Console.WriteLine(s2);
            //Console.ReadLine();

            //16 Write a C# program to create a new string from a given string (length 1 or more) with the first character added at the front and back.
            //String str = "The quick brown fox jumps over the lazy dog.";
            //Console.WriteLine(str);
            //if (str.Length >= 1)
            //{
            //    var s = str.Substring(0, 1);
            //    Console.WriteLine(s + str + s);
            //}
            //Console.ReadLine();

            //17 Write a C# program to check two given integers and return true if one is negative and one is positive.
            //Console.Write("Enter first number : ");
            //int n1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter second number : ");
            //int n2 = Convert.ToInt32(Console.ReadLine());
            //if (n1 < 0 && n2 > 0 || n1 > 0 && n2 < 0)
            //{
            //    Console.WriteLine("True");
            //}
            //Console.ReadLine();

            //18  Write a C# program to compute the sum of two given integers, if two values are equal then return the triple of their sum.
            //Console.Write("Enter first number : ");
            //int n1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter second number : ");
            //int n2 = Convert.ToInt32(Console.ReadLine());
            //int sum = n1 + n2;
            //Console.WriteLine("Sum = " + sum);
            //if (n1 == n2)
            //{
            //    Console.WriteLine(sum * sum * sum);
            //}
            //Console.ReadLine();

            //19 Write a C# program to get the absolute value of the difference between two given numbers.
            //Return double the absolute value of the difference if the first number is greater than second number
            //Console.Write("Enter first number : ");
            //int n1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter second number : ");
            //int n2 = Convert.ToInt32(Console.ReadLine());
            //int diff = n1 - n2;
            //Console.WriteLine("Difference = " + diff);
            //int abs = Math.Abs(diff);
            //Console.WriteLine("Absolute of difference : " + abs);
            //if (n1 > n2)
            //{
            //    Console.WriteLine("Double of absolute : " + abs * abs);
            //}
            //Console.ReadLine();

            //20 Write a C# program to check the sum of the two given integers and return true if one of the
            //integer is 20 or if their sum is 20.
            //Console.Write("Enter first number : ");
            //int n1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter second number : ");
            //int n2 = Convert.ToInt32(Console.ReadLine());
            //int sum = n1 + n2;
            //Console.WriteLine("Sum = " + sum);
            //if (n1 == 20 || n2 == 20 || sum == 20)
            //{
            //    Console.WriteLine("True");
            //}
            //Console.ReadLine();

            ////21 Write a C# program to check if an given integer is within 20 of 100 or 200.
            //Console.Write("Enter first number : ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //if (Math.Abs(n - 100) <= 20 || Math.Abs(n - 200) <= 20)
            //{
            //    Console.WriteLine(true);
            //}
            //else
            //{
            //    Console.WriteLine(false);
            //}
            //Console.ReadLine();

            ////22 Write a C# program to convert a given string into lowercase
            //Console.Write("Enter string : ");
            //string n = Console.ReadLine();
            //n = n.ToLower();
            //Console.WriteLine(n);
            //Console.ReadLine();

            ////23 Write a C# program to print the odd numbers from 1 to 99. Prints one number per line
            //for (int i = 1; i < 99; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            ////24 Write a C# program to compute the sum of the first 500 prime numbers.
            //int ct = 0, n = 0, i = 1, j = 1, sum = 0;
            //while (n < 500)
            //{
            //    j = 1;
            //    ct = 0;
            //    while (j <= i)
            //    {
            //        if (i % j == 0)
            //            ct++;
            //        j++;
            //    }
            //    if (ct == 2)
            //    {
            //        sum = sum + i;
            //        //Console.WriteLine(i);  
            //        n++;
            //    }
            //    i++;
            //}
            //Console.WriteLine("total=" + sum);

            ////25 Write a C# program and compute the sum of the digits of an integer.
            //int n, n1, sum = 0;
            //Console.WriteLine("Enter number : ");
            //n = Convert.ToInt32(Console.ReadLine());
            //while (n > 0)
            //{
            //    n1 = n % 10;
            //    sum = sum + n1;
            //    n = n / 10;
            //}
            //Console.WriteLine("Sum = " + sum);

            ////26 Write a C# program to reverse the words of a sentence.
            //Console.WriteLine("Enter any string : ");
            //string s = Console.ReadLine();
            //string[] a = s.Split(' ');
            //Array.Reverse(a);
            //Console.WriteLine();
            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.Write(a[i] + " ");
            //}
            //Console.Write("\n\n");

            ////27 Write a C# program to find the size of a specified file in bytes.
            //long size = fi.Length;
            //Console.WriteLine("File Size in Bytes: {0}", size);

            ////28 Write a C# program to convert a hexadecimal number to decimal number.
            //string hex_value = "4B0";
            //int int_value = Convert.ToInt32(hex_value, 16);
            //Console.WriteLine("hex_value = {0}", hex_value);
            //Console.WriteLine("int_value = {0}", int_value);
            //Console.ReadLine();

            ////29 . Write a C# program to multiply corresponding elements of two arrays of integers.
            //int[] arr1 = { 1, 3, -5, 4 };
            //int[] arr2 = { 1, 4, -5, -2 };

            //Console.WriteLine("Array1: [{0}]", string.Join(", ", arr1));
            //Console.WriteLine("Array2: [{0}]", string.Join(", ", arr2));

            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    Console.Write(arr1[i] * arr2[i] + " ");
            //}

            ////30 Write a C# program to create a new string of four copies, taking last four characters from a given string.If the length of the given string is less than 4 return the original one.
            //Console.Write("Input a string : ");
            //string str = Console.ReadLine();
            //if (str.Length > 4)
            //{
            //    string substr = str.Substring(str.Length - 4);
            //    Console.WriteLine(substr + substr + substr + substr);
            //}

            ////31 Write a C# program to check if a given positive number is a multiple of 3 or a multiple of 7. 
            //Console.Write("Input integer: ");
            //int no = int.Parse(Console.ReadLine());

            //if (no % 3 == 0 || no % 7 == 0)
            //{
            //    Console.WriteLine(true);
            //}
            //else
            //{
            //    Console.WriteLine(false);
            //}

            ////32 Write a C# program to check if a string starts with a specified word.
            //Console.Write("Input a string: ");
            //string str = Console.ReadLine();

            //Console.Write("Word to check: ");
            //string wordToCheck = Console.ReadLine();
            //if (str.StartsWith(wordToCheck))
            //    Console.WriteLine(true);
            //else
            //    Console.WriteLine(false);


            ////33 Write a C# program to check two given numbers where one is less than 100 and other is greater than 200.
            //Console.Write("Input a first number(<100): ");
            //int n1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Input a second number(>200): ");
            //int n2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine((n1 < 100 && n2 > 200));

            ////34 Write a C# program to check if an integer (from the two given integers) is in the range -10 to 10.
            //Console.Write("Input a first number: ");
            //int n1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Input a second number: ");
            //int n2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(((n1 >= -10 && n1 <= 10)) || ((n2 >= -10 && n2 <= 10)));

            ////35 Write a C# program to check if "HP" appears at second position in a string and returns the string without "HP".
            //string str = "PHP Tutorial";
            //Console.WriteLine(str);
            //if (str.Substring(1, 2) == "HP")
            //{
            //    string str1 = str.Remove(1, 2);
            //    Console.WriteLine(str1);
            //}

            ////36 . Write a C# program to find the largest and lowest values from three integer values.
            //Console.Write("Enter first integer : ");
            //int x = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter second integer : ");
            //int y = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter third integer : ");
            //int z = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Largest of three : " + Math.Max(x, Math.Max(y, z)));
            //Console.WriteLine("Lowest of three : " + Math.Min(x, Math.Min(y, z)));

            ////37 Write a C# program to check the nearest value of 20 of two given integers and return 0 if two numbers are same.
            //Console.WriteLine("Input first integer:");
            //int x = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Input second integer:");
            //int y = Convert.ToInt32(Console.ReadLine());
            //int n = 20;
            //int n1 = Math.Abs(x - n);
            //int n2 = Math.Abs(y - n);
            //Console.WriteLine(n1 == n2 ? 0 : (n1 < n2 ? x : y));

            //38 Write a C# program to count a specified number in a given array of integers.
            int[] arr = { 1, 2, 3, 5, 5, 3, 2 };
            int count = 0;
            Console.Write("Input an integer: ");
            int n = Convert.ToInt32(Console.ReadLine());
            foreach (int num in arr)
            {
                if (num == n) count++;
            }
            Console.WriteLine("Number of {0} present in the said array: {1}", n, count);

            //39 Write a C# program to check if a number appears as either the first or last element of an array of integers and the length is 1 or more.
            Console.Write("Input an integer : ");
            int x = Convert.ToInt32(Console.ReadLine());
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine((arr[0] == x) || (arr[arr.Length - 1] == x));

            //40 Write a C# program to compute the sum of all the elements of an array of integers.
            int[] arr = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            Console.WriteLine("Array1 : [{0}]", string.Join(", ", arr));
            var sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("Sum: " + sum);

            //41 Write a C# program to check if the first element or the last element of the two arrays ( length 1 or more) are equal.
            int[] arr1 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            Console.WriteLine("Array1 : [{0}]", string.Join(", ", arr1));
            int[] arr2 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5 };
            Console.WriteLine("Array2 : [{0}]", string.Join(", ", arr2));
            Console.WriteLine((arr1[0].Equals(arr2[0])) || (arr1[arr1.Length - 1].Equals(arr2[arr2.Length - 1])));

            //42 Write a C# program to rotate an array (length 3) of integers in left direction
            int[] arr = { 1, 2, 8 };
            Console.WriteLine("Array1: [{0}]", string.Join(", ", arr));
            int temp = arr[0];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
            arr[arr.Length - 1] = temp;
            Console.WriteLine("After rotating array becomes: [{0}]", string.Join(", ", arr));

            //43  Write a C# program to get the larger value between first and last element of an array (length 3) of integers.
            int[] arr = { 1, 2, 5, 7, 8 };
            Console.WriteLine("Array1: [{0}]", string.Join(", ", arr));
            int max = arr[0];
            for (var i = 0; i < arr.Length; i++)
            {
                if (arr[i] > arr[0])
                    max = arr[i];
            }
            Console.WriteLine("Highest value between first and last values of the said array: {0}", max);

            //44 Write a C# program to create a new array of length containing the middle elements of three arrays(each length 3) of integers.
            int[] arr1 = { 1, 2, 5 };
            Console.WriteLine("Array1: [{0}]", string.Join(", ", arr1));
            int[] arr2 = { 0, 3, 8 };
            Console.WriteLine("Array2: [{0}]", string.Join(", ", arr2));
            int[] arr3 = { -1, 0, 2 };
            Console.WriteLine("Array3: [{0}]", string.Join(", ", arr3));
            int[] new_array = { arr1[1], arr2[1], arr3[1] };
            Console.WriteLine("New array: [{0}]", string.Join(", ", new_array));

            //45 Write a C# program to check if an array contains an odd number.
            int[] arr = { 2, 4, 7, 8, 6 };
            Console.WriteLine("Array: [{0}]", string.Join(", ", arr));
            Console.WriteLine("Check if an array contains an odd number? " + odd(arr));

        }
        //45
        public static bool odd(int[] arr)
        {
            foreach (var n in arr)
            {
                if (n % 2 != 0)
                    return true;
            }
            return false;
        }
    }
}
