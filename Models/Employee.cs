using System.ComponentModel.DataAnnotations;

namespace DotNetCoreMVC_TaxCalculation.Models
{
    public class Employee
    {
        [Key]
        public int EmpCode { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public decimal Salary { get; set; }
        public decimal Tax { get; set; }
 

}
}
