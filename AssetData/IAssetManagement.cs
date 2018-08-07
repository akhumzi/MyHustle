using AssetData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AssetData
{
    public interface IAssetManagement
    {
    IEnumerable<Asset> GetAllAssets();
    Asset GetAssetById(int id);
    void AddAsset(Asset newAsset);

    IEnumerable<Department> GetAllDepartments();
    Department GetDepartmentById(int id);
    void AddDepartment(Department newDepartment);

    IEnumerable<Employee> GetAllEmployees();
    Employee GetEmployeeByID(int id);
    void AddEmployee(Employee newEmployee);
    }
}
