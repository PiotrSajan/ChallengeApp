
// Zadanie domowe dzien 6 


using ChallengeApp;

Employee employee1 = new Employee("Adam", "Małysz", 88);
Employee employee2 = new Employee("Joanna", "Wielka", 22);
Employee employee3 = new Employee("Krzysztof", "Jeż", 18);

employee1.AddScore(10);
employee1.AddScore(10);
employee1.AddScore(10);
employee1.AddScore(10);
employee1.AddScore(10);

employee2.AddScore(9);
employee2.AddScore(10);
employee2.AddScore(4);
employee2.AddScore(2);
employee2.AddScore(2);

employee3.AddScore(8);
employee3.AddScore(4);
employee3.AddScore(2);
employee3.AddScore(2);
employee3.AddScore(9);

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

int maxResult = -1;
Employee employeeWithMaxResults = null;

foreach (var employee in employees)
{
    if (employee.Result > maxResult)
    {

        employeeWithMaxResults = employee;
        maxResult = employee.Result;
    }
};

Console.WriteLine("Pracownik z największą ilościa punktów to:" + " " + employeeWithMaxResults.Name + " " + employeeWithMaxResults.Surname + " " + "lat:" + " " + employeeWithMaxResults.Age);
Console.WriteLine("Z wynikiem: " + employeeWithMaxResults.Result + " " + "punktów.");