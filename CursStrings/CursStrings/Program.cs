public static class Program
{
    public static void Main()
    {
        // Declare strings
        string myFirstString = "Hello, World!";
        Console.WriteLine(myFirstString);

        int myNumber = 42;
        Console.WriteLine(myNumber);    

        string myNumberAsString = myNumber.ToString();

        // Manipulating strings;
        // Concatenation;
        string firstName = "Ionel";
        string lastName = "Popescu";
        string fullName = firstName + " " + lastName;


        string fullNameWithConcat = String.Concat(firstName, " ", lastName);
        Console.WriteLine(fullName);
        Console.WriteLine(fullNameWithConcat);
        Console.WriteLine($"{firstName} {lastName}");

    }
}