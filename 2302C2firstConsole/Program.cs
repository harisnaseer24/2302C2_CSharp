
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


//Arrays fixed size

//int[] numbers = new int[4];// 4 element will come in this array


Console.WriteLine(myNumbers[0]);






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
*/
//var
//Console.WriteLine(Math.Pow(2,2));


//int[] numbers = new int[4];// C# give default values to uninitialized variables int=0, string = null, bool= true

//Console.WriteLine(numbers);

//string[] cities = { "Karachi", "Lahore", "Rawalpindi", "Sialkot", "Multan","Sialkot","Sialkot", "Sialkot", "Sialkot" };
//Array.Sort(cities);
//Array.Reverse(cities);

////Console.WriteLine(Array.IndexOf(cities, "Sialkot"));//0
////Console.WriteLine(Array.LastIndexOf(cities, "Sialkot"));//1


//Console.WriteLine();


//for (int i = 0; i < cities.Length; i++)
//{
//    Console.WriteLine(cities[i]);
//}

//Multidimensional Arrays (Array inside an array) 2D, 3D etc...
//
//int[,] TopMarks =
//{   
//    { 88, 89},
//    { 92, 98},
//    { 78, 87},
//    { 99, 100}
//};
// 4 x 2


//Console.WriteLine(TopMarks[1,1]);

//for (int i = 0; i < TopMarks.GetLength(0); i++)
//{
//        Console.WriteLine($"Printing {i+1} array");
//    //Console.WriteLine();
//    for (int j = 0;  j < TopMarks.GetLength(1); j++)
//    {
//        Console.WriteLine(TopMarks[i,j]);
//    }
//    Console.WriteLine();

//}

//Jagged Array (Sizes of subarrays is not fixed) 2D:

//string[][] skillSet =
//{
//    new string[4]{"C#","Sql","Php","Html"},
//    new string[1]{"php"},
//    new string[2]{"Css","Java"},
//    new string[3]{"Javascript","Sql","Php"}
//};

//bool[] numbers = { true,false };

//Console.WriteLine(skillSet[3][1]);

////var dexides the dataype of variable on runtime

//foreach (var skills in skillSet)
//{
//    foreach (var skill in skills)
//    {

//    Console.WriteLine(skill);
//    }
//}

//getJaggedArray(hobbies)

//Functions
//1. User Defined
//add();
//1. No Return no Parameters
//return type function name () { body }
//void Greet()
//{
//    Console.WriteLine("Hi Haris, Welcome to Our Console.");
//}
//Greet();


//2. No Return with Parameters
//void Greet(string name)//Parameter
//{
//    Console.WriteLine($"Hi {name}, Welcome to Our Console.");
//}
//Greet("Talha");//Arguement
//Greet("Adnan");//Arguement
//Greet("Haseeb");//Arguement


//3. Return no Parameters

//string Greet()
//{
//   return("Hi User, Welcome to Our Console.");
//}

//Console.WriteLine(Greet());

//string msg = Greet();
//Console.WriteLine(msg.ToUpper());


//float Greet()
//{
//    return (0.234f);
//}

//Console.WriteLine(Greet());

//float msg = Greet();
//Console.WriteLine(msg);



//4. Return with Parameters

//string Greet(string name, byte age)
//{
//    return ($"Hi {name}, Welcome to Our Console.\n Your age is: {age}");
//}

//string msg = Greet("Jalal",78);
//Console.WriteLine(msg.ToUpper());



//2. Pre Defined

//Math.Sqrt(49),Console.WriteLine(skill);



//1 . Make 2 jagged arrays.
//2. Create a function to print them.

//exception handling (try | catch )
//try
//{
//    //Code to execute
//    int number = Convert.ToInt32(Console.ReadLine());
//    switch (number)
//    {
//        case 1:
//            Console.WriteLine("Hi");
//            break;
//        case 2:

//            Console.WriteLine("Hi , Hi");

//            break;
//        case 3:
//            Console.WriteLine("Hi,hello, hi");
//            break;
//        case 4:
//            Console.WriteLine("Hi,hello, hi, hello");
//            break;

//        default:
//            Console.WriteLine("bye");
//            break;
//    }
//}
//catch (DivideByZeroException e)
//{
//    //Print a message on exception
//    Console.WriteLine("Can't Divide by zero");

