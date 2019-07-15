using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise16
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee(1, "Leo", "Male", 5000000));
            employees.Add(new Employee(2, "Judy", "Female", 2400000));
            employees.Add(new Employee(3, "Amy", "Female", 3000000));
            employees.Add(new Employee(4, "Ted", "Male", 1200000));

            // 挑選出男性員工
            Console.WriteLine("男性員工名單為：");
            SelectMale(employees);
            #region 挑選男員工
            IEnumerable<Employee> group1 = from e in employees
                                           where e.Sex.Equals("Male")
                                           select e;
            foreach(Employee e in group1)            
                Console.Write(e.Name + "\t");
            #endregion


            // 挑選出年薪在200萬以上的員工                        
            Console.WriteLine("\n\n年薪在200萬以上的員工名單為：");
            SelectHigherTwoMillion(employees);
            #region 挑選出年薪在200萬以上的員工
            IEnumerable<Employee> group2 = from e in employees
                                           where e.Income >= 2000000
                                           select e;
            foreach (Employee e in group2)
                Console.Write(e.Name + "\t");
            #endregion

            // 挑選出員工編號小於 3 的員工
            Console.WriteLine("\n\n員工編號小於3的員工名單為：");
            SelectIdLowerThree(employees);
            #region 挑選出員編小於3的員工
            var group3 = employees.Where(e => e.Id < 3);
            foreach (var e in group3)
                Console.Write(e.Name + "\t");
            #endregion
        }

        static void SelectMale(List<Employee> employees)
        {
            foreach(Employee e in employees)
            {
                if (e.Sex.Equals("Male"))
                    Console.Write($"{e.Name} \t");
            }
            Console.WriteLine();
        }

        static void SelectHigherTwoMillion(List<Employee> employees)
        {
            foreach(Employee e in employees)
            {
                if (e.Income >= 2000000)
                    Console.Write($"{e.Name} \t");
            }
            Console.WriteLine();
        }

        static void SelectIdLowerThree(List<Employee> employees)
        {
            foreach(Employee e in employees)
            {
                if (e.Id < 3)
                    Console.Write($"{e.Name} \t");
            }
            Console.WriteLine();
        }
    }

    class Employee
    {        
        public int Id { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public int Income { get; set; }

        public Employee(int id,string name,string sex,int income)
        {
            Id = id;
            Name = name;
            Sex = sex;
            Income = income;
        }
    }
}
