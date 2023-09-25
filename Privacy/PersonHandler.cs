using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privacy;

public class PersonHandler
{
    public void SetAge(Person person, int age)
    {
        person.Age = age;
    }

    public void setFirstName(Person person, string firstName)
    {
        person.FirstName = firstName;
    }

    public void setLastName(Person person, string lastName)
    {
        person.LastName = lastName;
    }

    public Person CreatePerson(int age, string firstname, string lastName)
    {
        var person = new Person(firstname, lastName)
        {
            Age = age
        };

        return person;
    }
}
