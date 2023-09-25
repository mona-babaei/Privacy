using System;using System;using System.Collections.Generic;using System.Linq;using System.Text;using System.Threading.Tasks;namespace Privacy;

public class Program
{
    static void Main(string[] args)
    {
        var personHandler = new PersonHandler();

        try
        {
            var person = personHandler.CreatePerson(-1, "Test", "User");
        }
        catch (ArgumentException e)
        {
            Console.WriteLine($"Fel med ålder:{e.Message}");
        }

        var validPerson = personHandler.CreatePerson(25, "Test", "User");
        try
        {
            personHandler.setFirstName(validPerson, "A");
        }
        catch (ArgumentException e)
        {
            Console.WriteLine($"Fel med FName:{e.Message}");
        }

        try
        {
            personHandler.setLastName(validPerson, "Al");
        }
        catch (ArgumentException e)
        {
            Console.WriteLine($"Fel LName:{e.Message}");
            Console.ReadLine();
            _ = Console.ReadKey();
        
        }
    }
}

