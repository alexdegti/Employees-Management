using Gilsar.Models;

namespace Gilsar.Services;

public class EmployeeServices{

    private List<Employee> employeesList = System.Text.Json.JsonSerializer.Deserialize<List<Employee>>(File.ReadAllText("database.json"));

    //A method that returns the employeesList property.
    public List<Employee> GetEmployees() => employeesList;

    //A method that adds an Employee object to the employeesList
    //property.
    public void AddEmployee(Employee employee) => employeesList.Add(employee);

    //A method that deletes an Employee object from the employeesList property.
    public void DeleteEmployee(Employee employe) => employeesList.Remove(employe);

}