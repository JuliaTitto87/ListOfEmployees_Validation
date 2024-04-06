using System.ComponentModel.DataAnnotations;

namespace ListOfEmployees__DomainModel
{
	public class Employee
	{
		[Required]
		public required int Id { get; set; }

		[RegularExpression("0000000", ErrorMessage ="Поле должно состоять из 7 цифр")]
		public required int PersonnelNumber { get; set; }

		[Required (ErrorMessage ="Поле ФИО работника не может быть пустым")]
		public required string FullName { get; set; }

		[MaxLength  (100, ErrorMessage ="Максимальная  длина текста - 100 символов")  ]

		public string? Department { get; set; }

        [Required(ErrorMessage = "Поле Должность не может быть пустым")]
        public required string EmployeesPosition { get; set; }
	}
}
