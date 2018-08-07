using AssetData;
using AssetData.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AssetManagementServices
{
  public class AssetService : IAssetManagement
  {
    private AssetManagementContext _context;

    public AssetService(AssetManagementContext context)
    {
      _context = context;
    }

    public void AddAsset(Asset newAsset)
    {
      _context.Add(newAsset);
      _context.SaveChanges();
    }

    public IEnumerable<Asset> GetAllAssets()
    {
      return _context.Assets
        //.Include(asset => asset.AssetStatuses)
        //.Include(asset => asset.Category)
        .Include(asset => asset.isDeleted);
        //.Include(asset => asset.Condition);
      //Might need to include departments on here
    }

    public Asset GetAssetById(int id)
    {

      return
        //_context.Assets
        //.Include(asset => asset.AssetStatuses)
        //.Include(asset => asset.Category)
        //.Include(asset => asset.isDeleted)
        //.Include(asset => asset.Condition)

        GetAllAssets()
        .FirstOrDefault(asset => asset.Id == id);
    }

    public IEnumerable<Department> GetAllDepartments()
    {
      return _context.Departments;
    }

    public Department GetDepartmentById(int id)
    {
      return GetAllDepartments()
        .FirstOrDefault(dep => dep.Id == id);
    }

    public void AddDepartment(Department newDepartment)
    {
      _context.Add(newDepartment);
      _context.SaveChanges();
    }

    public IEnumerable<Employee> GetAllEmployees()
    {
      return _context.Employees;
    }

    public Employee GetEmployeeByID(int id)
    {
      return GetAllEmployees()
        .FirstOrDefault(emp => emp.Id == id);
    }

    public void AddEmployee(Employee newEmployee)
    {
      _context.Add(newEmployee);
      _context.SaveChanges();
    }
  }
}
