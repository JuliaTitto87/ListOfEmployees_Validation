using ListOfEmployees__BLL.Contracts;
using ListOfEmployees__DomainModel;
using Microsoft.EntityFrameworkCore;
using ListOfEmployees_DAL;

namespace ListOfEmployees__BLL.Services
{
	public class EmployeeService : IEmployeesService
	{

		private readonly DbContext _context;
		List<Employee> employees = new List<Employee>();

		public EmployeeService(DbContext context)
		{
			_context = context;
		}

		List<Employee> IEmployeesService.GetEmployees()
		{
			employees = ((EmployeesContext)_context).Employees.ToList();
			return employees;
		}

		public void DeleteEmployee(Employee employee)
		{
			((EmployeesContext)_context).Employees.Remove(employee);
			_context.SaveChanges();
		}

		public void AddEmployee(Employee employee)
		{
			((EmployeesContext)_context).Employees.Add(employee);
			_context.SaveChanges();
		}
		public void UpdateEmployee(Employee employee)
		{
			((EmployeesContext)_context).Employees.Update(employee);
			_context.SaveChanges();
		}
	}
}
