using CursStrings;
using System.Diagnostics;
using System.Globalization;
using System.Text;

public static class Program
{
    public static void Main()
    {
        Calculator calculator = new Calculator();
        var resssssult = calculator.Add(3, 5);
        var ressssult = calculator.Add(3, 6, 9);   
        
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
        Console.WriteLine($"{firstName} {lastName}");     // string interpolation;

        // Searching in strings;
        int index = fullName.IndexOf("Io"); // 0
        index = fullName.IndexOf("Popescu"); // 6
        index = fullName.IndexOf("POPESCU"); // -1 not found due to casing
        index = fullName.IndexOf("o", 1); // 1
        index = fullName.IndexOf("o", 1); // 7

        Console.WriteLine(index);

        #region Extract substring;
        // C:/Holiday/2025/1/nice_pic.png

        
        #endregion

        #region Comparing strings
        string str1 = "oradea";
        string str2 = "Oradea";

        int result = string.Compare(str1, str2, false);  //true - ignoring case; false - does not ignore case

        if (result == 0)
        {
            Console.WriteLine("str1 equals str2");
        }

        if (str1 == str2)
        {
            //
        }

        if (str1.Equals(str2))
        {
            //
        }
        #endregion

        #region Splitting

        string listOfCities = "London, Paris, Iasi, Cluj, Bucuresti.";
        string[] cities = listOfCities.Split(',', ' ', '.');

        foreach (string city in cities)
        {
            if (!string.IsNullOrWhiteSpace(city))
            {
                Console.WriteLine(city.ToUpper());
            }
        }

        #endregion

        // Trim
        string mySpacedString = "             this is a string           ";
        Console.WriteLine(mySpacedString.TrimStart());
        Console.WriteLine(mySpacedString.TrimEnd());
        Console.WriteLine(mySpacedString.Trim());

        string myFunnyString = "-++++this is a ++++++ string ++++-- ----";
        Console.WriteLine(myFunnyString.Trim('+', '-', ' '));
        Console.WriteLine(myFunnyString.Replace('+', ' '));

        // without string builder
        /*  var stopWatch = new Stopwatch();
          string myCoolString = "Counting bottles: ";

          stopWatch.Start();

          for (int i = 0; i < 10000; i++)
          { 
           myCoolString += i.ToString();
              Console.WriteLine(myCoolString);
          }
          stopWatch.Stop();
          Console.WriteLine(stopWatch.Elapsed.TotalSeconds.ToString());
          //28 seconds */

        //with string builder

        /* StringBuilder stringBuilder = new StringBuilder();
         var stopWatch2 = new Stopwatch();
         string myCoolString = "Counting bottles: ";

         stopWatch2.Start();

         stringBuilder.Append(myCoolString);

         for (int i = 0; i < 10000; i++)
         {
             //myCoolString += i.ToString();
             stringBuilder.Append(i.ToString());
             Console.WriteLine(i);
         }

         Console.WriteLine(stringBuilder.ToString());

         stopWatch2.Stop();
         Console.WriteLine(stopWatch2.Elapsed.TotalSeconds.ToString());
         //2.2 seconds */

        // String Formatting;

        double d = 0.375;
        string infoToDisplay = d.ToString("P");
        Console.WriteLine(infoToDisplay);

        string myFormattedString = String.Format("{0:F5}", d);
        Console.WriteLine(myFormattedString);


        // Datetime
        DateTime myDate = DateTime.Now;
        Console.WriteLine(myDate);

        var myFormattedDate = String.Format("{0:dd.MM.yyyy HH:mm:ss}", myDate);
        Console.WriteLine(myFormattedDate);

        CultureInfo culture = new CultureInfo("ro-RO");
        Console.WriteLine(myDate.ToString("d", culture));

        string myDate2 = "01.05.2024";
        DateTime futureDate = DateTime.ParseExact(myDate2, "dd.MM.yyyy", CultureInfo.InvariantCulture);
        var yesterday = futureDate.AddDays(-1);


        // String Interpolation;
        string student = "John";
        string age = "25";
        string str = $"Student {student} is {age} years old.";

        string myStudent = "John is \"the best\"";  //escaping character
        string myStudent2 = "John is 'the best'";  //escaping character using single quote
        string verbatimStudent = @"John is ""the best"" ";

        string spacedString = "this is my super " +
            "long string";
        string verbatimString = @"this is
my 
super 
long 
string";
        Console.WriteLine("Enter your text using quotes: ");
        string quote = Console.ReadLine();



    }
    



}