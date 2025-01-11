namespace oop3
{
    public class Class1
    {
        #region Q1
        public enum SecurityLevel
        {
            Guest,
            Developer,
            Secretary,
            DBA
        }
        public class Employee
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public SecurityLevel SecurityLevel { get; set; }
            public decimal Salary { get; set; }
            public HiringDate HireDate { get; set; }
            public char Gender { get; set; }

            public Employee(int id, string name, SecurityLevel securityLevel, decimal salary, HiringDate hireDate, char gender)
            {
                ID = id;
                Name = name;
                SecurityLevel = securityLevel;
                Salary = salary;
                HireDate = hireDate;
                Gender = gender;
            }

            public override string ToString()
            {
                return $"ID: {ID}, Name: {Name}, Security Level: {SecurityLevel}, Salary: {Salary.ToString("C")}, Hire Date: {HireDate}, Gender: {Gender}";
            }
        }

        #endregion
        #region Q2
        public class HiringDate
        {
            public int Day { get; set; }
            public int Month { get; set; }
            public int Year { get; set; }

            
            public HiringDate(int day, int month, int year)
            {
                Day = day;
                Month = month;
                Year = year;
            }

            
            public override string ToString()
            {
                return $"{Day}/{Month}/{Year}";
            }
        }
        #endregion
        #region Q3
        class Program
        {
            static void Main(string[] args)
            {
                Employee[] EmpArr = new Employee[3];
                EmpArr[0] = new Employee(1, "John Doe", SecurityLevel.DBA, 60000, new HiringDate(1, 1, 2022), 'M');
                EmpArr[1] = new Employee(2, "Jane Smith", SecurityLevel.Guest, 40000, new HiringDate(15, 3, 2021), 'F');
                EmpArr[2] = new Employee(3, "Peter Jones", SecurityLevel.DBA, 55000, new HiringDate(1, 1, 2023), 'M');

                #region Q4
                Array.Sort(EmpArr, (e1, e2) => e1.HireDate.Year.CompareTo(e2.HireDate.Year));
                foreach (Employee emp in EmpArr)
                {
                    Console.WriteLine(emp);
                }
                #endregion
            }
        }

        #endregion
        #region Q5
        public class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string ISBN { get; set; }

            public Book(string title, string author, string isbn)
            {
                Title = title;
                Author = author;
                ISBN = isbn;
            }
        }

        public class EBook : Book
        {
            public int FileSize { get; set; }

            public EBook(string title, string author, string isbn, int fileSize) : base(title, author, isbn)
            {
                FileSize = fileSize;
            }
        }

        public class PrintedBook : Book
        {
            public int PageCount { get; set; }

            public PrintedBook(string title, string author, string isbn, int pageCount) : base(title, author, isbn)
            {
                PageCount = pageCount;
            }
        }
        #endregion
    }
}
