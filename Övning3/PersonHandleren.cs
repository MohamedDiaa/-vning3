using System;
namespace Övning3
{
	public class PersonHandleren
	{
		public PersonHandleren()
		{
		}


        public void SetAge(Person pers, int age) {

            try
            {
                pers.Age = age;
            }
            catch (ArgumentException e) {
                Console.WriteLine(e.Message);
            }
        }

        public void SetFName(Person pers, string fName)
        {
            try
            {
                pers.FName = fName;
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void SetLName(Person pers, string lName)
        {
            try
            {
                pers.LName = lName;
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        
        public void SetHeight(Person pers, double height)
        {
            pers.Height = height;
        }

        public void SetWeightI(Person pers, double weight)
        {
            pers.Weight = weight;
        }

        public Person CreatePerson(int age, string fname, string lname, double height, double weight) {

			Person pers = new Person(age: age, fName: fname, lName: lname, height: height, weight: weight);

			return pers;
		}
    }
}

