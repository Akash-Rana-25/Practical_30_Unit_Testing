using Practical_30.Modal;

namespace Practical_30.Repositories {

    public interface IEmployeeRepositorie
    {
        IEnumerable<Employee> GetAll();
        Employee? GetById(int id);
        Employee Add(Employee newEmployee);
        void Remove(Employee employee);
    }

}
