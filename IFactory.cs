using System;
using System.Collections.Generic;

namespace industry_titan{

    public interface IFactory<T>{

        public string factoryName {get; set;}
        public int minEmployeeCount {get; set;}

        public int maxEmployeeCount {get; set;}

        public List<T> currentEmployees {get; set;}

        public void ListEmployees();
        
        public void HireEmployee(T Employee);

        public void HireEmployees(List<T> EmployeesToAdd);

    }

}