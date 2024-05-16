var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<EmployeeRepo>();
// TODO 10: Add the FileDownloadService to the services
// TODO 13: Add the StringService to the services

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// test
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// API definitions

app.MapGet("/employees", (EmployeeRepo repo) => repo.GetEmployees()).Produces<List<Employee>>()
    .WithName("Get All Employees").WithTags("Employee").WithOpenApi();

app.MapPost("/employees/add", (Employee e, EmployeeRepo repo) => repo.AddEmployee(e)).Produces<Employee>()
    .WithName("Add Employee").WithTags("Employee").WithOpenApi();

// TODO 06: API to get an employee by id

// TODO 07: API to change the salary of an employee

// TODO 08: API to get employees by department and salary

// TODO Bonus02: add multiple employees to the list (plus tests in CSharpTest.http)

// TODO 11: API to download a file

// TODO 12: add tests to CSharpTest.http

// TODO 16: API to test Reverse method (at least 3 tests)

app.Run();

