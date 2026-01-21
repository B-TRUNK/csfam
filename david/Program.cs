using System;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, David!");

/*
string name = "david abanoub anis";
char first_character = 'd';
int age  = 9;
float height = 1.35f;
float weight = 25f;
string school_grade = "3rd_Primary";


Console.WriteLine(
    "Your Name is :" + name + "\n" +
    "your First Character:" + first_character + "\n" +
    "Your Age is :" + age + " Years Old" + "\n" +
    "your Height is: "+height + " " +"meter" + "\n" +
    "your Weight is: "+weight + " " +"kg" + "\n" +
    "your School Grade is: " + school_grade + " " +"Year"
    );

int crachLevel = 3;

int sum = age + crachLevel;
Console.WriteLine(sum);


string full_name = "David Abanoub Boshra";
int a = 5;
int b = 9;


// if statement
// == != > < >= <= || &&

/*
if (full_name != "david abanoub boshra")
{
    Console.WriteLine("name is true");
}
else
{
     Console.WriteLine("name is false");
}
   
if (a == b)
{
    Console.WriteLine("a = b");
}
else if (a > b)
{
    Console.WriteLine("a > b");
}
else if(a <= b)
{
    Console.WriteLine("a <= b");
}
else if (a < b)
{
    Console.WriteLine("a < b");
}
else if(a >= b)
{
    Console.WriteLine("a >= b");
}
    
bool x = true;
bool y = false;
bool z = true;

Console.WriteLine(x || y);
Console.WriteLine(x && y);
Console.WriteLine(x && y && z);
Console.WriteLine(x || y || z);


string username1        = "David@gmail.com";
string username2        = "Reham@gmail.com";
string username1_pass   = "1234";
string username2_pass   = "4321";

if (username1 == "David@gmail.com" && username1_pass == "1234")
{
    Console.WriteLine("Welcome Back David");
}
else if(username2 == "Reham@gmail.com" && username2_pass == "4321")
{
    Console.WriteLine("Welcome Back Reham");
}
else
{
    Console.WriteLine("Unauthorized, Please Check your Credentials");
}

for (int x = 0; x < 2; x++)
{
    // this code is to authenticate the user
    Console.WriteLine("Please enter your Name");
    string myName = Console.ReadLine();
    Console.WriteLine("Please enter your Pass");
    string myPass = Console.ReadLine();

    Console.ReadLine();

    if (myName == "David@gmail.com" && myPass == "1234")
        Console.WriteLine("Welcome Back David");
    else
        Console.WriteLine("Unauthorized, Please Check your Credentials");
}


// Loops

// 1- for loop
// part 1: start, part2 :condition, part3: step

int condition = 5;
int counter;


string[] family = ["Abanoub", "Reham", "David", "Jonathan"];
int[] numbers   = [1, 3, 4, 5, -1];

/*
for (counter = 0; counter < condition; counter++)
    Console.WriteLine(counter);

for (counter = 0; counter < family.Length; counter++)
    Console.WriteLine(family[counter]);

for (counter = 0; counter < numbers.Length; counter++)
    Console.WriteLine(numbers[counter]);

string myName = "Reham Ragaye Naguib";
string label = "My Name IS:";
string newLine = "\n";
Console.WriteLine(label + newLine +  myName);

string? x;
string? y;
for (int p = 0; p < 4; p++) 
{
    Console.WriteLine("Please enter first name to add");
    x = Console.ReadLine();
    Console.WriteLine("Please enter second name to add");
    y = Console.ReadLine();
    Console.ReadLine();

    void Sum(string x, string y)
    {
        Console.WriteLine("Full Name = " + x + " " + y + "\n");
    }
    Sum(x, y);
}
*/

float num1, num2, result;

string operation="";

while (operation != "off")
{
   Console.WriteLine("Please Enter first Number");
   num1 = float.Parse(Console.ReadLine());

    operation = Console.ReadLine();

   Console.WriteLine("Please Enter second Number");
   num2 = float.Parse(Console.ReadLine());

   
    if (operation == "+" || operation == "add")
    {
        result = num1 + num2;
        Console.WriteLine("Sum = " + result);
    }
    else if (operation == "-" || operation == "sub")
    {
        result = num1 - num2;
        Console.WriteLine("Subtraction = " + result);
    }
    
    if(operation == "off")
    break;
}

