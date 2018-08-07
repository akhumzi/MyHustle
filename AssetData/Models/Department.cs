using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AssetData.Models
{
    public class Department
    {
    public int Id { get; set; }
    [Required]
    [StringLength(50, ErrorMessage = "Limit to 50 Characters")]
    public int DepartmentName { get; set; }
    [Required]
    [StringLength(50, ErrorMessage = "Limit to 50 Characters")]
    public int DepartmentLocation { get; set; } 

    public virtual IEnumerable<Asset> Assets { get; set; }
    public virtual IEnumerable<Employee> Employees { get; set; }
  }
}
