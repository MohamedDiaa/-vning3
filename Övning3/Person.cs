using System;
namespace Övning3
{
    public class Person
    {
        private int age;
        private string fName;
        private string lName;
        private double height;
        private double weight;


        public Person(int age, string fName, string lName, double height, double weight)
        {
            this.Age = age;
            this.FName = fName;
            this.LName = lName;
            this.Height = height;
            this.Weight = weight;
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Age kan bara tilldelas ett värde större än 0.");
                }
                this.age = value;
            }
        }

        public string FName
        {
            get { return this.fName; }
            set
            {
                if (value.Length < 2 || value.Length > 10)
                {
                    throw new ArgumentException("FName är obligatorisk och får inte vara mindre än 2 tecken eller längre än 10 tecken");
                }
                this.fName = value;
            }
        }

        public string LName
        {
            get { return this.lName; }
            set
            {
                if (value.Length < 3 || value.Length > 15)
                {
                    throw new ArgumentException("LName är obligatorisk och får inte vara mindre än 3 tecken eller större än 15\ntecken.");
                }
                this.lName = value;
            }
        }

        public double Height
        {
            get { return this.height; }
            internal set { this.height = value; }
        }

        public double Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }

        public override string ToString()
        {
            return $"{this.fName} {this.lName} is {this.age} years old and is {this.height} cm and {this.weight} kg.";
        }
    }
}

