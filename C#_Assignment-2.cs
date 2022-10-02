using System;

namespace Assignment_2
{
    class Exercise_1
    {
        static void Main(string[] args)
        {
            
            //1
            Console.Write("Enter First Letter : ");
            String l1 = Console.ReadLine();
            Console.Write("Enter Second Letter : ");
            String l2 = Console.ReadLine();
            Console.Write("Enter Third Letter : ");
            String l3 = Console.ReadLine();

            Console.WriteLine(l3 + " " + l2 + " " + l1);

            //2
            Console.Write("Input a number : ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the desired width : ");
            int width = Convert.ToInt32(Console.ReadLine());

            int height = width;
            for (int row = 0; row < height; row++)
            {
                for (int column = 0; column < width; column++)
                {
                    Console.Write(num);
                }

                Console.WriteLine();
                width--;

                //3
                int x, y;
            char operation;

            Console.Write("Input first number: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input operation: ");
            operation = Convert.ToChar(Console.ReadLine());
            Console.Write("Input second number: ");
            y = Convert.ToInt32(Console.ReadLine());

            if (operation == '+')
                Console.WriteLine("{0} + {1} = {2}", x, y, x + y);
            else if (operation == '-')
                Console.WriteLine("{0} - {1} = {2}", x, y, x - y);
            else if ((operation == 'x') || (operation == '*'))
                Console.WriteLine("{0} * {1} = {2}", x, y, x * y);
            else if (operation == '/')
                Console.WriteLine("{0} / {1} = {2}", x, y, x / y);
            else
                Console.WriteLine("Wrong Character");

            //4
            double r, per_cir, PI = 3.14;
            Console.Write("Enter Radius Of a Circle : ");
            r = Convert.ToDouble(Console.ReadLine());

            per_cir = 2 * PI * r;
            Console.WriteLine("Perimeter of Circle is : {0}", per_cir);

            //5
            double distance, time, speed;
            Console.Write("Enter Distance [in Kilometer(s)] : ");
            distance = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Time [in hour(s)] : ");
            time = Convert.ToDouble(Console.ReadLine());

            speed = distance / time;
            Console.WriteLine("Speed is : {0}KM/h", speed);

            //6
            float r;
            float PI = 3.1415926535f;

            Console.Write("Radius : ");
            r = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine(4 * PI * (r * r));

            Console.WriteLine(4f / 3f * PI * (r * r * r));

            //7
            char symbol;

            Console.Write("Input a Symbol : ");
            symbol = Convert.ToChar(Console.ReadLine());

            if ((symbol == 'a') || (symbol == 'e') || (symbol == 'i') ||
                    (symbol == 'o') || (symbol == 'u'))
                Console.WriteLine("It's a lowercase vowel.");
            else if ((symbol >= '0') && (symbol <= '9'))
                Console.WriteLine("It's a digit.");
            else
                Console.Write("It's another symbol.");

            //8
            int n1, n2;
            bool bothEven;
            Console.Write("Input First number : ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input Second number : ");
            n2 = Convert.ToInt32(Console.ReadLine());

            bothEven = ((n1 % 2 == 0) && (n2 % 2 == 0)) ? true : false;

            Console.WriteLine(bothEven ? "there're numbers Even" : "there's a number odd");

            //9
            string answer;
            string result;

            Console.Write("Input a Number : ");
            answer = Console.ReadLine();

            int num = Convert.ToInt32(answer);
            result = "";
            while (num > 1)
            {
                // for binary conversation base is 2
                int remainder = num % 2;
                result = Convert.ToString(remainder) + result;

                // for binary conversation base is 2
                num /= 2;
            }
            result = Convert.ToString(num) + result;
            Console.WriteLine("Binary : {0}", result);

                //10
                int int1, int2;

                Console.Write("Input 1st number: ");
                int1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input 2nd number: ");
                int2 = Convert.ToInt32(Console.ReadLine());

                if (int1 == int2)
                    Console.WriteLine("{0} and {1} are equal.\n", int1, int2);
                else
                    Console.WriteLine("{0} and {1} are not equal.\n", int1, int2);

                //11
                int i;
                Console.Write("Enter a Number : ");
                i = Convert.ToInt32(Console.ReadLine());

                if (i % 2 == 0)
                    Console.Write("Entered Number is an Even Number");
                else
                    Console.Write("Entered Number is an Odd Number");

                //12
                int num;

                Console.Write("Input an integer : ");
                num = Convert.ToInt32(Console.ReadLine());
                if (num >= 0)
                    Console.WriteLine("{0} is a Positive Number.\n", num);
                else
                    Console.WriteLine("{0} is a Negative Number. \n", num);

                //13
                int year;

                Console.Write("Input an Year : ");
                year = Convert.ToInt32(Console.ReadLine());

                if ((year % 400) == 0)
                    Console.WriteLine("{0} is a leap year.\n", year);
                else if ((year % 100) == 0)
                    Console.WriteLine("{0} is not a leap year.\n", year);
                else if ((year % 4) == 0)
                    Console.WriteLine("{0} is a leap year.\n", year);
                else
                    Console.WriteLine("{0} is not a leap year.\n", year);

                //14
                int age;

                Console.Write("Input the age of the candidate : ");
                age = Convert.ToInt32(Console.ReadLine());

                if (age < 18)
                {
                    Console.Write("Sorry, You are not eligible to caste your vote.\n");
                    Console.Write("You would be able to caste your vote after {0} year.\n\n", 18 - age);
                }
                else
                    Console.Write("Congratulation! You are eligible for casting your vote.\n\n");

                //15
                int m, n;

                Console.Write("Input the  value of m :");
                m = Convert.ToInt32(Console.ReadLine());

                if (m != 0)
                    if (m > 0)
                        n = 1;
                    else
                        n = -1;
                else
                    n = 0;

                Console.Write("The value of m = {0} \n", m);
                Console.Write("The value of n = {0} \n\n", n);

                //16
                int PerHeight;

                Console.Write("Input the height of the person (in centimetres) : ");
                PerHeight = Convert.ToInt32(Console.ReadLine());

                if (PerHeight < 150.0)
                    Console.Write("The person is Dwarf. \n\n");
                else if ((PerHeight >= 150.0) && (PerHeight <= 165.0))
                    Console.Write("The person is  average heighted. \n\n");
                else if ((PerHeight >= 165.0) && (PerHeight <= 195.0))
                    Console.Write("The person is taller. \n\n");
                else
                    Console.Write("Abnormal height.\n\n");

                //17
                int num1, num2, num3;

                Console.Write("Input the 1st number : ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input the 2nd number : ");
                num2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input the 3rd number : ");
                num3 = Convert.ToInt32(Console.ReadLine());

                if (num1 > num2)
                {
                    if (num1 > num3)
                    {
                        Console.Write("The 1st Number is the greatest among three. \n\n");
                    }
                    else
                    {
                        Console.Write("The 3rd Number is the greatest among three. \n\n");
                    }
                }
                else if (num2 > num3)
                    Console.Write("The 2nd Number is the greatest among three \n\n");
                else
                    Console.Write("The 3rd Number is the greatest among three \n\n");

                //18
                int p, c, m;

                Console.Write("Input the marks obtained in Physics :");
                p = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input the marks obtained in Chemistry :");
                c = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input the marks obtained in Mathematics :");
                m = Convert.ToInt32(Console.ReadLine());
                Console.Write("Total marks of Maths, Physics and Chemistry : {0}\n", m + p + c);
                Console.Write("Total marks of Maths and  Physics : {0}\n", m + p);

                if (m >= 65)
                    if (p >= 55)
                        if (c >= 50)
                            if ((m + p + c) >= 180 || (m + p) >= 140)
                                Console.Write("The  candidate is eligible for admission.\n");
                            else
                                Console.Write("The candidate is not eligible.\n\n");
                        else
                            Console.Write("The candidate is not eligible.\n\n");
                    else
                        Console.Write("The candidate is not eligible.\n\n");
                else
                    Console.Write("The candidate is not eligible.\n\n");

                //19
                int rl;
                double phy, che, ca, total;
                double per;
                string nm, div;

                Console.Write("Input the Roll No of the Student : ");
                rl = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input the Name of the Student : ");
                nm = Console.ReadLine();

                Console.Write("Input  the marks of Physics : ");
                phy = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input  the marks of  Chemistry : ");
                che = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input  the marks of Computer Application : ");
                ca = Convert.ToInt32(Console.ReadLine());

                total = phy + che + ca;
                per = total / 3.0;
                if (per >= 60)
                    div = "First";
                else
                if (per < 60 && per >= 48)
                    div = "Second";
                else
                    if (per < 48 && per >= 36)
                    div = "Pass";
                else
                    div = "Fail";

                Console.Write("\nRoll No : {0}\nName of Student : {1}\n", rl, nm);
                Console.Write("Marks in Physics : {0}\nMarks in Chemistry : {1}\nMarks in Computer Application : {2}\n", phy, che, ca);
                Console.Write("Total Marks = {0}\nPercentage = {1}%\nDivision = {2}\n", total, per, div);

                //20
                int tmp;

                Console.Write("Input days temperature : ");
                tmp = Convert.ToInt32(Console.ReadLine());

                if (tmp < 0)
                    Console.Write("Freezing weather.\n");
                else if (tmp < 10)
                    Console.Write("Very cold weather.\n");
                else if (tmp < 20)
                    Console.Write("Cold weather.\n");
                else if (tmp < 30)
                    Console.Write("Normal in temp.\n");
                else if (tmp < 40)
                    Console.Write("Its Hot.\n");
                else
                    Console.Write("Its very hot.\n");

                //21
                int side_a, side_b, side_c;

                Console.Write("Input side 1 of triangle: ");
                side_a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input side 2 of triangle: ");
                side_b = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input side 3 of triangle: ");
                side_c = Convert.ToInt32(Console.ReadLine());

                if (side_a == side_b && side_b == side_c)
                {
                    Console.Write("This is an equilateral triangle.\n");
                }
                else if (side_a == side_b || side_a == side_c || side_b == side_c)
                {
                    Console.Write("This is an isosceles triangle.\n");
                }
                else
                {
                    Console.Write("This is a scalene triangle.\n");
                }

                //22
                int ang_a, ang_b, ang_c, sum;

                Console.Write("Input angle1 of triangle: ");
                ang_a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input angle 2 of triangle: ");
                ang_b = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input angle 3 of triangle: ");
                ang_c = Convert.ToInt32(Console.ReadLine());

                /* Calculate the sum of all angles of triangle */
                sum = ang_a + ang_b + ang_c;

                /* Check whether sum=180 then its a valid triangle otherwise not */
                if (sum == 180)
                {
                    Console.Write("The triangle is valid.\n");
                }
                else
                {
                    Console.Write("The triangle is not valid.\n");
                }
                //23
                char ch;

                Console.Write("Input an Alphabet (A-Z or a-z) : ");
                ch = Convert.ToChar(Console.ReadLine().ToLower());

                int i = ch;
                if (i >= 48 && i <= 57)
                {
                    Console.Write("You entered a number, Please enter an alpahbet.");
                }
                else
                {
                    switch (ch)
                    {
                        case 'a':
                            Console.WriteLine("The Alphabet is vowel");
                            break;
                        case 'i':
                            Console.WriteLine("The Alphabet is vowel");
                            break;
                        case 'o':
                            Console.WriteLine("The Alphabet is vowel");
                            break;
                        case 'u':
                            Console.WriteLine("The Alphabet is vowel");
                            break;
                        case 'e':
                            Console.WriteLine("The Alphabet is vowel");
                            break;
                        default:
                            Console.WriteLine("The Alphabet is not a vowel");
                            break;
                    }
                }
                //24
                int cprice, sprice, plamt;

                Console.Write("Input Cost Price: ");
                cprice = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input Selling Price: ");
                sprice = Convert.ToInt32(Console.ReadLine());

                if (sprice > cprice)
                {
                    plamt = sprice - cprice;
                    Console.Write("\nYou can booked your profit amount : {0}\n", plamt);
                }
                else if (cprice > sprice)
                {
                    plamt = cprice - sprice;
                    Console.Write("\nYou got a loss of amount : {0}\n", plamt);
                }
                else
                {
                    Console.Write("\nYou are running in no profit no loss condition.\n");
                }
                //25
                int custid, conu;
                double chg, surchg = 0, gramt, netamt;
                string connm;

                Console.Write("Input Customer ID : ");
                custid = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input the name of the customer : ");
                connm = Console.ReadLine();
                Console.Write("Input the unit consumed by the customer : ");
                conu = Convert.ToInt32(Console.ReadLine());

                if (conu < 200)
                    chg = 1.20;
                else if (conu >= 200 && conu < 400)
                    chg = 1.50;
                else if (conu >= 400 && conu < 600)
                    chg = 1.80;
                else
                    chg = 2.00;

                gramt = conu * chg;

                if (gramt > 300)
                    surchg = gramt * 15 / 100.0;
                netamt = gramt + surchg;
                if (netamt < 100)
                    netamt = 100;

                Console.Write("\nElectricity Bill\n");
                Console.Write("Customer IDNO                       : {0}\n", custid);
                Console.Write("Customer Name                       : {0}\n", connm);
                Console.Write("unit Consumed                       : {0}\n", conu);
                Console.Write("Amount Charges @Rs. {0}  per unit : {1}\n", chg, gramt);
                Console.Write("Surchage Amount                     : {0}\n", surchg);
                Console.Write("Net Amount Paid By the Customer     : {0}\n", netamt);

                //26
                string notes;
                char grd;

                Console.Write("Input the grade : ");
                grd = Convert.ToChar(Console.ReadLine().ToUpper());

                switch (grd)
                {
                    case 'E':
                        notes = " Excellent";
                        break;
                    case 'V':
                        notes = " Very Good";
                        break;
                    case 'G':
                        notes = " Good ";
                        break;
                    case 'A':
                        notes = " Average";
                        break;
                    case 'F':
                        notes = " Fails";
                        break;
                    default:
                        notes = "Invalid Grade Found.";
                        break;
                }
                Console.Write("You have chosen  : {0}\n", notes);

                //27
                int day_no;

                Console.Write("Input Day Number : ");
                day_no = Convert.ToInt32(Console.ReadLine());

                switch (day_no)
                {
                    case 1:
                        Console.Write("Monday \n");
                        break;
                    case 2:
                        Console.Write("Tuesday \n");
                        break;
                    case 3:
                        Console.Write("Wednesday \n");
                        break;
                    case 4:
                        Console.Write("Thursday \n");
                        break;
                    case 5:
                        Console.Write("Friday \n");
                        break;
                    case 6:
                        Console.Write("Saturday \n");
                        break;
                    case 7:
                        Console.Write("Sunday  \n");
                        break;
                    default:
                        Console.Write("Invalid day number. \nPlease try again ....\n");
                        break;
                }

                //28
                int digit;

                Console.Write("Input Digit(0-9) : ");
                digit = Convert.ToInt32(Console.ReadLine());

                switch (digit)
                {
                    case 0:
                        Console.Write("Zero\n");
                        break;
                    case 1:
                        Console.Write("one\n");
                        break;
                    case 2:
                        Console.Write("Two\n");
                        break;
                    case 3:
                        Console.Write("Three\n");
                        break;
                    case 4:
                        Console.Write("Four\n");
                        break;
                    case 5:
                        Console.Write("Five\n");
                        break;
                    case 6:
                        Console.Write("Six\n");
                        break;
                    case 7:
                        Console.Write("Seven\n");
                        break;
                    case 8:
                        Console.Write("Eight\n");
                        break;
                    case 9:
                        Console.Write("Nine\n");
                        break;
                    default:
                        Console.Write("invalid digit. \nPlease try again ....\n");
                        break;
                }

                //29
                int month_no;

                Console.Write("Input Month No : ");
                month_no = Convert.ToInt32(Console.ReadLine());

                switch (month_no)
                {
                    case 1:
                        Console.Write("January\n");
                        break;
                    case 2:
                        Console.Write("February\n");
                        break;
                    case 3:
                        Console.Write("March\n");
                        break;
                    case 4:
                        Console.Write("April\n");
                        break;
                    case 5:
                        Console.Write("May\n");
                        break;
                    case 6:
                        Console.Write("June\n");
                        break;
                    case 7:
                        Console.Write("July\n");
                        break;
                    case 8:
                        Console.Write("August\n");
                        break;
                    case 9:
                        Console.Write("September\n");
                        break;
                    case 10:
                        Console.Write("October\n");
                        break;
                    case 11:
                        Console.Write("November\n");
                        break;
                    case 12:
                        Console.Write("December\n");
                        break;
                    default:
                        Console.Write("invalid Month number. \nPlease try again ....\n");
                        break;
                }

                //30
                int month_no;

                Console.Write("Input Month No : ");
                month_no = Convert.ToInt32(Console.ReadLine());

                switch (month_no)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        Console.Write("Month  have 31 days. \n");
                        break;
                    case 2:
                        Console.Write("The 2nd month is a February and have 28 days. \n");
                        Console.Write("in leap year The February month  Have 29 days.\n");
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        Console.Write("Month have 30 days. \n");
                        break;
                    default:
                        Console.Write("invalid Month number.\nPlease try again ....\n");
                        break;
                }

                //31
                int num1, num2, ch;

                Console.Write("Enter the first Integer :");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the second Integer :");
                num2 = Convert.ToInt32(Console.ReadLine());


                Console.Write("\nHere are the options :\n");
                Console.Write("1 - Addition.\n2 - Substraction.\n3 - Multiplication.\n4 - Division.\n5 - Exit.\n");
                Console.Write("\nInput your choice : ");
                ch = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        Console.Write("The Addition of  {0} and {1} is: {2}\n", num1, num2, num1 + num2);
                        break;

                    case 2:
                        Console.Write("The Substraction of {0}  and {1} is: {2}\n", num1, num2, num1 - num2);
                        break;

                    case 3:
                        Console.Write("The Multiplication of {0}  and {1} is: {2}\n", num1, num2, num1 * num2);
                        break;

                    case 4:
                        if (num2 == 0)
                        {
                            Console.Write("The second integer is zero. Devide by zero.\n");
                        }
                        else
                        {
                            Console.Write("The Division of {0}  and {1} is : {2}\n", num1, num2, num1 / num2);
                        }
                        break;

                    case 5:
                        break;

                    default:
                        Console.Write("Input correct option\n");
                        break;
                }

