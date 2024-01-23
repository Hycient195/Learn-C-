//using System.Text;
//using System.Text.RegularExpressions;

//static void ConsoleCalculator()
//{
//    Console.WriteLine("Enter the operations to perform: ");
//    StringBuilder input = new StringBuilder(Console.ReadLine());
//    var operands = new List<string>(input.ToString().Split(new[] { '+', '-', '*', '/' }));
//    var operators = new List<string>(Regex.Split(input.ToString(), @"\d+")).FindAll(x => x != "");

//    for (var i = 0; i < operators.Count; i++)
//    {
//        Console.WriteLine();
//        while (operators.IndexOf("/") != -1)
//        {
//            var subres = Convert.ToInt32(operands[operators.IndexOf("/")]) / Convert.ToInt32(operands[operators.IndexOf("/") + 1]);
//            Console.WriteLine("intermidiate value: " + input);
//            input.Replace($"{operands[operators.IndexOf("/")]}/{operands[operators.IndexOf("/") + 1]}", subres.ToString());
//            operands = new List<string>(input.ToString().Split(new[] { '+', '-', '*', '/' }));
//            operators = new List<string>(Regex.Split(input.ToString(), @"\d+")).FindAll(x => x != "");
//        }
//        while (input.ToString().IndexOf("*") != -1)
//        {
//            var subres = Convert.ToInt32(operands[operators.IndexOf("*")]) * Convert.ToInt32(operands[operators.IndexOf("*") + 1]);
//            Console.WriteLine("intermidiate value: " + input);
//            input.Replace($"{operands[operators.IndexOf("*")]}*{operands[operators.IndexOf("*") + 1]}", subres.ToString());
//            operands = new List<string>(input.ToString().Split(new[] { '+', '-', '*', '/' }));
//            operators = new List<string>(Regex.Split(input.ToString(), @"\d+")).FindAll(x => x != "");
//        }
//        while (operators.IndexOf("+") != -1)
//        {
//            var subres = Convert.ToInt32(operands[operators.IndexOf("+")]) + Convert.ToInt32(operands[operators.IndexOf("+") + 1]);
//            Console.WriteLine("intermidiate value: " + input);
//            input.Replace($"{operands[operators.IndexOf("+")]}+{operands[operators.IndexOf("+") + 1]}", subres.ToString());
//            operands = new List<string>(input.ToString().Split(new[] { '+', '-', '*', '/' }));
//            operators = new List<string>(Regex.Split(input.ToString(), @"\d+")).FindAll(x => x != "");
//        }
//        while (operators.IndexOf("-") != -1)
//        {
//            var subres = Convert.ToInt32(operands[operators.IndexOf("-")]) - Convert.ToInt32(operands[operators.IndexOf("-") + 1]);
//            Console.WriteLine("intermidiate value: " + input);
//            input.Replace($"{operands[operators.IndexOf("-")]}-{operands[operators.IndexOf("-") + 1]}", subres.ToString());
//            operands = new List<string>(input.ToString().Split(new[] { '+', '-', '*', '/' }));
//            operators = new List<string>(Regex.Split(input.ToString(), @"\d+")).FindAll(x => x != "");
//        }

//    }
//    Console.WriteLine($"result is {input}");
//}

