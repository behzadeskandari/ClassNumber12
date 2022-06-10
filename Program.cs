using System;
using System.Collections.Generic;
using System.IO;

namespace ClassNumber12
{

    /// <summary>
    /// C# Interfaces
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            #region [IEquatable]
            //Employee employee1 = new Employee(1, "behzad");

            //Employee employee2 = new Employee(2, "hasan");

            //Ticket ticket = new Ticket(18,"javad");
            //Ticket ticket2 = new Ticket(12,"javad");


            //int x = 10;
            //int y = 10;
            //bool IsEqual = x.Equals(y);
            /////returns true
            //Console.WriteLine(IsEqual);


            //bool IsEqual2 = employee1.Equals(employee2);
            /////returns false


            //bool IsEqual3 = ticket.Equals(ticket2);
            //Console.WriteLine("IsEqual3");
            //Console.WriteLine(IsEqual3);

            #endregion

            #region [IComparable]
            //List<Employee> lstemployees = new List<Employee>();

            //lstemployees.Add(new Employee(){Id = 1,Name = "behzad"});
            //lstemployees.Add(new Employee(){Id = 6,Name = "javad"});
            //lstemployees.Add(new Employee(){Id = 4,Name = "hasan"});
            //lstemployees.Add(new Employee(){Id = 9,Name = "reza"});
            //lstemployees.Add(new Employee(){Id = 15,Name = "majid"});
            //lstemployees.Add(new Employee(){Id = 16,Name = "mohsen"});
            //lstemployees.Add(new Employee(){Id = 17,Name = "abbas"});
            //lstemployees.Add(new Employee(){Id = 18,Name = "Imaan"});
            //lstemployees.Add(new Employee(){Id = 19,Name = "abasmirza"});
            //lstemployees.Add(new Employee(){Id = 20,Name = "hasankachal"});

            //lstemployees.Sort();

            //Employee employee = new Employee();

            //Console.WriteLine("Enter The Employee Id");
            //int empId = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter The Employee Name");
            //string empName = Console.ReadLine();

            //employee.Id = empId;
            //employee.Name = empName;


            //foreach (var item in lstemployees)
            //{

            //    int ValueHolder = item.CompareTo(employee);

            //    //Console.WriteLine("Item is : ");
            //    //Console.WriteLine(item);
            //    if (ValueHolder == 0)
            //    {
            //        Console.WriteLine("Equals");
            //    }
            //    else if (ValueHolder == 1)
            //    {
            //        Console.WriteLine("False");
            //    }
            //    else if (ValueHolder == -1)
            //    {
            //        Console.WriteLine("True");
            //    }
            //    //Console.WriteLine("Value Holder");
            //    //Console.WriteLine(ValueHolder);
            //}



            //foreach (var item in lstemployees)
            //{
            //    Console.WriteLine(item.ToString());
            //}

            #endregion

            #region [Dictionary]

            //Dictionary<int, string> lstDic = new Dictionary<int, string>() { { 1, "behzad" }, { 2, "behzad2" } };

            //lstDic.Add(4,"hasan");
            //lstDic.Add(7,"reza ");
            //lstDic.Add(5,"majid");
            //foreach (var item in lstDic)
            //{
            //    Console.WriteLine($"{item.Key}, {item.Value}");
            //}




            //string[] roles = { "Teacher", "CTO", "Swmmier", "MaghazeDar", "arayeshgar", "salmoni", "mosalmon", "bongahDar", "taghi" };

            //Dictionary<string, Employee> lstDic = new Dictionary<string, Employee>();

            //for (int i = 0; i < lstemployees.Count - 1; i++)
            //{
            //    lstDic.Add(roles[i], lstemployees[i]);
            //}
            //foreach (var item in lstDic)
            //{
            //    Console.WriteLine($"{item.Key} and {item.Value} ");
            //}

            #endregion


            #region [Recursive function]
            Console.WriteLine("Enter The start number");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter The start number");

            int b = Convert.ToInt32(Console.ReadLine());

            //int result = AddRecursively(n,m);


            int result = SecondRecursive(a,b);


            
            Console.WriteLine(result);

            #endregion

            #region [IO]

            //string Contains = File.ReadAllText(@"/users/abtin/desktop/text.txt");

            //string[] lstStr = File.ReadAllLines(@"/users/abtin/desktop/text.txt");

            //foreach (var item in lstStr)
            //{
            //    Console.WriteLine(item);
            //}
            Console.WriteLine("Enter The Line You Want TO Save In Text");
            
            string text = Console.ReadLine();
           
            File.AppendAllText(@"D:\test.txt", text);
               



            #endregion

        }
        public static int AddRecursively(int n, int m)
        {
            int sum = n;
            if (n < m)
            {
                return AddRecursively(n + 1, m) + n;
            }else
            {
                return n;
            }
        }

        
        public static int SecondRecursive(int a,int b)
        {
            if (a % 2== 0)
            {
                a++;
            }
            if (b % 2 == 0)
            {
                b--;
            }
            if (a< b)
            {
                return (a + SecondRecursive(a + 2, b));
            }
            else
            {
                return b;
            }

            //if (AddadBozorg < AdadYeraghami)
            //{
            //    return AddadBozorg;
            //}
            //else
            //{
            //    if (AddadBozorg % 2 == 1)
            //    {
            //        return AddRecursively(AddadBozorg + 2, AdadYeraghami);
            //    }

            //    return 1;
            //}
            
        }


     
    }


    public class Employee: IComparable<Employee>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int CompareTo(Employee other)
        {
            //    ///return addad mosbat bashe yani bozorge ine 
            //    ///return addad manfi bashead yani kochkie ine 
            //    ///return addad 0 bashad yani mosavist

            return Name.CompareTo(other.Name);
            //if (Name.Contains(other.Name.ToString()))
            //{
            //    return 1;
            //}
            //else if (!Name.Contains(other.Name.ToString()))
            //{
            //    return -1;
            //}

            //return 0;
        }

        //public int CompareTo(Employee other)
        //{
        //    ///return addad mosbat bashe yani bozorge ine 
        //    ///return addad manfi bashead yani kochkie ine 
        //    ///return addad 0 bashad yani mosavist

        //    if (Id > other.Id)
        //    {
        //        return 1;
        //    }
        //    else if(Id < other.Id)
        //    {
        //        return -1;
        //    }

        //    return 0;
        //}

        //public Employee(int Id, string name)
        //{
        //    this.Id = Id;
        //    this.Name = name;
        //}

        public override string ToString()
        {
            return Id + " " + Name;
        }

    }

    //public class Ticket : IEquatable<Ticket>
    //{
    //    public int DurationInHour { get; set; }
    //    public string Name { get; set; }
    //    public Ticket(int durationInHour,string name)
    //    {
    //        this.DurationInHour = durationInHour;
    //        this.Name = name;
    //    }
        
    //    public bool Equals(Ticket other)
    //    {
    //        if (DurationInHour == other.DurationInHour && Name == other.Name)
    //        {
    //            return true;
    //        }
    //        else
    //        {
    //            return false;
    //        }

    //        //return (DurationInHour == other.DurationInHour) ? true : false;
    //    }
    //}

}

