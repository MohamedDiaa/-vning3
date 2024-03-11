using System.Xml.Linq;

namespace Övning3;

class Program
{

    static void Main(string[] args)
    {

        PersonHandleren handler = new PersonHandleren();
        handler.CreatePerson(age: 15, fname: "Mohamed", lname: "Alwakil", height: 1.8, weight: 87);
    }
}

