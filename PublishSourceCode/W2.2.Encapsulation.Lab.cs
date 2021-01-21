using PersonsInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace W2._2Encapsulation.Lab
{
    class Program
    {
        // static void Main()
        // {
        //     //var app = new SortPersonsByNameAndAge();
        //     //var app = new SalaryIncrease();
        //     //var app = new ValidationOfData();
        //     var app = new FirstAndReserveTeam();

        //     app.Run();

        //     //Console.ReadKey(true);
        // }
    }
    public class SortPersonsByNameAndAge
    {
        public void Run()
        {
            var personNumber = int.Parse(Console.ReadLine());

            var persons = new List<Person1>();
            for (int i = 0; i < personNumber; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                var firstName = line[0];
                var lastName = line[1];
                var age = int.Parse(line[2]);
                persons.Add(new Person1(firstName, lastName, age));
            }

            persons = persons.OrderBy(p => p.FirstName).ThenBy(p => p.Age).ToList();

            foreach (var person in persons)
                Console.WriteLine(person);
        }
    }
    public class SalaryIncrease
    {
        public void Run()
        {
            var personNumber = int.Parse(Console.ReadLine());

            var persons = new List<Person2>();
            for (int i = 0; i < personNumber; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                var firstName = line[0];
                var lastName = line[1];
                var age = int.Parse(line[2]);
                var salary = decimal.Parse(line[3]);
                persons.Add(new Person2(firstName, lastName, age, salary));
            }

            var salaryRaisePercent = decimal.Parse(Console.ReadLine());

            foreach (var person in persons)
            {
                person.RaiseSalary(salaryRaisePercent);
                Console.WriteLine(person);
            }
        }
    }
    public class ValidationOfData
    {
        public void Run()
        {
            var personNumber = int.Parse(Console.ReadLine());
            var builder = new StringBuilder();
            var persons = new List<Person3>();

            for (int i = 0; i < personNumber; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                var firstName = line[0];
                var lastName = line[1];
                var age = int.Parse(line[2]);
                var salary = decimal.Parse(line[3]);
                try
                {
                    var person = new Person3(firstName, lastName, age, salary);
                    persons.Add(person);
                }
                catch (ArgumentException error)
                {
                    persons.Add(null);
                    builder.AppendLine(error.Message);
                }
            }
            var salaryRaisePercent = decimal.Parse(Console.ReadLine());

            Console.Write(builder);
            foreach (var person in persons)
                if (person != null)
                {
                    person.RaiseSalary(salaryRaisePercent);
                    Console.WriteLine(person);
                }
        }
    }
    public class FirstAndReserveTeam
    {
        public void Run()
        {
            var personNumber = int.Parse(Console.ReadLine());

            var persons = new List<Person3>();
            for (int i = 0; i < personNumber; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                var firstName = line[0];
                var lastName = line[1];
                var age = int.Parse(line[2]);
                var salary = decimal.Parse(line[3]);

                var person = new Person3(firstName, lastName, age, salary);
                persons.Add(person);
            }

            var team = new Team("SoftUni");
            foreach (var person in persons)
                team.AddPlayer(person);

            Console.WriteLine($"First team has {team.First.Count} players.");
            Console.WriteLine($"Reserve team has {team.Reserve.Count} players.");
        }
    }
}

namespace PersonsInfo
{
    public class Person1
    {
        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }
        public int Age { get; protected set; }

        public Person1(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} is {this.Age} years olds.";
        }
    }
    public class Person2 : Person1
    {
        public decimal Salary { get; protected set; }

        public Person2(string firstName, string lastName, int age, decimal salary) : base(firstName, lastName, age)
        {
            Salary = salary;
        }
        public void RaiseSalary(decimal raisePercent) => Salary *= (raisePercent / 100 + 1);
        public override string ToString()
        {
            return $"{FirstName} {LastName} receives {Decimal.Round(Salary, 2)} leva.";
        }
    }
    public class Person3
    {
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;

        public Person3(string firstName, string lastName, int age, decimal salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;
        }
        public string FirstName
        {
            get => firstName; protected set
            {
                if (value.Length < 3)
                    throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
                firstName = value;
            }
        }
        public string LastName
        {
            get => lastName; protected set
            {
                if (value.Length < 3)
                    throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
                lastName = value;
            }
        }
        public int Age
        {
            get => age;
            private set
            {
                if (value < 0)
                    throw new ArgumentException("Age cannot be zero or a negative integer!");
                age = value;
            }
        }
        public decimal Salary
        {
            get => salary; protected set
            {
                if (value < 460)
                    throw new ArgumentException("Salary cannot be less than 460 leva!");
                salary = value;
            }
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName} gets {Decimal.Round(Salary, 2)} leva.";
        }
        public void RaiseSalary(decimal raisePercent) => Salary *= (raisePercent / 100 + 1);
    }
    public class Team
    {
        public string Name { get; private set; }
        public List<Person3> First { get; }
        public List<Person3> Reserve { get; }

        public Team(string name)
        {
            if (!string.IsNullOrWhiteSpace(name))
                Name = name;
            else
                throw new ArgumentException("Team name is null, empty or only consists of white-space characters");
            First = new List<Person3>();
            Reserve = new List<Person3>();
        }
        public void AddPlayer(Person3 person)
        {
            if (person.Age < 40)
                First.Add(person);
            else
                Reserve.Add(person);
        }
    }
}

