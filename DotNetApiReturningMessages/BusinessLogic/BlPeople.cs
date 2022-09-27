using LanguageExt.Common;
using ReturningMessages.Models;

namespace ReturningMessages.BusinessLogic;

public class BlPeople
{
    public Person GetPersonException(string id)
    {
        if (string.IsNullOrEmpty(id))
            throw new ArgumentNullException(nameof(id));

        Person? person = null;
        if (person == null)
            throw new NotfoundException($"Person with id \"{id}\"");

        return new Person("id", "Jack");
    }

    public Result<Person> GetPersonLanguageExt(string id)
    {
        if (string.IsNullOrEmpty(id))
            return new Result<Person>(new ArgumentNullException(nameof(id)));

        Person? person = null;
        if (person == null)
            return new Result<Person>(new NotfoundException($"Person with id \"{id}\""));

        return new Person("id", "Jack");
    }
}
