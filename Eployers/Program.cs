namespace Eployers
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Emplyee> employees = new List<Emplyee>();
            for (int i = 0; i < n; i++)
            {
                Emplyee emplyee = new Emplyee();
                emplyee.Name = Console.ReadLine();
                emplyee.Salary = double.Parse(Console.ReadLine());
                emplyee.Ocupation = Console.ReadLine();
                emplyee.Department = Console.ReadLine();
                employees.Add(emplyee);
            }
            for (int i = 0; i < employees.Count - 1; i++)
            {
                for (int j = 0; j < employees.Count - i - 1; j++)
                {
                    int cmpVal = employees[j].Department.CompareTo(employees[j + 1].Department);
                    if (cmpVal > 0)
                    {
                        string tempVar = employees[j].Department;
                        employees[j].Department = employees[j + 1].Department;
                        employees[j + 1].Department = tempVar;
                    }
                }
            }
            double HighestAverage = 0;
            int sameDepartmentBr = 0;
            double CurrentHighestAverage = 0;
            int index = 0;
            List<Emplyee> RichestDepartment = new List<Emplyee>();
            for (int j = 0; j < employees.Count - 1; j++)
            {
                int cmpVal = employees[j].Department.CompareTo(employees[j + 1].Department);
                if (cmpVal == 0)
                {
                    HighestAverage += employees[j].Salary;
                    sameDepartmentBr++;
                    RichestDepartment.Add(employees[j]);
                }
                else
                {
                    HighestAverage /= sameDepartmentBr;
                    if (CurrentHighestAverage < HighestAverage)
                    {
                        index = j;
                        CurrentHighestAverage = HighestAverage;

                    }
                    else
                    {
                        RichestDepartment.Clear();
                    }
                }
            }
            Console.WriteLine($"Hightest Average Salary : {employees[index].Department}");
            for (int i = 0; i < RichestDepartment.Count; i++)
            {
                for (int j = 0; j < RichestDepartment.Count - i - 1; j++)
                {
                    if (RichestDepartment[j].Salary > RichestDepartment[j+1].Salary)
                    {
                        var tempVar = RichestDepartment[j].Salary;
                        RichestDepartment[j].Salary = RichestDepartment[j+1].Salary;
                        RichestDepartment[j+1].Salary = tempVar;
                    }
                }
            }
            RichestDepartment[0].Print();
            RichestDepartment[RichestDepartment.Count-1].Print();
        }
    }
}
