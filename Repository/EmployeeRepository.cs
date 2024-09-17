using Dapper;
using DotNetCoreMVC_TaxCalculation.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace DotNetCoreMVC_TaxCalculation.Repository
{
    public class EmployeeRepository
    {
        
            private readonly string _connectionString;

            public EmployeeRepository(string connectionString)
            {
                _connectionString = connectionString;
            }

            public IEnumerable<Employee> GetEmployeesWithTax()
            {
                using (IDbConnection db = new SqlConnection(_connectionString))
                {
                    return db.Query<Employee>("SP_CalculateTax_WithoutCursor", commandType: CommandType.StoredProcedure);
                }
            }
            public void AddEmployee(Employee employee)
            {
                using (IDbConnection db = new SqlConnection(_connectionString))
                {
                    // Insert the employee data into the Employees2510 table
                    db.Execute("INSERT INTO Employees ( Name, Designation, Salary) VALUES ( @Name, @Designation, @Salary)", employee);
                }
            }

            public void UpdateEmployee(Employee employee)
            {
                using (IDbConnection db = new SqlConnection(_connectionString))
                {
                    // Update the employee data and calculate new tax
                    db.Execute("UPDATE Employees SET Name = @Name, Designation = @Designation, Salary = @Salary WHERE EmpCode = @EmpCode", employee);
                }
            }
        }
    }

