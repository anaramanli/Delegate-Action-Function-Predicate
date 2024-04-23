using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Person
    {
		private string _name;

		public string Name
		{
			get { return _name; }
			set {
                if (value.Length <25)
                {
                    _name = value;
                }
            }
		}
		private string _surname;

		public string Surname
		{
			get { return _surname; }
			set {
                if (value.Length < 25)
                {
                    _surname = value;
                }
            }
		}

        private int _age;
        public int Age
        {
            get => _age;
            set
            {
                if (value <150 && value >0)
                {
                    _age = value;
                }
            }
        }

        public Person(string name, string surname, int age)
        {
            Name = name;
			Surname = surname;
			Age = age;
        }
	}
}
