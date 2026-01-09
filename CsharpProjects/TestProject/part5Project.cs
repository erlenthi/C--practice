// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, C#!");
/*Created with copilot*/

// - The code declares the following variables:
//     - Variables to determine the size of the Terminal window.
//     - Variables to track the locations of the player and food.
//     - Arrays `states` and `foods` to provide available player and food appearances
//     - Variables to track the current player and food appearance
int playerX = 0, playerY = 0;
int foodX = 0, foodY = 0;
int currentPlayerIndex = 0;
int currentFoodIndex = 0;
string[] states = { "@", "♠", "♣", "♥", "♦" };
string[] foods = { "🍎", "🍊", "🍋", "🍌", "🍉" };
int movementSpeed = 100;
bool isPlayerFrozen = false;
int freezeCounter = 0;

// - The code provides the following methods:
//     - A method to determine if the Terminal window was resized.
//     - A method to display a random food appearance at a random location.
//     - A method that changes the player appearance to match the food consumed.
//     - A method that temporarily freezes the player movement.
//     - A method that moves the player according to directional input.
//     - A method that sets up the initial game state.

// Initialize the game
Console.Clear();
int windowWidth = Console.WindowWidth;
int windowHeight = Console.WindowHeight;
foodX = Random.Shared.Next(0, windowWidth);
foodY = Random.Shared.Next(0, windowHeight);
Console.SetCursorPosition(foodX, foodY);
Console.Write(foods[currentFoodIndex]);

// Main game loop
while (true)
{
    // Check if terminal was resized
    if (Console.WindowWidth != windowWidth || Console.WindowHeight != windowHeight)
    {
        Console.WriteLine("\nTerminal was resized. Game over!");
        break;
    }

    // Handle player input
    if (Console.KeyAvailable)
    {
        ConsoleKey key = Console.ReadKey(true).Key;
        
        // Check for unsupported keys and terminate if needed
        if (key != ConsoleKey.UpArrow && key != ConsoleKey.DownArrow && 
            key != ConsoleKey.LeftArrow && key != ConsoleKey.RightArrow)
        {
            Console.WriteLine("\nUnsupported key pressed. Game over!");
            break;
        }
        
        MovePlayer(key);
    }

    // Check if player consumed food
    if (playerX == foodX && playerY == foodY)
    {
        // Change player appearance
        currentPlayerIndex = currentFoodIndex;
        
        // Check if food freezes player
        if (currentFoodIndex == 1) // Example: ♠ freezes player
        {
            isPlayerFrozen = true;
            freezeCounter = 5;
        }
        
        // Check if food increases movement speed
        if (currentFoodIndex == 2) // Example: ♣ increases speed
        {
            movementSpeed = Math.Max(50, movementSpeed - 20);
        }
        
        // Redisplay food at new location
        currentFoodIndex = Random.Shared.Next(0, foods.Length);
        foodX = Random.Shared.Next(0, windowWidth);
        foodY = Random.Shared.Next(0, windowHeight);
        Console.SetCursorPosition(foodX, foodY);
        Console.Write(foods[currentFoodIndex]);
    }

    // Update freeze counter
    if (isPlayerFrozen && freezeCounter > 0)
    {
        freezeCounter--;
        if (freezeCounter == 0)
            isPlayerFrozen = false;
    }

    System.Threading.Thread.Sleep(movementSpeed);
}

// - The code doesn't call the methods correctly to make the game playable. The following features are missing:
//     - Code to determine if the player has consumed the food displayed.
//     - Code to determine if the food consumed should freeze player movement.
//     - Code to determine if the food consumed should increase player movement.
//     - Code to increase movement speed.
//     - Code to redisplay the food after it's consumed by the player.
//     - Code to terminate execution if an unsupported key is entered.
//     - Code to terminate execution if the terminal was resized.
void MovePlayer(ConsoleKey key)
{
    if (isPlayerFrozen)
        return;

    int newX = playerX;
    int newY = playerY;

    switch (key)
    {
        case ConsoleKey.UpArrow:
            newY = Math.Max(0, playerY - 1);
            break;
        case ConsoleKey.DownArrow:
            newY = Math.Min(Console.WindowHeight - 1, playerY + 1);
            break;
        case ConsoleKey.LeftArrow:
            newX = Math.Max(0, playerX - 1);
            break;
        case ConsoleKey.RightArrow:
            newX = Math.Min(Console.WindowWidth - 1, playerX + 1);
            break;
    }

    // Clear old position
    Console.SetCursorPosition(playerX, playerY);
    Console.Write(" ");

    // Update position and draw
    playerX = newX;
    playerY = newY;
    Console.SetCursorPosition(playerX, playerY);
    Console.Write(states[currentPlayerIndex]);
}