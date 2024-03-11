namespace Polymorfism;

class Program
{
    static void Main(string[] args)
    {

        List<UserError> userErrors = new List<UserError>
        {
            new TextInputError(),
            new TextInputError(),
            new NumericInputError(),
            new NumericInputError(),
            new TextInputError(),
            new NumericInputError()
        };

        foreach (UserError error in userErrors) {

            Console.WriteLine(error.UEMessage());
        }
    }
}

