using System;
using System.Collections.Generic;

namespace industry_titan{

    public class FoodIndustry : IFactory<FoodProcessor>
    {
        public int minEmployeeCount { get; set; }
        public int maxEmployeeCount { get; set; }
        public List<FoodProcessor> currentEmployees { get; set; } = new List<FoodProcessor>();
        public string factoryName { get; set; }

        public void HireEmployee(FoodProcessor Employee)
        {
            if(minEmployeeCount <= currentEmployees.Count && currentEmployees.Count <= maxEmployeeCount){
                currentEmployees.Add(Employee);
                Console.WriteLine($"{Employee.Name} has been added to {factoryName}.");
            }
            else{
                Console.WriteLine($"You've reached the max employee limit of {maxEmployeeCount} for {factoryName}");
            }
        }

        public void HireEmployees(List<FoodProcessor> EmployeesToAdd)
        {
            if(minEmployeeCount <= (currentEmployees.Count + EmployeesToAdd.Count) && (currentEmployees.Count + EmployeesToAdd.Count) <= maxEmployeeCount){
                currentEmployees.AddRange(EmployeesToAdd);
            }
            else{
                Console.WriteLine($"You've reached the max employee limit of {maxEmployeeCount} for {factoryName}. You currently have {currentEmployees.Count} employees.");
            }
        }

        public void ListEmployees()
        {
            Console.WriteLine("\nCurrent Employees:");
            currentEmployees.ForEach(employee => Console.WriteLine(employee.Name));
        }
    }
}