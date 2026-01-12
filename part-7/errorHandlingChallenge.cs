using System.Data;
using System.Diagnostics;

string[][] userEnteredValues = new string[][]
{
            new string[] { "1", "2", "3"},
            new string[] { "1", "two", "3"},
            new string[] { "0", "1", "2"}
};

Boolean processError = false;

try
{

    Workflow1(userEnteredValues);

}
catch (Exception e)
{
    Console.WriteLine("An error occurred during 'Workflow1'.");
    Console.WriteLine(e.Message);
}
// if (overallStatusMessage == "operating procedure complete")
// {
//     Console.WriteLine("'Workflow1' completed successfully.");
// }
// else
// {
//     Console.WriteLine("An error occurred during 'Workflow1'.");
//     Console.WriteLine(overallStatusMessage);
// }

static void Workflow1(string[][] userEnteredValues)
{


    try
    {
        foreach (string[] userEntries in userEnteredValues)
        {

            Process1(userEntries);

            Console.WriteLine("'Process1' completed successfully.");
            Console.WriteLine();



        }

    }
    catch (Exception e)
    {
        Console.WriteLine("'Workflow1' encountered an issue, process aborted.");
        Console.WriteLine($"Exception type: {e.Message}");
        Console.WriteLine();
    }


}

static void Process1(String[] userEntries)
{
    string processStatus = "clean";
    string returnMessage = "";
    int valueEntered;

    foreach (string userValue in userEntries)
    {

        try
        {
            
            if (!int.TryParse(userValue, out valueEntered)) throw new FormatException("Expected numbers");
            if (valueEntered == 0) throw new DivideByZeroException("Value can't be 0");

            checked
            {
                int calculatedValue = 4 / valueEntered;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Exception: {e.Message}");
            throw;
        } 
    }

}

