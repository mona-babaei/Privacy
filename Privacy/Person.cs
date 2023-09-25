using System;using System.Collections.Generic;using System.Linq;using System.Text;using System.Threading.Tasks;
namespace Privacy;public class Person
{
    private int _age;
    private string _firstName;
    private string _lastName;

    public Person(string firstname, string lastName)
    {
        FirstName = firstname;
        LastName = lastName;
    }

    public void person (string firstName, string lastName)
       
    {
        FirstName = firstName ??
            throw new
            ArgumentNullException(nameof(firstName));
        LastName = lastName ??
            throw new
            ArgumentNullException(nameof(firstName));
       
    }
    
    public int Age
    {
        get { return _age; }
        set
        {
            if (value <= 0)
            {
                throw new
                    ArgumentException("Ålder måste vara större än 0.");
            }
            _age = value;
        }
    }

    public string FirstName

    {
        get { return _firstName; }
        set
        {
            if (string.IsNullOrEmpty(value) || value.Length < 2 || value.Length > 10) 
            {
                throw new
                    ArgumentException("FName måste vara mellan 2 och 10 tecken.");
            }
            _firstName = value;
        }
    }

    public string LastName
    {
        get { return _lastName; }
        set
        {
            if (string.IsNullOrEmpty(value) || value.Length < 3 || value.Length > 15) 
            {
                throw new ArgumentException("LName måste vara mellan 3 och 15 tecken.");
            }
            _lastName = value;
        }
    }
}