//}
//catch (FormatException e)
//{
//    //Print a message on exception
//    Console.WriteLine("Invalid input we want an integer from you."+e);
//}
//catch (Exception e)
//{
//    //Print a message on exception
//    Console.WriteLine("Oops, Something went wrong.");
//}
//finally
//{
//    Console.WriteLine("Thanks for using our console application. Do recommend it to others :)" );
//}


//Collections

//Generics collection
//fixed Datatype
//dynamic size
//List, Dictionary, Stack, Queues

//Non-Generics collection
// Datatype not fixed
//dynamic size
//ArrayList, Hashtable

//using System.Collections;
//using System.Linq;

//Generics
//List

//List<string> SuperCars = new List<string>();
//SuperCars.Add("Ferrari");
//SuperCars.Add("Lamborghini");
//SuperCars.Add("Buggati Chiron");


//List<string> Cars = new List<string>();

//Cars.Add("Honda civic");
//Cars.Add("Honda Accord");
//Cars.Add("Toyota Camry");
//Cars.Add("toyota Fortuner");
//Cars.Add("Suzuki Cultus");
//Cars.Add("Toyota vitz");

////Cars.Remove("Toyota vitz");
////Cars.RemoveAt(3
////
//Console.WriteLine(Cars.Contains("Toyota Revo"));
//Cars.Insert(1, "Toyota Revo");
//Console.WriteLine(Cars.Contains("Toyota Revo"));

//Cars.AddRange(SuperCars);

////Cars.RemoveRange(0,2);

////Cars.Clear();

//Console.WriteLine(Cars.Contains("Toyota Revo"));


////Console.WriteLine(Cars[4]);
//foreach (string car in Cars)
//{
//    Console.WriteLine(car);
//}


//Queues  (fifo: first in first out)
//Queue<string> names = new Queue<string>();
//names.Enqueue("Haris");
//names.Enqueue("ahmed");
//names.Enqueue("ashar");
//names.Enqueue("rayan");
//names.Enqueue("yaheya");
//names.Enqueue("abdullah");
//names.Enqueue("talha");
//names.Enqueue("danish");
//names.Enqueue("sohaib");


//names.Dequeue();
//names.Dequeue();
//names.Dequeue();
//names.Dequeue();

//    names.Clear();

//foreach (string item in names)
//{
//    Console.WriteLine(item);
//}



//Stack (lifo: last in first out)

//Stack<string> SecondRow = new Stack<string>();
//SecondRow.Push("Aisha");
//SecondRow.Push("ashbal");
//SecondRow.Push("mariam");
//SecondRow.Push("muzammil");
//SecondRow.Push("basit");




//SecondRow.Pop();
//SecondRow.Pop();
//SecondRow.Pop();
//SecondRow.Pop();

//SecondRow.Clear();

//foreach (string item in SecondRow)
//{
//    Console.WriteLine(item);
//}


//using System.Collections;
//Dictionaries (Generics)
//Dictionary<string, string> user = new Dictionary<string, string>();
//user.Add("username","harisnaseer24");
//user.Add("email","harisnaseer24@gmail.com");
//user.Add("pass","abcdefghij");
//user.Add("role","admin");
//user.Add("image","harisnaseer.jpg");

//Console.WriteLine(user["role"]);
//user.Remove("image");
////Console.WriteLine(user["role"]);

//foreach (var item in user)
//{
//    string[] test = (item.ToString()).Split(",");
//    string key = test[0].Trim('[');// [
//    string value = test[1].Trim(']');// ]
//    //Console.WriteLine(key);
//    //Console.WriteLine(value);
//    Console.WriteLine( $"The property is : {key} and  value is : {value}");
//    //Console.WriteLine(test[1]);
//}

//Hashtables (Non generic)(no fixed datatype)

//Hashtable user = new Hashtable();
//user.Add("username", "harisnaseer24");
//user.Add("email", "harisnaseer24@gmail.com");
//user.Add("pass", 54544454544);
//user.Add("isadmin",true );
//user.Add(2.45, "harisnaseer.jpg");

//Console.WriteLine(user["isadmin"]);
//user.Remove("image");
//user.Contains(2.45);//true
//user.ContainsValue(true);//true

////Console.WriteLine(user["role"]);
//foreach (DictionaryEntry item in user)
//{
//    Console.WriteLine(item.Key +" : "+ item.Value);
//}
//Console.WriteLine(user.GetHashCode());

//ArrayList (Non Generic)(no fixed datatype)
//ArrayList Cars = new ArrayList();

