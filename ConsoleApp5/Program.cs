
#region Q1
/*- Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.*/
Console.WriteLine("please enter  Num");
int.TryParse(Console.ReadLine(), out int num);

if(num%3==0&&num%4==0)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("No");
}
#endregion


#region Q2
/*- Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.*/

Console.WriteLine("please enter  Num");
int.TryParse(Console.ReadLine(), out int num);
if(num>0)
{
    Console.WriteLine("postive num");
}
else if(num==0)
{
    Console.WriteLine("zero num");

}
else
{
    Console.WriteLine("nagative");
}
#endregion
#region Q3
/*Write a program that takes 3 integers from the user then prints the max element and the min element.*/
Console.WriteLine("please enter num1\n");
int.TryParse(Console.ReadLine(), out int num1);
Console.WriteLine("please enter num2\n");
int.TryParse(Console.ReadLine(), out int num2);
Console.WriteLine("please enter num3\n");
int.TryParse(Console.ReadLine(), out int num3);
if(num1>num2&&num2>num3)
{
    Console.WriteLine($"max num {num1} and min num {num3}");
}
else if (num2>num1&&num1>num3)
{
    Console.WriteLine($"max num {num2} and min num {num3}");
}
else if (num3 > num2 && num2 > num1)
{
    Console.WriteLine($"max num {num3} and min num {num1}");
}
else if ( num1>num3&&num3>num2)
{
    Console.WriteLine($"max num {num1} and min num {num2}");

}
#endregion

#region Q4
/*Write a program that allows the user to insert an integer number then check If a number is even or odd.*/

Console.WriteLine("please enter  Num");
int.TryParse(Console.ReadLine(), out int num);
if (num % 2 == 0)
    Console.WriteLine("num is even num");
else
    Console.WriteLine("num is odd num");

#endregion

#region Q5
/*- Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).*/
Console.WriteLine("please enter your charcter");
char.TryParse(Console.ReadLine(), out char word);
if(word=='a')
{
    Console.WriteLine("vowel");
}
else if (word=='e')
{
    Console.WriteLine("vowel");
}

else if (word == 'I')
{
    Console.WriteLine("vowel");
}
else if (word == 'o')
{
    Console.WriteLine("vowel");
}

else if (word == 'u')
{
    Console.WriteLine("");
}

else
{
    Console.WriteLine("Consonant");
}
#endregion

#region Q6
/*- Write a program that allows the user to insert an integer then 
print a multiplication table up to 12*/
Console.WriteLine("please enter num");
int.TryParse(Console.ReadLine(), out int num);
for(int i =1; i<=12; i++)
{
    Console.WriteLine(i*num);
}

#endregion

#region Q7
/*8- Write a program that allows to user to insert number then print all even numbers between 1 to this number*/
Console.WriteLine("please enter num");
int.TryParse(Console.ReadLine(), out int num);
for(int i=1;i<=num;i++)
{
    if (i%2==0)
    {
        Console.WriteLine(i);
    }
}
#endregion

#region Q8
/*Write a program that takes two integers then prints the power*/

Console.WriteLine("please enter num1");
int.TryParse(Console.ReadLine(), out int num1);
Console.WriteLine("please enter num2");
int.TryParse(Console.ReadLine(), out int num2);

int sum = 1;
for (int i =1; i<=num2; i++)
{
    sum *=num1;
    
}
Console.WriteLine(sum);
#endregion


#region Q9
/*Write a program to enter marks of five subjects and calculate total, average and percentage.*/





/int[] marks = new int[5];
for (int i = 0; (i) < 5; (i)++)
{

    Console.Write($"Enter marks for subject {i + 1}: ");
    marks[i] = int.Parse(Console.ReadLine());
}
int sum = 0;
for(int i= 0; i<marks.Length;i++ )
{
    sum += marks[i];
}

double avg = sum / 5;
double percent = (sum / 500) * 100;


Console.WriteLine($"avg is {avg}\n");
Console.WriteLine($"percent is {percent}%");
#endregion






#region Q10

/*Write a program to input the month number and print the number of days in that month.*/



Console.Write("Enter the month number (1-12): ");
int month = int.Parse(Console.ReadLine());

int days;


switch (month)
{
    case 1:
    case 3:
    case 5:
    case 7:
    case 8:
    case 10:
    case 12:
        days = 31;
        break;
    case 4:
    case 6:
    case 9:
    case 11:
        days = 30;
        break;
    case 2:
        Console.Write("Enter the year: ");
        int year = int.Parse(Console.ReadLine());
       
        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            days = 29;
        }
        else
        {
            days = 28;
        }
        break;
    default:
        Console.WriteLine("Invalid month number. Please enter a number between 1 and 12.");
        return;
}

Console.WriteLine($"The month {month} has {days} days.");

#endregion
#region Q11

/*-Write a program to create a Simple Calculator.*/

Console.WriteLine("please enter num1\n");
int.TryParse(Console.ReadLine(), out int num1);
Console.WriteLine("please enter spcial charcter\n");
char.TryParse(Console.ReadLine(), out char specail);
Console.WriteLine("please enter num2\n");
int.TryParse(Console.ReadLine(), out int num2);

if (specail == '*')
{
    Console.WriteLine( num1*num2);

}
else if (specail == '-' )
{
    Console.WriteLine( num1 - num2);

}
else if (specail  == '+')
{
    Console.WriteLine(num1 + num2);

}
else if (specail == '/')
{
    Console.WriteLine(num1 / num2);

}
#endregion

#region Q12
/*Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.*/

Console.WriteLine("Enter coordinates of the first point (x1, y1):");
Console.Write("x1: ");
double x1 = double.Parse(Console.ReadLine());
Console.Write("y1: ");
double y1 = double.Parse(Console.ReadLine());

Console.WriteLine("Enter coordinates of the second point (x2, y2):");
Console.Write("x2: ");
double x2 = double.Parse(Console.ReadLine());
Console.Write("y2: ");
double y2 = double.Parse(Console.ReadLine());

Console.WriteLine("Enter coordinates of the third point (x3, y3):");
Console.Write("x3: ");
double x3 = double.Parse(Console.ReadLine());
Console.Write("y3: ");
double y3 = double.Parse(Console.ReadLine());

double area = x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2);

Console.WriteLine(area);


#endregion






#region Q13

/*Within a company, the efficiency of workers is evaluated based on the duration required to complete a specific task. A worker's efficiency level is determined as follows: 
- If the worker completes the job within 2 to 3 hours, they are considered highly efficient. 
- If the worker takes 3 to 4 hours, they are instructed to increase their speed. 
- If the worker takes 4 to 5 hours, they are provided with training to enhance their speed. 
- If the worker takes more than 5 hours, they are required to leave the company. 
To calculate the efficiency of a worker, the time taken for the task is obtained via user input from the keyboard.
*/






Console.WriteLine("Enter the time (in hours) taken by the worker to complete the task:");
double time = double.Parse(Console.ReadLine());


if (time >= 2 && time <= 3)
{
    Console.WriteLine("The worker is highly efficient.");
}
else if (time > 3 && time <= 4)
{
    Console.WriteLine("The worker needs to increase their speed.");
}
else if (time > 4 && time <= 5)
{
    Console.WriteLine("The worker needs training to improve their speed.");
}
else if (time > 5)
{
    Console.WriteLine("The worker is required to leave the company.");
}
else
{
    Console.WriteLine("Invalid input. Time should be 2 hours or more.");
}
#endregion