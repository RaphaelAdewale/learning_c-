public class Identity
{
    public void input_persona()
    {
        // request for full name
        Console.WriteLine("Enter your full name: ");
        string? name = Console.ReadLine();
        Console.WriteLine("\n");

        //request for age
        Console.Write("How old are you? ");
        string? age = Console.ReadLine();
        Console.WriteLine("\n");
        
        //request for resident city
        Console.Write("Which city do you live? ");
        string? city = Console.ReadLine();
        Console.WriteLine("\n");

        //request for job
        Console.Write("What's your occupation? ");
        string? job = Console.ReadLine();
        Console.WriteLine("\n");

        Console.WriteLine(" Hello " + name);
        Console.WriteLine(" You are " + age + " years old");
        Console.WriteLine(" You live in " + city + " as a " + job);
    }

    public void write_persona()
    {
        string characterName = "Raphael Adewale";
        int characterAge = 24;
        string characterCity = "Lagos";
        string characterJob = "Software Engineer";
        char letter = 'a';

        Console.WriteLine("Hi, my name is " + characterName);
        Console.WriteLine("Please write your name in block letters");
        Console.WriteLine("Hi, my name is " + characterName.ToUpper());
        Console.WriteLine("The first character of my name is " + characterName[0] + " \n");
        Console.WriteLine("Does your name contain a/an \"" + letter + "\" ? ");
        Console.WriteLine(characterName.Contains(letter));
        Console.WriteLine("What is your nickname? " + characterName.Substring(0,4));
        Console.WriteLine("Where is it?");
        Console.WriteLine("It is the " + characterName.IndexOf(letter) + " character");
        Console.WriteLine("Are you from the Adewale family?");
        Console.WriteLine(characterName.Contains("Adewale"));        
        Console.WriteLine("I am " + characterAge + " years old");
        Console.WriteLine("I live in " + characterCity);
        Console.WriteLine("I am a " + characterJob);
        Console.WriteLine("My name is " + characterName.Length + " characters long");
    }
}