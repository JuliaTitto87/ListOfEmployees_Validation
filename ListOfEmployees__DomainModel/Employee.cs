namespace ListOfEmployees__DomainModel
{
	public class Employee
	{
		public int Id { get; set; }

		public int PersonnelNumber { get; set; }

		public required string FullName { get; set; }

		public required string Department { get; set; }

		public required string EmployeesPosition { get; set; }
	}
}
