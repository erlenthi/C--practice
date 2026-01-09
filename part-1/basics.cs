using System.ComponentModel;
using System.Security.Cryptography;

// Console.WriteLine("Hello World!");

// /*  string name = "42";


// // // This will cause a compile-time error due to type mismatch
// //     static int AddNumbers(int a, int b)
// //     {
// //         return a + b;
// //     }

// //     int result = AddNumbers("hello", 3);
// //     Console.WriteLine(result);

// */ 

// int globalVar = 10;
// Console.WriteLine($"Before scope: {globalVar}");

// {
//     globalVar = 20;
//     //int newVar = 30; 
//     Console.WriteLine($"Inside scope: {globalVar}");
// }

// Console.WriteLine($"After scope: {globalVar}");
// //Console.WriteLine($"newVar: {newVar}"); // This will cause a compile-time error

// Console.WriteLine(34.40M); // The M suffix indicates a decimal literal
// Console.WriteLine(34.40);

// //@

// Console.WriteLine(@"    c:\source\repos    
//         (this is where your code goes)"); // Verbatim string literal. The @ symbol allows multi-line strings and ignores escape sequences.

// //$

// string firstName = "Bob";
// Console.WriteLine($"Hello {firstName}!");

// //$@

// string projectName = "First-Project";
// Console.WriteLine($@"C:\Output\{projectName}\Data");


// int widgetsSold = 7;
// Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets."); //overloaded operator


// int first = 7;
// int second = 5;
// decimal quotient = (decimal)first / (decimal)second;
// Console.WriteLine(quotient);

// Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");
// Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");

// //Both the increment and decrement operators have an interesting quality — depending on their position, 
// //they perform their operation before or after they retrieve their value. In other words, if you use the operator 
// //before the value as in ++value, then the increment will happen before the value is retrieved. 
// //Likewise, value++ will increment the value after the value has been retrieved.

// int value = 1;
// value++;
// Console.WriteLine("First: " + value);
// Console.WriteLine($"Second: {value++}");
// Console.WriteLine("Third: " + value);
// Console.WriteLine("Fourth: " + (++value));

// int fahrenheit = 94; 

// decimal celsius = (5M / 9M) * (decimal)(fahrenheit - 32);
// Console.WriteLine($"Celsius temperature is: {celsius}°C");

// int result = 3 + 1 * 5 / 2; // C# always rounds down for integer division

// Console.WriteLine(5 / 10);

// int number1 = (int) 13/7 ;
// int number2 = 13/7 ; 
// decimal number3 = (decimal)13/7 ;
// decimal number5 = (decimal)(13/7) ;
// decimal number4 = 13M/7M ;
// Console.WriteLine($"number1: {number1}, number2: {number2}, number3: {number3}, number4: {number4}, number5: {number5}");

// Console console = new Console(); 
// //Random random = new System.Random();

// Random().Next(1, 100);

// int first = 2;
// string second = "4";
// string result = first + second;
// Console.WriteLine(result);

int value1 = 11;
decimal value2 = 6.2m;
float value3 = 4.3f;

int result1 = Convert.ToInt32(Math.Round(Convert.ToDecimal(value1) / value2));

decimal result2 = value2 / Convert.ToDecimal(value3);

float result3 = value3 / Convert.ToSingle(value1); 

// Your code here to set result1
// Hint: You need to round the result to nearest integer (don't just truncate)
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// Your code here to set result2
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// Your code here to set result3
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");

string pangram = "The quick brown fox jumps over the lazy dog";

string[] pangramList = pangram.Split(' '); 

for(int i = 0; i < pangramList.Length; i++)
{
   char[]charArray = pangramList[i].ToCharArray();
   Array.Reverse(charArray);
   pangramList[i] = String.Join("", charArray);
}
    

Console.WriteLine(String.Join(" ", pangramList));

string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

// Your logic here

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = $"Our new product, {newProduct} offers a return of {newReturn:P2}. Given your current volume, your potential profit would be {newProfit:C}";
comparisonMessage = currentProduct.PadRight(20);
comparisonMessage += String.Format($"{currentReturn:P}");
comparisonMessage += String.Format("{0:C}", currentProfit);

comparisonMessage += "\n";
comparisonMessage += newProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", newReturn);
comparisonMessage += String.Format("{0:C}", newProfit);
// Your logic here

Console.WriteLine(comparisonMessage);

string s = "hello";
char c = s[1];

var vowels = s.Where(c => "aeiou".Contains(c));

foreach (var v in vowels)
{
    Console.WriteLine(v);
} 

const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here

var quantityIndex = input.IndexOfAny(['1','2','3','4','5','6','7','8','9','0']);
var quantityLastIndex = input.LastIndexOfAny(['1','2','3','4','5','6','7','8','9','0']);

quantity = input.Substring(quantityIndex, quantityLastIndex - quantityIndex);

Console.WriteLine(quantity);
Console.WriteLine(output);
