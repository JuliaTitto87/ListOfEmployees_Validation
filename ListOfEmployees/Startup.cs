using ListOfEmployees__BLL.Contracts;
using ListOfEmployees__BLL.Services;
using ListOfEmployees__DomainModel;
using ListOfEmployees_DAL;
using Microsoft.EntityFrameworkCore;


namespace ListOfEmployees
{
	public static class Startup
	{
		internal static void AddServices(WebApplicationBuilder builder)
		{
			RegisterDAL(builder);
		}
		public static void RegisterDAL(WebApplicationBuilder builder)
		{
			builder.Services.AddTransient<DbContextOptions<EmployeesContext>>(provider =>
			{
				var builder = new DbContextOptionsBuilder<EmployeesContext>();
				builder.UseNpgsql("host=localhost;port=5432;database=ListOfEmployees;Username=ulia;Password=103125");
				return builder.Options;
			});
			builder.Services.AddScoped<DbContext, EmployeesContext>();

			if (builder.Environment.IsDevelopment() == true)

				builder.Services.AddScoped<IEmployeesService>(prov =>
				{
					var context = prov.GetRequiredService<DbContext>();
					return new EmployeeService(context);
				});
			else
				builder.Services.AddSingleton<IEmployeesService, StubEmployeeService>();

		}

	}
}
