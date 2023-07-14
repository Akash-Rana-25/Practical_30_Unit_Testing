using Practical_30.Modal;

namespace Practical_30.Repositories {

    public class EmployeeRepositories : IEmployeeRepositorie
    {
        public static List<Employee> employees = new List<Employee>()
        {
            new Employee{Id = 1, Name = "Akash Rana", Email = "akash@gmail.com", Address = "Bandhani"},
            new Employee{Id = 2, Name = "Karan Raj", Email = "karan@gmail.com", Address = "Vadodra"},
            new Employee{Id = 3, Name = "Jainam Bhavsar", Email = "Jainam@gmail.com", Address = "Nadiad"},
            new Employee{Id = 4, Name = "Khush Makadiya", Email = "Khush@gmail.com", Address = "Rajkot"},
            new Employee{Id = 5, Name = "Jimit Patel", Email = "Jimit@gmail.com", Address = "Anand"},
        };
        public Employee Add(Employee newEmployee)
        {
            employees.Add(newEmployee);
            return newEmployee;
        }

        public IEnumerable<Employee> GetAll()
        {
            return employees;
        }

        public Employee? GetById(int id)
        {
            return employees.FirstOrDefault(x => x.Id == id);
        }

        public void Remove(Employee employee)
        {
            employees.Remove(employee);
        }
    }

}
