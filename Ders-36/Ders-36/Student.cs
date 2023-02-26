

using System;
namespace Methods
{
    public class Student
    {
        private string name;
        private string surname;
        private int age;
        private string space;

        public string NAME
        {
            get { return name; }
            set { name = value; }
        }

        public string SURNAME
        {
            get { return surname; }
            set { surname = value; }
        }

        public string SPACE
        {
            get { return space; }
            set { space = value; }
        }

        public int AGE
        {
            get { return age; }
            set
            {
                if (age < 18)
                {
                    age = 18;
                }
                else
                {
                    age = value;
                }
            }
        }
    }
}

