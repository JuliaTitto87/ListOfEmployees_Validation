using ListOfEmployees__DomainModel;

namespace ListOfEmployees__BLL.Contracts
{
	public interface IEmployeesService
	{
		List<Employee> GetEmployees();
		void DeleteEmployee(Employee employee);
		void AddEmployee(Employee employee);

		void UpdateEmployee(Employee employee);
	}
}
