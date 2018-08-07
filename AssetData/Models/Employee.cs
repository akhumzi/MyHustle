using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AssetData.Models
{
  public class Employee
  {
    [Required]
    public int Id { get; set; }
    [Required] 
    public string EmployeeName { get; set; }
    public string EmployeeSurname { get; set; }
    [Required] 
    public int EmployeeNumber { get; set; }
    public string EmployeeEmail { get; set; }
    [Required] 
    public string EmployeeContactNumber { get; set; }
    public string EmployeeAddress { get; set; }
    public string EmployeeNote { get; set; }

    public virtual Department Department { get; set; }
  }
}
