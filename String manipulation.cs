/*
string s = "You win some. You lose some.";

// created a string array called subs which will hold the sub strings.
https://docs.microsoft.com/en-us/dotnet/api/system.string.split?view=net-6.0

// This looks for white space ' ' which it will break the string at to create sub strings
// these sub strings are then placed inside the string array called subs
string[] subs = s.Split(' ', '.');

// itterate over and dsisplay each of the elements in string array called sub
foreach (var sub in subs)
{
    Console.WriteLine($"Substring: {sub}");
}

// This example produces the following output:
//
// Substring: You
// Substring: win
// Substring: some.
// Substring: You
// Substring: lose
// Substring: some.

*/


/*

// string variable called s2 containing a string
string s2 = "You win some. You lose some.";

// created a char array called seperator, it contains ' ' and '.'
char[] separators = new char[] { ' ', '.' };


// created a string array called subs2 which will contain the result of the .Split method.
// it uses the elements in the seperators array while it is doing its task 
string[] subs2 = s2.Split(separators, StringSplitOptions.RemoveEmptyEntries);

foreach (var sub in subs2)
{
    Console.WriteLine($"Substring: {sub}");
}

// This example produces the following output:
//
// Substring: You
// Substring: win
// Substring: some
// Substring: You
// Substring: lose
// Substring: some

// ---------------------------------------------------------\\
// *** Using .IndexOf and the .Substring string methods *** \\

// string of interest
string logLine = "Hello: I'm Hussein";

// setting an int variable called found to store the index of found string
int found = 0;

// using the .IndexOf method on the logLine string to locate the first instance of ": "
// this is then stored in the found variable
found = logLine.IndexOf(": ");
// displaying the int stored in found to tell me which index the ": " instance was found at
// It is as 5 (remember it is zero indexed )
Console.WriteLine(found);

// Using the substring method that accepts an int as a parameter, it will disect string
// at that index and keep anything after that point, which it returns as a string,
// this is stored in the seperator variable
string seperator = logLine.Substring(found + 2);
// displaying the seperated string
Console.WriteLine(seperator);




*/

/*
 * 
string openingStatement = "Hello new recruit Delta, welcome to space station Delta";


// the "\" and \"" add quotation marks before and after a string.
Console.WriteLine($"\"{openingStatement}\"");

int first = openingStatement.IndexOf("Delta") + "Delta".Length;
Console.WriteLine(first);
int second = openingStatement.LastIndexOf("Delta");
Console.WriteLine(second);
string str2 = openingStatement.Substring(first, second - first);    
Console.WriteLine($"Substring between \"Delta\" and \"Delta\": '{str2}");   


*/


/*
//------------------------------------------\\
// Great tutorial - IndexOf and LastIndexOf \\
// https://docs.microsoft.com/en-us/dotnet/csharp/how-to/search-strings#where-does-the-sought-text-occur-in-a-string

string logLine = "\"[ERROR]: Invalid operation\"";
Console.WriteLine(logLine);


// Finds the index of the first occurance of ":" in the string
// Then that index value has the length of ": " (including space) added to it,
// This takes those characters in to account so they are not included later on
int first = logLine.IndexOf(": ") + ":".Length;
Console.WriteLine($"Checking index number of first: {first}");

int last = logLine.LastIndexOf('"');
Console.WriteLine($"Checking index number of last: {last}");

string statement = logLine.Substring(first, last - first);
Console.WriteLine($"\"{statement}\"");
var trim = statement.Trim();

Console.WriteLine($"\"{trim}\"");

*/



string message = "[WARNING]: Invalid operation";


int first = message.IndexOf('[') + "[".Length;
int last = message.LastIndexOf(']');

string refined = message.Substring(first, last - first);    
string lowerTransform = refined.ToLower();

string test = $"\"{lowerTransform}\"";
Console.WriteLine(test);



/*
string output = LogLine.Message("[WARNING]:   \tTimezone not set  \r\n");
Console.WriteLine(output);
static class LogLine
{
    public static string Message(string logLine)
    {

        int first = logLine.IndexOf(": ") + ": ".Length;

        // int last = logLine.LastIndexOf('"');

        string statement = logLine.Substring(first);
        string trim = statement.Trim();
        string final = $"\"{trim}\"";

        return final;


        throw new NotImplementedException("Please implement the (static) LogLine.Message() method");
    }
}

*/



/* 

string output = LogLine.Message("[WARNING]:   \tTimezone not set  \r\n");
Console.WriteLine(output);
static class LogLine
{
    public static string Message(string logLine)
    {

        // section 1: isolates message

        int first = logLine.IndexOf(": ") + ": ".Length;

        // int last = logLine.LastIndexOf('"');

        string statement = logLine.Substring(first);
        string trim = statement.Trim();
        string final = $"\"{trim}\"";

        int first = message.IndexOf('[') + "[".Length;
        int last = message.LastIndexOf(']');

        string refined = message.Substring(first, last - first);
        string lowerTransform = refined.ToLower();

        string test = $"\"{lowerTransform}\"";

        return final;
    }
}

*/