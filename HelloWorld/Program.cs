using System.Text;
using System.Text.RegularExpressions;
using HelloWorld;

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
Console.WriteLine(ApplicationStatus.UnderInvestigation);

//Typecasting Integers to Enums
Console.WriteLine((int)ApplicationStatus.Pending);

//Typecasting Enums to Integers
var num = 3;
Console.WriteLine((ApplicationStatus)num);

//Parsing and typecasting strings to Enums
string status = "Rejected";
var applicationStatus = (ApplicationStatus)Enum.Parse(typeof(ApplicationStatus), status);
Console.WriteLine(applicationStatus);


/* Exercise Set 1 Uncomment to trigger questions */
//Exercise_1.Question1();
//Exercise_1.Question2();
//Exercise_1.Question3();


/* Working with loops */
Loops.Entrypoint();


/* Working With Random Number Generators */
RandomNumbers.Entrypoint(); // Practice Entrypoint


/* Working with arrays and lists */
ArrayTypes.Entrypoint();
ListType.Entrypoint();


/* Working With Date and Time */
DateTimeType.EntryPoint();


/* Working with strings */
StringType.EntryPoint();


/* Working with files */
FileOps.EntryPoint();


/* Working with folders */
FolderOperations.Entrypoint();


/* Working with pathnames */
FilePath.Entrypoint();


/* Class Basics */
var person2 = new Person();
person2.FirstName = "James";
person2.LastName = "Lemon";

var people = new List<Person>();
people.Add(person2);

// This syntax of instantiating and initializing a class is "Object Initialization" syntax
Animal animal = new Animal
{
    Name = "Bull",
    Age = 88,
    Researchers = people
};


/* Working with Method Modifiers */
//MethodModifiers.EntryPoint();


/* Working with properties */
var book = new Book();
book.SetName("Judge of the jungle");
Console.WriteLine(book.GetName());


/* Working with properties and access modifiers */
var storybook = new StoryBook("Folktakes by nighttime", new DateTime(2005, 12, 3));
Console.WriteLine(storybook.AgeOfBook);


/* Working with class Indexers */
var cookie = new HttpCookie();
cookie["user"] = "John Brown";
cookie["jwt"] = "eyvwoaisjfaoisdfj";
cookie.Expiry = DateTime.Now.AddDays(3);
Console.WriteLine(cookie.Expiry);


/* Exercises on Classes */
//ClassBasicsAndEncapsulationExercises.Entrypoint();


/* Console Calculator Application */
static void ConsoleCalculator()
{
    Console.WriteLine("Enter the operations to perform: ");
    StringBuilder input = new StringBuilder(Console.ReadLine());
    var operands = new List<string>(input.ToString().Split(new[] { '+', '-', '*', '/' }));
    var operators = new List<string>(Regex.Split(input.ToString(), @"\d+")).FindAll(x => x != "");

    for (var i = 0; i < operators.Count; i++)
    {
        Console.WriteLine();
        while (operators.IndexOf("/") != -1)
        {
            var subres = Convert.ToInt32(operands[operators.IndexOf("/")]) / Convert.ToInt32(operands[operators.IndexOf("/") + 1]);
            Console.WriteLine("intermidiate value: " + input);
            input.Replace($"{operands[operators.IndexOf("/")]}/{operands[operators.IndexOf("/") + 1]}", subres.ToString());
            operands = new List<string>(input.ToString().Split(new[] { '+', '-', '*', '/' }));
            operators = new List<string>(Regex.Split(input.ToString(), @"\d+")).FindAll(x => x != "");
        }
        while (input.ToString().IndexOf("*") != -1)
        {
            var subres = Convert.ToInt32(operands[operators.IndexOf("*")]) * Convert.ToInt32(operands[operators.IndexOf("*") + 1]);
            Console.WriteLine("intermidiate value: " + input);
            input.Replace($"{operands[operators.IndexOf("*")]}*{operands[operators.IndexOf("*") + 1]}", subres.ToString());
            operands = new List<string>(input.ToString().Split(new[] { '+', '-', '*', '/' }));
            operators = new List<string>(Regex.Split(input.ToString(), @"\d+")).FindAll(x => x != "");
        }
        while (operators.IndexOf("+") != -1)
        {
            var subres = Convert.ToInt32(operands[operators.IndexOf("+")]) + Convert.ToInt32(operands[operators.IndexOf("+") + 1]);
            Console.WriteLine("intermidiate value: " + input);
            input.Replace($"{operands[operators.IndexOf("+")]}+{operands[operators.IndexOf("+") + 1]}", subres.ToString());
            operands = new List<string>(input.ToString().Split(new[] { '+', '-', '*', '/' }));
            operators = new List<string>(Regex.Split(input.ToString(), @"\d+")).FindAll(x => x != "");
        }
        while (operators.IndexOf("-") != -1)
        {
            var subres = Convert.ToInt32(operands[operators.IndexOf("-")]) - Convert.ToInt32(operands[operators.IndexOf("-") + 1]);
            Console.WriteLine("intermidiate value: " + input);
            input.Replace($"{operands[operators.IndexOf("-")]}-{operands[operators.IndexOf("-") + 1]}", subres.ToString());
            operands = new List<string>(input.ToString().Split(new[] { '+', '-', '*', '/' }));
            operators = new List<string>(Regex.Split(input.ToString(), @"\d+")).FindAll(x => x != "");
        }
        
    }
    Console.WriteLine($"result is {input}");
}

