/**
 * a class that combine all small projects
 * in learning c#
 */
public class Projects
{
    // building a mad libs game
    public void MadLibs()
    {
        string? name, color, pluralNoun, celebrity;

        // requesting for name
        Console.Write("What's your name? ");
        name = Console.ReadLine();
        Console.WriteLine("Hello " + name + " .\nI want to recite a poem for you");

        // requesting for color
        Console.Write("Enter a color: ");
        color = Console.ReadLine();

        // requesting for a plural noun
        Console.Write("Enter a plural noun: ");
        pluralNoun = Console.ReadLine();

        // requesting for a celebrity
        Console.Write("Who is your favorite celebrity? ");
        celebrity = Console.ReadLine();

        Console.Write("Are you ready? ");
        // the response dooesn't matter for now
        Console.ReadLine();

        // putting together the Mad libs
        Console.WriteLine("Roses are " + color);
        Console.WriteLine(pluralNoun + " are blue");
        Console.WriteLine("I love " + celebrity);
    }

    // getting the maximum of three numbers
    public int GetMax(int num1, int num2, int num3)
    {
        int result;

        if (num1 >= num2 && num1 >= num3)
        {
            result = num1;
        }else if (num2 >= num1 && num2 >= num3)
        {
            result = num2;
        }else
        {
            result = num3;
        }

        return result;
    }

    // building a guessing game
    public void GuessingGame()
    {
        string secretWord = "giraffe";
        string? guess = "";
        int guessCount = 0;
        int guessLimit = 3;
        bool OutOfGuesses = false;

        while (guess != secretWord & !OutOfGuesses) 
        {
            if (guessCount < guessLimit)
            {
                Console.Write("Guess the word: ");
                guess = Console.ReadLine();
                guessCount++;
            }
            else
            {
                OutOfGuesses = true;
            }
        }
        if (OutOfGuesses)
        {
            Console.Write("You Lose! Try again later");
        }
        else
        {
            Console.Write("You Win! Brilliant Chap");
        }
    }

    // An exponent function for positive numbers
    public int Exponent(int basNum, int expNum)
    {
        int result = 1;

        for (int i = 0; i < expNum; i++)
        {
            result *= basNum;
        }

        return result;
    }
}