﻿using HelloWorld;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
char alpha = 'a';

var converted = Convert.ToInt32("6");
Console.WriteLine(converted);


// Implicit Conversions
byte age = 33;
int newAge = age;
Console.WriteLine(newAge);

// Explicit Type  Casting
int score = 7874;
short newScore = (short) score;
Console.WriteLine(newScore);


// Conversion
try
{
    var strNum = "123";
    byte flNum = Convert.ToByte(strNum);
    Console.WriteLine(strNum);
}
catch (Exception err)
{
    Console.WriteLine("An error occoured in conversion");
    Console.WriteLine(err);
}

/* 
 * It is good to note that casting is used for the conversion of compatible types,
 * while Conversion is used conversion of uncompatible data types.
*/

Person James = new Person();
James.FirstName = "James";
James.LastName = "Larry";
James.Greet();

//Joining Strings
char[] alphabets = new char[] { 'a', 'b', 'c', 'd' };
string word = string.Join("_", alphabets);
Console.WriteLine(word);


//String concatentation
string firstName = "John";
string lastName = "Doe";

string fullName = string.Format("My full name is {0} {1}", firstName, lastName);
Console.WriteLine(fullName);


/* ===== */
/* Enums */
/* ===== */

//Working with Enums
Console.WriteLine(ColorStatus.UnderInvestigation);

//Typecasting Integers to Enums
Console.WriteLine((int)ColorStatus.Pending);

//Typecasting Enums to Integers
var num = 3;
Console.WriteLine((ColorStatus)num);

//Parsing and typecasting strings to Enums
string status = "Rejected";
var applicationStatus = (ColorStatus)Enum.Parse(typeof(ColorStatus), status);
Console.WriteLine(applicationStatus);

//Exercise Set 1
//Exercise_1.Question1();
//Exercise_1.Question2();
Exercise_1.Question3();