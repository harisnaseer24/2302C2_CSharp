﻿
/*
 //Console.WriteLine("Hello, Haris!");

//Datatypes
byte age = 12;
short sal = 28000;
int number = 10;
long lnum = 213213213123232323L;

float fnum = 0.7885F;// 7 digits
double dnum = 0.788544554454544454554544;//15 digits
decimal deci = 0.78854545444444446545434545444M;// 28 digits

char Alpha = 'a';
string fullName = "Haris Naseer";
bool isValid = true;

Console.WriteLine("What's your First Name..?");

string Name = Console.ReadLine();//user input and readline always returns a string



Console.WriteLine("Welcome, "+ Name+" to Our Application");
 


//Operators
//Arithmetic Operators
Console.WriteLine(40 + 20);
Console.WriteLine(40 - 20);
Console.WriteLine(40 * 20);
Console.WriteLine(40 / 20);
Console.WriteLine(50 % 20);// Modulo => Remainder

//Assignment Operators
int number = 5;
number += 2;// number = number + 2 //7
number -= 2;// number = number - 2 //5
number *= 2;// number = number * 2 //10
number /= 2;// number = number / 2 //5

//Comparison Operators (True / False)
int a = 45, b = 120;
Console.WriteLine(a == b);//F
Console.WriteLine(a != b);//T
Console.WriteLine(a < b); //T
Console.WriteLine(a > b);//f
Console.WriteLine(a >= b);//f
Console.WriteLine(a <= b);//t


//Logical Operators
int a = 34, b = 45;
//And T/T = T
Console.WriteLine(a >= b && a==b );// false
Console.WriteLine(a <= b && a >= b);// false
//Or
Console.WriteLine(a <= b || a == b);// True
//Not

Console.WriteLine(!(a == b)); //True

//Conditional Statements
// if else
Console.WriteLine("Enter salary ..");

int salary = Convert.ToInt32(Console.ReadLine());
// int salary = Int32.Parse(Console.ReadLine());

if (salary >=50000 && !(salary>=80000))
{
	Console.WriteLine("Good Salary");
}
else if( salary < 50000)
{
	Console.WriteLine("Do you get Fuel Allowance ?");
	string answer = Console.ReadLine();

	answer = answer.ToLower();//yes
	if(answer== "yes" || answer=="y")
		
	{
        Console.WriteLine("Sounds Good");
    }
	else if(answer == "no" || answer == "n")
	{
        Console.WriteLine("Try to Switch your job");
    }
	else
	{
        Console.WriteLine("Please answer yes or no.");
    }

}
else
{
	Console.WriteLine("Masha Allah");
}


// switch
Console.WriteLine("Enter number for days from 1 to 7 :");
int number = Convert.ToInt32(Console.ReadLine());

switch (number)
{
	case 1:
		Console.WriteLine("Monday");
		break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;

    case 4:
        Console.WriteLine("Thursday");
        break;
     case 5:
		Console.WriteLine("Friday");
		break;
    case 6:
        Console.WriteLine("Saturday");
        break;
    case 7:
        Console.WriteLine("Enjoy it's Sunday.");
        break;
    default:
        Console.WriteLine("Invalid input.");
        break;

}

int x = 756;
Console.WriteLine($"This is String Interpolation. {x * 2}");// String Interpolation $"{ }"

//Loops

//int i; global
//for -- when we are aware of starting / ending point
//  initialization ; test condition ; increment/decrement
//for (int i = 1    ; i <11;             i++)
//{
//    Console.WriteLine(i);
//}

//for (int i = 10; i > 0; i--)
//{
//	Console.WriteLine(i);

//}
//even
for (int i = 2; i < 101; i = i+2)
{
	Console.WriteLine(i);
}
//odd
for (int i = 1; i < 101; i+=2)
{
	Console.WriteLine(i);
}


for (int i = 1; i < 101; i++)
{
    if(i %2 != 0)
    {
		Console.WriteLine(i);
	}

}
//while -- when we are aware of ending point we dont know  exact number of iteration
int j = 13;

while (j < 13)
{
	Console.WriteLine("J");
    j--;
}


//do While -- when we have to run the code at least once then condition is checked
int j = 13;

do
{
    Console.WriteLine("J");
    j++;
} while (j < 13);


//even / odd

int num;
char ans;
do
{
	Console.WriteLine("Enter a Number");
	num = Convert.ToInt32(Console.ReadLine());
    if(num % 2 == 0)
    {
		Console.WriteLine("Even Number");
    }
    else
    {
		Console.WriteLine("Odd Number");
	}
	Console.WriteLine("Do you want to continue Press y for yes and any key to exit.");


	ans = Convert.ToChar(Console.ReadLine());

} while (ans == 'Y' || ans == 'y');
*/

//Arrays fixed size

//int[] numbers = new int[4];// 4 element will come in this array
//numbers[0] = 2;
//numbers[1] = 12;
//numbers[2] = 22;
//numbers[3] = 24;
//numbers[4] = 24;


//int[] numbers = new int[4]{ 2, 14, 15, 23 };
int[] myNumbers = { 2, 14, 15, 23 };

Console.WriteLine(myNumbers[2]);

//foreach
foreach (int num in myNumbers)
{
	Console.WriteLine(num);
}

//var