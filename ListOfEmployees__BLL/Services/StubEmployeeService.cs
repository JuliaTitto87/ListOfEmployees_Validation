using ListOfEmployees__BLL.Contracts;
using ListOfEmployees__DomainModel;

namespace ListOfEmployees__BLL.Services
{
	public class StubEmployeeService : IEmployeesService
	{
		List<Employee> employees = new List<Employee>();
		public void AddEmployee(Employee employee)
		{
			employees.Add(employee);
		}

		public void DeleteEmployee(Employee employee)
		{
			employees.Remove(employees.FirstOrDefault(x => x.PersonnelNumber == employee.PersonnelNumber));
		}

		public void UpdateEmployee(Employee employee)
		{
			employees[employees.IndexOf(employees.FirstOrDefault(x => x.PersonnelNumber == employee.PersonnelNumber))] = employee;
		}

		List<Employee> IEmployeesService.GetEmployees()
		{
			return employees;
		}
	}
}
