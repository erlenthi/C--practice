using System.Reflection.Metadata.Ecma335;

void SayHello() 
{
    Console.WriteLine("Hello World!");
}

Random random = new Random();
int luck = random.Next(100);
DisplayFortune(luck);


void DisplayFortune(int luck)
{
    string[] text = {"You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to"};
string[] good = {"look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!"};
string[] bad = {"fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life."};
string[] neutral = {"appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature."};

Console.WriteLine("A fortune teller whispers the following words:");
string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
for (int i = 0; i < 4; i++) 
{
    Console.Write($"{text[i]} {fortune[i]} ");
}
} 

int status = 3;

Console.WriteLine($"Start: {status}");
SetHealth(false);
Console.WriteLine($"End: {status}");

void SetHealth(bool isHealthy) 
{
    status = (isHealthy ? 3 : 4);
    Console.WriteLine($"Middle: {status}");
}

// Create C# methods with parameters 
// Exercise - Complete the challenge to display email addresses

string[,] corporate = 
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external = 
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};
string internalDomain = "contoso.com";
string externalDomain = "hayworth.com";

for (int i = 0; i < corporate.GetLength(0); i++) 
{
    // display internal email addresses
    displayEmail(corporate[i,0], corporate[i,1], internalDomain);
}

for (int i = 0; i < external.GetLength(0); i++) 
{
    // display external email addresses
    displayEmail(external[i,0], external[i,1], externalDomain);

}

void displayEmail(string firstName, string lastName, string domain)
{   
    if(firstName.Length >= 2) Console.WriteLine(firstName.ToLower().Remove(2)+lastName.ToLower()+"@"+domain);
}

//Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay()) 
{
    PlayGame();
}

void PlayGame() 
{
    var play = true;

    while (play) 
    {
        var target = random.Next(1,5);
        var roll = random.Next(1,6);

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(target, roll));
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}

string WinOrLose(int target, int roll)
{
    if(roll > target) return "You win!";
    else if(roll == target) return "Tie!";
    else return "You Lose!"; 
}

bool ShouldPlay()
{
    while (true)
    {
        string? userInput = Console.ReadLine();
        if(userInput != null)
        {
            if(userInput == "Y") return true;
            if(userInput == "N") return false;
            Console.WriteLine("Would you like to play? (Y/N)");
        }
        
    }
    
}

