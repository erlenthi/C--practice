using System.ComponentModel;

Console.WriteLine("Hello World!");

/*  string name = "42";


// // This will cause a compile-time error due to type mismatch
//     static int AddNumbers(int a, int b)
//     {
//         return a + b;
//     }

//     int result = AddNumbers("hello", 3);
//     Console.WriteLine(result);

*/ 

int globalVar = 10;
Console.WriteLine($"Before scope: {globalVar}");

{
    globalVar = 20;
    //int newVar = 30; 
    Console.WriteLine($"Inside scope: {globalVar}");
}

Console.WriteLine($"After scope: {globalVar}");
//Console.WriteLine($"newVar: {newVar}"); // This will cause a compile-time error