//Cars.Add("Honda civic");
//Cars.Add("Honda Accord");
//Cars.Add("Toyota Camry");
//Cars.Add("toyota Fortuner");
//Cars.Add(240900);
//Cars.Add(.24f);

//Cars.Remove("Toyota vitz");
//Cars.RemoveAt(3)
//
//Console.WriteLine(Cars.Contains("Toyota Revo"));
//Cars.Insert(1, "Toyota Revo");
//Console.WriteLine(Cars.Contains("Toyota Revo"));
//Cars.RemoveRange(0,2);
//Cars.Clear();
//Console.WriteLine(Cars.Contains("Toyota Revo"));

//Console.WriteLine(Cars[4]);
//foreach (var car in Cars)
//{
//    Console.WriteLine(car);
//}

//String Methods

//string test = """{ "name": "John Doe"}""";

//using System.Collections;

//string test = "we are  Learnnig \"C#\"";
//Console.WriteLine(test);
//Console.WriteLine(test.Replace("Learnnig","Mastering"));
//Console.WriteLine(test.Replace("C#","Java"));

//string email = "hdkjhdkjhkhf";
//int age = 75;

//login start

//login end


//CODING Best Practices
// Indentation (Readable by using spaces and new lines) 
// Comments //Sir yahan switch case shuru kia ha
// Meaningful identifiers (variable names)
// errors (exception handling) 
//less repeatation


//Objects and Classes

//Aeroplane Boeing707 = new Aeroplane();//default constructor


////Boeing707.Name = "Boeing 707";
////Boeing707.takeOff();
////Console.WriteLine(Boeing707.AirLine);

//Aeroplane f16 = new Aeroplane("PAF");


//Aeroplane f17 = new Aeroplane("PAF","F-17 Thunder",2,2,"8500hp");
//f17.takeOff();
//f17.land();

//public class Aeroplane
//{
//    public string? AirLine;
//    public string? Name;
//    public int Seats;
//    public int Crew;
//    public string? Power;

//    //Contstructor
//    public Aeroplane()
//    {
//        this.AirLine = "Not specified";
//        this.Name = "unknown";
//        this.Seats = 0;
//        this.Crew = 0;
//       this.Power = null;
//    } 
    
//    public Aeroplane(string AirLine)
//    {
//        this.AirLine = AirLine;
//        this.Name = "unknown";
//        this.Seats = 0;
//        this.Crew = 0;
//       this.Power = null;
//    }


//    //Paremeterized constructor (Overloading)
//    public Aeroplane(string ALine, string name, int seat , int crew, string pow)
//    {
//        this.AirLine = ALine;
//        this.Name = name;
//        this.Seats = seat;
//        this.Crew = crew;
//       this.Power = pow;
//    }
//    public void takeOff()
//    {
//        Console.WriteLine($"{this.Name} is taking off. Best Wishes..!");
//    }
//    public void land()
//    {
//        Console.WriteLine($"{this.Name} is Landing at the 4th runway..! ");
//    }

//}

//OOP (OBJECT ORIENTED PROGRAMMING)
//it is an approach to code cleaner and better.
//readable
//reusable
//optimize
//proper structure of the code is maintained.



//Main Pillars of OOP

//1. Interitance
//2. Polymorphism
// Method Overloading
// Method Overriding
//3. Abstraction
//4. Encapsulation



//Inheritance
Vehicle abc = new Vehicle("AAZ-789", "Metallic grey");
abc.Run();

Car mercedez = new Car("TZ-8908", "Black", "Mercedez", "Benz C-Class", 20000000);
mercedez.Run();
mercedez.Run(300);

// Parent class | Base Class | Super Class
public class Vehicle
{
    public string regNo;
    public string color;

    public Vehicle(string regno, string color)
    {
        this.regNo = regno;
        this.color = color;
    } 
    public void Run()
    {
        Console.WriteLine($"{this.regNo} vehicle started running");
    }
}
// Child class | Derived Class | Sub Class
public class Car : Vehicle
{

    public string brand;
    public string model;
    public int price;

    public Car(string regno, string color, string brand, string model, int price) : base(regno , color)
    {
        this.brand = brand;
        this.model = model;
        this.price = price;
    }

    //method overriding
    public void Run()
    {
        Console.WriteLine($"{this.brand} {this.model} {this.regNo} started running");
    }
    //method overloading
    public void Run(int speed)
    {
        Console.WriteLine($"{this.brand} {this.model} {this.regNo} started running at {speed} MPH.");
    }

}