                //32
                int[] arr = new int[10];
                int i;

                Console.Write("Input 10 elements in the array :\n");
                for (i = 0; i < 10; i++)
                {
                    Console.Write("element - {0} : ", i);
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.Write("\nElements in array are : ");
                for (i = 0; i < 10; i++)
                {
                    Console.Write("{0}  ", arr[i]);
                }
                Console.Write("\n");

                //33
                int i, n;
                int[] a = new int[100];

                Console.Write("Input the number of elements to store in the array : ");
                n = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input {0} number of elements in the array : \n", n);
                for (i = 0; i < n; i++)
                {
                    Console.Write("element - {0} : ", i);
                    a[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.Write("\nThe values store into the array are : \n");
                for (i = 0; i < n; i++)
                {
                    Console.Write("{0}  ", a[i]);
                }

                Console.Write("\n\nThe values store into the array in reverse are : \n");
                for (i = n - 1; i >= 0; i--)
                {
                    Console.Write("{0} ", a[i]);
                }
                Console.Write("\n\n");

                //34
                int[] a = new int[100];
                int i, n, sum = 0;

                Console.Write("Input the number of elements to be stored in the array : ");
                n = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input {0} elements in the array : \n", n);
                for (i = 0; i < n; i++)
                {
                    Console.Write("element - {0} : ", i);
                    a[i] = Convert.ToInt32(Console.ReadLine());
                }

                for (i = 0; i < n; i++)
                {
                    sum += a[i];
                }

                Console.Write("Sum of all elements stored in the array is : {0}\n\n", sum);

                //35
                int[] arr1 = new int[100];
                int[] arr2 = new int[100];
                int i, n;

                Console.Write("Input the number of elements to be stored in the array : ");
                n = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input {0} elements in the array : \n", n);
                for (i = 0; i < n; i++)
                {
                    Console.Write("element - {0} : ", i);
                    arr1[i] = Convert.ToInt32(Console.ReadLine());
                }
                /* Copy elements of first array into second array. */
                for (i = 0; i < n; i++)
                {
                    arr2[i] = arr1[i];
                }

                /* Prints the elements of first array */
                Console.Write("\nThe elements stored in the first array are : \n");
                for (i = 0; i < n; i++)
                {
                    Console.Write("{0}  ", arr1[i]);
                }

                /* Prints the elements copied into the second array. */
                Console.Write("\n\nThe elements copied into the second array are : \n");
                for (i = 0; i < n; i++)
                {
                    Console.Write("{0}  ", arr2[i]);
                }
                Console.Write("\n\n");

                //36
                int[] arr = new int[100];
                int i, j, num, count = 0;

                //Reads size of the array
                Console.WriteLine("Enter size of the array : ");
                num = Convert.ToInt32(Console.ReadLine());

                //Reads elements in array
                Console.WriteLine("Enter elements in the array: ");
                for (i = 0; i < num; i++)
                {
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }

                //Find all duplicate elements in array
                for (i = 0; i < num; i++)
                {
                    for (j = i + 1; j < num; j++)
                    {
                        // If duplicate element found then increment count by 1
                        if (arr[i] == arr[j])
                        {
                            count++;
                            break;
                        }
                    }
                }

                Console.WriteLine("\n Total number of duplicate elements found in array:" + count);
                Console.ReadLine();

                //37
                int n, ctr = 0;
                int[] arr1 = new int[100];
                int i, j, k;

                Console.Write("Input the number of elements to be stored in the array :");
                n = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input {0} elements in the array :\n", n);
                for (i = 0; i < n; i++)
                {
                    Console.Write("element - {0} : ", i);
                    arr1[i] = Convert.ToInt32(Console.ReadLine());
                }

                /* Checking duplicate elements in the array */
                Console.Write("\nThe unique elements found in the array are : \n");
                for (i = 0; i < n; i++)
                {
                    ctr = 0;

                    /* Check duplicate before the current position and
                       increase counter by 1 if found. */
                    for (j = 0; j < i - 1; j++)
                    {
                        /* Increment the counter when the seaarch value is duplicate. */
                        if (arr1[i] == arr1[j])
                        {
                            ctr++;
                        }
                    }

                    /* Check duplicate after the current position and
                       increase counter by 1 if found. */
                    for (k = i + 1; k < n; k++)
                    {
                        /* Increment the counter when the seaarch value is duplicate. */
                        if (arr1[i] == arr1[k])
                        {
                            ctr++;
                        }
                        /* Duplicate numbers next to each other */
                        if (arr1[i] == arr1[i + 1])
                        {
                            i++;
                        }
                    }

                    /* Print the value of the current position of the array as unique value
                       when counter remain contains its initial value. */
                    if (ctr == 0)
                    {
                        Console.Write("{0} ", arr1[i]);
                    }
                }
                Console.Write("\n\n");

                //38
                int[] arr1 = new int[100];
                int[] arr2 = new int[100];
                int[] arr3 = new int[200];
                int s1, s2, s3;
                int i, j, k;

                Console.Write("Input the number of elements to be stored in the first array : ");
                s1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input {0} elements in the array : \n", s1);
                for (i = 0; i < s1; i++)
                {
                    Console.Write("element - {0} : ", i);
                    arr1[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.Write("Input the number of elements to be stored in the second array : ");
                s2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input {0} elements in the array :\n", s2);
                for (i = 0; i < s2; i++)
                {
                    Console.Write("element - {0} : ", i);
                    arr2[i] = Convert.ToInt32(Console.ReadLine());
                }

                /* size of merged array is size of first array and  size of second array */
                s3 = s1 + s2;

                /* ----------------- insert in the third array ------------------------------------ */
                for (i = 0; i < s1; i++)
                {
                    arr3[i] = arr1[i];
                }
                for (j = 0; j < s2; j++)
                {
                    arr3[i] = arr2[j];
                    i++;
                }

                /* ----------------- sort the array in ascending order --------------------------- */
                for (i = 0; i < s3; i++)
                {
                    for (k = 0; k < s3 - 1; k++)
                    {

                        if (arr3[k] >= arr3[k + 1])
                        {
                            j = arr3[k + 1];
                            arr3[k + 1] = arr3[k];
                            arr3[k] = j;
                        }
                    }
                }

                /* --------------- Prints the merged array ------------------------------------ */
                Console.Write("\nThe merged array in ascending order is : \n");
                for (i = 0; i < s3; i++)
                {
                    Console.Write("{0} ", arr3[i]);
                }
                Console.Write("\n\n");

                //39
                int[] arr1 = new int[100];
                int[] fr1 = new int[100];
                int n, i, j, ctr;

                Console.Write("Input the number of elements to be stored in the array : ");
                n = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input {0} elements in the array : \n", n);
                for (i = 0; i < n; i++)
                {
                    Console.Write("element - {0} : ", i);
                    arr1[i] = Convert.ToInt32(Console.ReadLine());
                    fr1[i] = -1;
                }

                for (i = 0; i < n; i++)
                {
                    ctr = 1;
                    for (j = i + 1; j < n; j++)
                    {
                        if (arr1[i] == arr1[j])
                        {
                            ctr++;
                            fr1[j] = 0;
                        }
                    }

                    if (fr1[i] != 0)
                    {
                        fr1[i] = ctr;
                    }
                }

                Console.Write("\nThe frequency of all elements of the array : \n");
                for (i = 0; i < n; i++)
                {
                    if (fr1[i] != 0)
                    {
                        Console.Write("{0} occurs {1} times\n", arr1[i], fr1[i]);
                    }
                }

                //40
                int[] arr1 = new int[100];
                int i, mx, mn, n;

                Console.Write("Input the number of elements to be stored in the array : ");
                n = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input {0} elements in the array : \n", n);
                for (i = 0; i < n; i++)
                {
                    Console.Write("element - {0} : ", i);
                    arr1[i] = Convert.ToInt32(Console.ReadLine());
                }

                mx = arr1[0];
                mn = arr1[0];

                for (i = 1; i < n; i++)
                {
                    if (arr1[i] > mx)
                    {
                        mx = arr1[i];
                    }

                    if (arr1[i] < mn)
                    {
                        mn = arr1[i];
                    }
                }
                Console.Write("Maximum element is : {0}\n", mx);
                Console.Write("Minimum element is : {0}\n\n", mn);

                //41
                int[] arr1 = new int[10];
                int[] arr2 = new int[10];
                int[] arr3 = new int[10];
                int i, j = 0, k = 0, n;

                Console.Write("Input the number of elements to be stored in the array : ");
                n = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input {0} elements in the array : \n", n);
                for (i = 0; i < n; i++)
                {
                    Console.Write("element - {0} : ", i);
                    arr1[i] = Convert.ToInt32(Console.ReadLine());
                }

                for (i = 0; i < n; i++)
                {
                    if (arr1[i] % 2 == 0)
                    {
                        arr2[j] = arr1[i];
                        j++;
                    }
                    else
                    {
                        arr3[k] = arr1[i];
                        k++;
                    }
                }

                Console.Write("\nThe Even elements are : \n");
                for (i = 0; i < j; i++)
                {
                    Console.Write("{0} ", arr2[i]);
                }

                Console.Write("\nThe Odd elements are : \n");
                for (i = 0; i < k; i++)
                {
                    Console.Write("{0} ", arr3[i]);
                }
                Console.Write("\n\n");

                //42
                int[] arr1 = new int[10];
                int n, i, j, tmp;

                Console.Write("Input the size of array : ");
                n = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input {0} elements in the array : \n", n);
                for (i = 0; i < n; i++)
                {
                    Console.Write("element - {0} : ", i);
                    arr1[i] = Convert.ToInt32(Console.ReadLine());
                }

                for (i = 0; i < n; i++)
                {
                    for (j = i + 1; j < n; j++)
                    {
                        if (arr1[j] < arr1[i])
                        {
                            tmp = arr1[i];
                            arr1[i] = arr1[j];
                            arr1[j] = tmp;
                        }
                    }
                }

                Console.Write("\nElements of array in sorted ascending order : \n");
                for (i = 0; i < n; i++)
                {
                    Console.Write("{0}  ", arr1[i]);
                }
                Console.Write("\n\n");

                //43
                int[] arr1 = new int[10];

                int n, i, j, tmp;

                Console.Write("Input the size of array : ");
                n = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input {0} elements in the array :\n", n);
                for (i = 0; i < n; i++)
                {
                    Console.Write("element - {0} : ", i);
                    arr1[i] = Convert.ToInt32(Console.ReadLine());
                }
                for (i = 0; i < n; i++)
                {
                    for (j = i + 1; j < n; j++)
                    {
                        if (arr1[i] < arr1[j])
                        {
                            tmp = arr1[i];
                            arr1[i] = arr1[j];
                            arr1[j] = tmp;
                        }
                    }
                }

                Console.Write("\nElements of the array in sorted descending order:\n");
                for (i = 0; i < n; i++)
                {
                    Console.Write("{0}  ", arr1[i]);
                }
                Console.Write("\n\n");

                //44
                int[] arr1 = new int[10];
                int i, n, p = 0, inval;

                Console.Write("Input the size of array : ");
                n = Convert.ToInt32(Console.ReadLine());

                /* Stored values into the array */
                Console.Write("Input {0} elements in the array in ascending order : \n", n);
                for (i = 0; i < n; i++)
                {
                    Console.Write("element - {0} : ", i);
                    arr1[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.Write("Input the value to be inserted : ");
                inval = Convert.ToInt32(Console.ReadLine());

                Console.Write("The exist array list is : \n ");
                for (i = 0; i < n; i++)
                    Console.Write("{0} ", arr1[i]);

                /* Determine the position where the new value will be insert. */
                for (i = 0; i < n; i++)
                    if (inval < arr1[i])
                    {
                        p = i;
                        break;
                    }

                /* move all data at right side of the array */
                for (i = n; i >= p; i--)
                    arr1[i] = arr1[i - 1];

                /* insert value at the proper position */
                arr1[p] = inval;

                Console.Write("\n\nAfter Insert the list is : \n ");
                for (i = 0; i <= n; i++)
                    Console.Write("{0} ", arr1[i]);
                Console.Write("\n");

                //45
                int[] arr1 = new int[10];
                int i, n, p, x;

                Console.Write("Input the size of array : ");
                n = Convert.ToInt32(Console.ReadLine());

                /* Stored values into the array */
                Console.Write("Input {0} elements in the array in ascending order : \n", n);
                for (i = 0; i < n; i++)
                {
                    Console.Write("element - {0} : ", i);
                    arr1[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.Write("Input the value to be inserted : ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input the Position, where the value to be inserted : ");
                p = Convert.ToInt32(Console.ReadLine());

                Console.Write("The current list of the array : \n");
                for (i = 0; i < n; i++)
                    Console.Write("{0} ", arr1[i]);

                /* Move all data at right side of the array */
                for (i = n; i >= p; i--)
                    arr1[i] = arr1[i - 1];

                /* insert value at given position */
                arr1[p - 1] = x;

                Console.Write("\n\nAfter Insert the element the new list is : \n");
                for (i = 0; i <= n; i++)
                    Console.Write("{0} ", arr1[i]);
                Console.Write("\n\n");

                //46
                int i, pos, n;
                int[] arr1 = new int[50];

                Console.Write("Input the size of array : ");
                n = Convert.ToInt32(Console.ReadLine());

                /* Stored values into the array */
                Console.Write("Input {0} elements in the array in ascending order : \n", n);
                for (i = 0; i < n; i++)
                {
                    Console.Write("element - {0} : ", i);
                    arr1[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.Write("\nInput the position where to delete : ");
                pos = Convert.ToInt32(Console.ReadLine());

                /* ------- locate the position of i in the array ------- */
                i = 0;
                while (i != pos - 1)
                    i++;

                /* 
                 * the position of i in the array will be replaced by the 
                 * value of its right 
                */
                while (i < n)
                {
                    arr1[i] = arr1[i + 1];
                    i++;
                }
                n--;
                Console.Write("\nThe new list is : ");
                for (i = 0; i < n; i++)
                {
                    Console.Write("  {0}", arr1[i]);
                }
                Console.Write("\n\n");

                //47
                int n, i, j = 0, lrg, lrg2nd;
                int[] arr1 = new int[50];

                Console.Write("Input the size of array : ");
                n = Convert.ToInt32(Console.ReadLine());

                /* Stored values into the array */
                Console.Write("Input {0} elements in the array :\n", n);
                for (i = 0; i < n; i++)
                {
                    Console.Write("element - {0} : ", i);
                    arr1[i] = Convert.ToInt32(Console.ReadLine());
                }

                /* find location of the largest element in the array */
                lrg = 0;
                for (i = 0; i < n; i++)
                {
                    if (lrg < arr1[i])
                    {
                        lrg = arr1[i];
                        j = i;
                    }
                }

                /* ignore the largest element and find the 2nd largest element in the array */
                lrg2nd = 0;
                for (i = 0; i < n; i++)
                {
                    if (i == j)
                    {
                        i++;  /* ignoring the largest element */
                        i--;
                    }
                    else
                    {
                        if (lrg2nd < arr1[i])
                        {
                            lrg2nd = arr1[i];
                        }
                    }
                }

                Console.Write("\nThe Second largest element in the array is : {0} \n", lrg2nd);

                //48
                int n, i, j = 0, sml, sml2nd;
                int[] arr1 = new int[50];

                Console.Write("Input the size of array : ");
                n = Convert.ToInt32(Console.ReadLine());

                /* Stored values into the array */
                Console.Write("Input {0} elements in the array (value must be <9999):\n", n);
                for (i = 0; i < n; i++)
                {
                    Console.Write("element - {0} : ", i);
                    arr1[i] = Convert.ToInt32(Console.ReadLine());
                }

                /* find location of the smallest element in the array */
                sml = 0;
                for (i = 0; i < n; i++)
                {
                    if (sml > arr1[i])
                    {
                        sml = arr1[i];
                        j = i;
                    }
                }

                /* ignore the smallest element and find the 2nd smallest element in the array */
                sml2nd = 99999;
                for (i = 0; i < n; i++)
                {
                    if (i == j)
                    {
                        i++;  /* ignoring the smallest element */
                        i--;
                    }
                    else
                    {
                        if (sml2nd > arr1[i])
                        {
                            sml2nd = arr1[i];
                        }
                    }
                }

                Console.Write("\nThe Second smallest element in the array is : {0} \n", sml2nd);

                //49
                int i, j;
                int[,] arr1 = new int[3, 3];

                /* Stored values into the array */
                Console.Write("Input elements in the matrix : \n");

                for (i = 0; i < 3; i++)
                {
                    for (j = 0; j < 3; j++)
                    {
                        Console.Write("element - [{0},{1}] : ", i, j);
                        arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                Console.Write("\nThe Matrix is : \n");
                for (i = 0; i < 3; i++)
                {
                    Console.Write("\n");
                    for (j = 0; j < 3; j++)
                        Console.Write("{0}   ", arr1[i, j]);
                }
                Console.Write("\n\n");

                //50
                int i, j, n;
                int[,] arr1 = new int[50, 50];
                int[,] brr1 = new int[50, 50];
                int[,] crr1 = new int[50, 50];

                Console.Write("Input the size of the square matrix (less than 5) : ");
                n = Convert.ToInt32(Console.ReadLine());

                if (n < 5 && n != 0)
                {
                    /* Stored values into the array */
                    Console.Write("Input elements in the first matrix :\n");
                    for (i = 0; i < n; i++)
                    {
                        for (j = 0; j < n; j++)
                        {
                            Console.Write("element - [{0},{1}] : ", i, j);
                            arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                        }
                    }

                    Console.Write("Input elements in the second matrix :\n");
                    for (i = 0; i < n; i++)
                    {
                        for (j = 0; j < n; j++)
                        {
                            Console.Write("element - [{0},{1}] : ", i, j);
                            brr1[i, j] = Convert.ToInt32(Console.ReadLine());
                        }
                    }

                    Console.Write("\nThe First matrix is :\n");
                    for (i = 0; i < n; i++)
                    {
                        Console.Write("\n");
                        for (j = 0; j < n; j++)
                            Console.Write("{0}\t", arr1[i, j]);
                    }

                    Console.Write("\nThe Second matrix is :\n");
                    for (i = 0; i < n; i++)
                    {
                        Console.Write("\n");
                        for (j = 0; j < n; j++)
                            Console.Write("{0}\t", brr1[i, j]);
                    }

                    /* calculate the sum of the matrix */
                    for (i = 0; i < n; i++)
                        for (j = 0; j < n; j++)
                            crr1[i, j] = arr1[i, j] + brr1[i, j];

                    Console.Write("\nThe Addition of two matrix is : \n");
                    for (i = 0; i < n; i++)
                    {
                        Console.Write("\n");
                        for (j = 0; j < n; j++)
                            Console.Write("{0}\t", crr1[i, j]);
                    }
                    Console.Write("\n\n");
                }
                else
                {
                    if (n == 0)
                        Console.WriteLine("\nSize of the array can't be 0 ! \nIt must be grater than 0 or less than 5.");
                    else
                        Console.WriteLine("\nSize of the array is too large ! \nIt must be less than 5.");
                }

                //51
                int i, j, n;
                int[,] mat_1 = new int[6, 6];
                int[,] mat_2 = new int[6, 6];

                Console.Write("Enter the size of matrix (less than 5) : ");
                n = Convert.ToInt32(Console.ReadLine());

                if (n < 5 && n != 0)
                {
                    // initialize matrixs of array by user
                    Console.Write("\nMatrix : 1\n");
                    for (i = 0; i < n; i++)
                    {
                        for (j = 0; j < n; j++)
                        {
                            Console.Write("Enter Element [{0}, {1}] : ", i, j);
                            mat_1[i, j] = Convert.ToInt32(Console.ReadLine());
                        }
                    }

                    Console.Write("\nMatrix : 2\n");
                    for (i = 0; i < n; i++)
                    {
                        for (j = 0; j < n; j++)
                        {
                            Console.Write("Enter Element [{0}, {1}] : ", i, j);
                            mat_2[i, j] = Convert.ToInt32(Console.ReadLine());
                        }
                    }

                    // display matrixs 
                    Console.Write("\nMatrix : 1\n");
                    for (i = 0; i < n; i++)
                    {
                        for (j = 0; j < n; j++)
                        {
                            Console.Write("{0} ", mat_1[i, j]);
                        }
                        Console.WriteLine();
                    }

                    Console.Write("\nMatrix : 2\n");
                    for (i = 0; i < n; i++)
                    {
                        for (j = 0; j < n; j++)
                        {
                            Console.Write("{0} ", mat_2[i, j]);
                        }
                        Console.WriteLine();
                    }

                    // Calculate Subtraction Matrix and print it 
                    Console.Write("\nSubtracted Matrix :\n");
                    for (i = 0; i < n; i++)
                    {
                        for (j = 0; j < n; j++)
                        {
                            Console.Write("{0} ", (mat_1[i, j] - mat_2[i, j]));
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    if (n == 0)
                        Console.WriteLine("\nSize of the array can't be 0 ! \nIt must be grater than 0 or less than 5.");
                    else
                        Console.WriteLine("\nSize of the array is too large ! \nIt must be less than 5.");
                }

                //52
                int i, j, n;
                int[,] mat_1 = new int[6, 6];
                int[,] mat_2 = new int[6, 6];

                Console.Write("Enter the size of matrix (less than 5) : ");
                n = Convert.ToInt32(Console.ReadLine());

                if (n < 5 && n != 0)
                {
                    // initialize matrixs of array by user
                    Console.Write("\nMatrix : 1\n");
                    for (i = 0; i < n; i++)
                    {
                        for (j = 0; j < n; j++)
                        {
                            Console.Write("Enter Element [{0}, {1}] : ", i, j);
                            mat_1[i, j] = Convert.ToInt32(Console.ReadLine());
                        }
                    }

                    Console.Write("\nMatrix : 2\n");
                    for (i = 0; i < n; i++)
                    {
                        for (j = 0; j < n; j++)
                        {
                            Console.Write("Enter Element [{0}, {1}] : ", i, j);
                            mat_2[i, j] = Convert.ToInt32(Console.ReadLine());
                        }
                    }

                    // display matrixs 
                    Console.Write("\nMatrix : 1\n");
                    for (i = 0; i < n; i++)
                    {
                        for (j = 0; j < n; j++)
                        {
                            Console.Write("{0} ", mat_1[i, j]);
                        }
                        Console.WriteLine();
                    }

                    Console.Write("\nMatrix : 2\n");
                    for (i = 0; i < n; i++)
                    {
                        for (j = 0; j < n; j++)
                        {
                            Console.Write("{0} ", mat_2[i, j]);
                        }
                        Console.WriteLine();
                    }

                    // Calculate Multiplication Matrix and print it 
                    Console.Write("\nMultiplication Matrix :\n");
                    for (i = 0; i < n; i++)
                    {
                        for (j = 0; j < n; j++)
                        {
                            Console.Write("{0} ", (mat_1[i, j] * mat_2[i, j]));
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    if (n == 0)
                        Console.WriteLine("\nSize of the array can't be 0 ! \nIt must be grater than 0 or less than 5.");
                    else
                        Console.WriteLine("\nSize of the array is too large ! \nIt must be less than 5.");
                }

                //53
                int i, j, n, sum = 0;

                Console.Write("Enter the size of matrix (less than 5) : ");
                n = Convert.ToInt32(Console.ReadLine());

                if (n < 5 && n != 0)
                {
                    // declare array of given size
                    int[,] mat_1 = new int[n, n];

                    // initialize matrixs of array by user
                    Console.Write("\nMatrix : 1\n");
                    for (i = 0; i < n; i++)
                    {
                        for (j = 0; j < n; j++)
                        {
                            Console.Write("Enter Element [{0}, {1}] : ", i, j);
                            mat_1[i, j] = Convert.ToInt32(Console.ReadLine());
                        }
                    }

                    // display matrixs 
                    Console.Write("\nMatrix : 1\n");
                    for (i = 0; i < n; i++)
                    {
                        for (j = 0; j < n; j++)
                        {
                            Console.Write("{0} ", mat_1[i, j]);
                        }
                        Console.WriteLine();
                    }

                    // Calculate sum of left Diagonal of Matrix and print it
                    for (i = 0; i < n; i++)
                    {
                        sum += mat_1[i, (n - 1) - i];
                    }

                    Console.WriteLine("Sum of Left Diagonal of a Matrix is : {0}", sum);
                }
                else
                {
                    if (n == 0)
                        Console.WriteLine("\nSize of the array can't be 0 ! \nIt must be grater than 0 or less than 5.");
                    else
                        Console.WriteLine("\nSize of the array is too large ! \nIt must be less than 5.");
                }

                //54
                int i, j, n;
                int[,] arr1 = new int[10, 10];
                int[] rsum = new int[10];
                int[] csum = new int[10];

                Console.Write("Input the size of the square matrix (less than 5) : ");
                n = Convert.ToInt32(Console.ReadLine());

                if (n < 5 && n != 0)
                {
                    Console.Write("Input elements in the matrix : \n");
                    for (i = 0; i < n; i++)
                    {
                        for (j = 0; j < n; j++)
                        {
                            Console.Write("element - [{0}],[{1}] : ", i, j);
                            arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                        }
                    }
                    Console.Write("The matrix is : \n");
                    for (i = 0; i < n; i++)
                    {
                        for (j = 0; j < n; j++)
                            Console.Write("{0}  ", arr1[i, j]);
                        Console.Write("\n");
                    }

                    /* Sum of rows */
                    for (i = 0; i < n; i++)
                    {
                        rsum[i] = 0;
                        for (j = 0; j < n; j++)
                            rsum[i] = rsum[i] + arr1[i, j];
                    }

                    /* Sum of Column */
                    for (i = 0; i < n; i++)
                    {
                        csum[i] = 0;
                        for (j = 0; j < n; j++)
                            csum[i] = csum[i] + arr1[j, i];
                    }

                    Console.Write("The sum of row and column of the matrix : \n");
                    for (i = 0; i < n; i++)
                    {
                        for (j = 0; j < n; j++)
                            Console.Write("{0}    ", arr1[i, j]);
                        Console.Write("{0}    ", rsum[i]);
                        Console.Write("\n");
                    }

                    Console.Write("\n");
                    for (j = 0; j < n; j++)
                    {
                        Console.Write("{0}   ", csum[j]);
                    }
                    Console.Write("\n\n");
                }
                else
                {
                    if (n == 0)
                        Console.WriteLine("\nSize of the array can't be 0 ! \nIt must be grater than 0 or less than 5.");
                    else
                        Console.WriteLine("\nSize of the array is too large ! \nIt must be less than 5.");
                }

                //55
                int[,] arr1 = new int[50, 50];
                int[,] brr1 = new int[50, 50];
                int i, j, r1, c1, r2, c2, flag = 1;

                Console.Write("Input the number of rows in the 1st matrix : ");
                r1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input the number of columns in the 1st matrix : ");
                c1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input the number of rows in the 2nd matrix : ");
                r2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input the number of columns in the 2nd matrix : ");
                c2 = Convert.ToInt32(Console.ReadLine());

                /* initialize two metrices from user input */
                Console.Write("Input elements in the first matrix : \n");
                for (i = 0; i < r1; i++)
                {
                    for (j = 0; j < c1; j++)
                    {
                        Console.Write("element - [{0}],[{1}] : ", i, j);
                        arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                Console.Write("Input elements in the second matrix :\n");
                for (i = 0; i < r2; i++)
                {
                    for (j = 0; j < c2; j++)
                    {
                        Console.Write("element - [{0}],[{1}] : ", i, j);
                        brr1[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                /* display the two metrices */
                Console.Write("The first matrix is :\n");
                for (i = 0; i < r1; i++)
                {
                    for (j = 0; j < c1; j++)
                        Console.Write("{0}  ", arr1[i, j]);
                    Console.Write("\n");
                }
                Console.Write("The second matrix is :\n");
                for (i = 0; i < r2; i++)
                {
                    for (j = 0; j < c2; j++)
                        Console.Write("{0}  ", brr1[i, j]);
                    Console.Write("\n");
                }

                /* Comparing two matrices for equality */
                if (r1 != r2 && c1 != c2)
                {
                    Console.Write("The Matrices Cannot be compared : \n");
                }
                else
                {
                    Console.Write("The Matrices can be compared : \n");
                    for (i = 0; i < r1; i++)
                    {
                        for (j = 0; j < c2; j++)
                        {
                            if (arr1[i, j] != brr1[i, j])
                            {
                                flag = 0;
                                break;
                            }
                        }
                    }
                    if (flag == 1)
                        Console.Write("Two matrices are equal.\n\n");
                    else
                        Console.Write("But, two matrices are not equal.\n\n");
                }
            }
        }
}