//UpAndDownCasting.EntryPoint();


/* Stack Exercise */
MyStack stack = new MyStack();
stack.Push(1);
stack.Push("Hello");
stack.Push(false);

Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Pop());

stack.Clear();


/* DB Connection & DB Command Exercise (Exercises on Polymorphism) */
// Upcasting;
DBConnection sqlConnection = new OracleConnection("http://192.168.1.0:12701");

DBCommand dbCommand = new DBCommand(sqlConnection, "GET PRODUCTS WHERE NAME IS DELLU4919DW");
dbCommand.Execute();


/* Entrypoint to Workflow Engine Exercise */
WorkflowEntrypoint.Entrypoint();


/* ====================== */
/* Working with delegates */
/* ====================== */
NumberCalculator numberCalculator = new NumberCalculator();

// To use a delegate, create variable with the delegate as type, and assign it to a method that has the same signature with the delegate;
NumberCalculator.NumberCalculatorDelegate operatonDelegate = numberCalculator.Add;

// You can further append other methods with the same signature, that would be invoked when the delegate is executed;
operatonDelegate += numberCalculator.Subtract;
operatonDelegate += numberCalculator.Divide;

// You can even further create other methods on the fly and append it to the variable with the delegate type.
void Multiply(int a, int b)
{
    Console.WriteLine("Product is: " + (a * b));
}
operatonDelegate += Multiply; // Adding a user defined method to the delegate chain of methods.

operatonDelegate(9,3); // You can then execute the delegate with its argument (if any specified) and all the assiciated methods would execute together



/* =============================== */
/* Working With Lambda Expressions */
/* =============================== */
LambdaExpression.EntryPoint();


/* ================================ */
/* Working with Event and Delegates */
/* ================================ */
var video = new Video() { Name = "Coming to America" };
var encoder = new VideoEncoder();

MailingService mailingService = new MailingService();
TextMessageService textMessageService = new TextMessageService();

// Subscribing to events
encoder.VideoEncoded += mailingService.OnVideoEncoded;
encoder.VideoEncoded += textMessageService.OnVideoEncoded;

encoder.Encode(video);

// Unsubscribing from events
encoder.VideoEncoded -= mailingService.OnVideoEncoded;


/* ============================================== */
/* Working With Events and the Event Handler Type */
/* ============================================== */
var file = new MyFile("C://documents");
var fileCompressor = new FileCompressor();

var telexService = new TelexService();
var phoneService = new PhoneCallService();

fileCompressor.FileCompressed += telexService.OnFileCompressed;
fileCompressor.FileCompressed += phoneService.OnFileCompressed;

fileCompressor.FileCompressed += (sender, e) =>
{
    Console.WriteLine("Using Lambda Expression with events");
};

fileCompressor.Compress(file);



/* ============================== */
/* Working With Extension Methods */
/* ============================== */
string longWord = "A quick brown fox jumps over the lazy dog";
Console.WriteLine(longWord.Truncate(6)); // The "Truncate" method is an extension method, and originally does not exist on the string class.

int digit = 45;
digit.Power(); // Extension method added to the int type



/* ================= */
/* Working With LINQ */
/* ================= */
LINQ.EntryPoint();



/* =========================== */
/* Working With Nullable Types */
/* =========================== */
NullableTypes.EntryPoint();