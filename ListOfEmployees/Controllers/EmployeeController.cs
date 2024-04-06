using ListOfEmployees__BLL.Contracts;
using ListOfEmployees__DomainModel;
using Microsoft.AspNetCore.Mvc;

namespace ListOfEmployees.Controllers
{
	public class EmployeeController : Controller
	{
		public EmployeeController(IEmployeesService employeeService)
		{
			_employeeService = employeeService;
		}

		IEmployeesService _employeeService;

		// GET: EmployeeController
		public ActionResult Index()
		{
			return View(_employeeService);
		}

		// GET: EmployeeController/Details/5
		public ActionResult Details(int id)
		{
			return View();
		}

		// GET: EmployeeController/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: EmployeeController/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(Employee employee)
		{
			if(ModelState.IsValid)
			{ 
				_employeeService.AddEmployee(employee);
				return RedirectToAction(nameof(Index));
			}
				return View();

		}

		// GET: EmployeeController/Edit/5
		public ActionResult Edit(int id)
		{
			Employee employee = _employeeService.GetEmployees().FirstOrDefault(x => x.Id == id);
			return View(employee);

		}

		// POST: EmployeeController/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(Employee employee)
		{
			try
			{
				_employeeService.UpdateEmployee(employee);
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}

		// GET: EmployeeController/Delete/5
		public ActionResult Delete(int id)
		{
			Employee employee = _employeeService.GetEmployees().FirstOrDefault(x => x.Id == id);
			return View(employee);
		}

		// POST: EmployeeController/Delete/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Delete(Employee employee)
		{
			try
			{
				_employeeService.DeleteEmployee(employee);
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}
	}
}
