namespace EmployeeActivity.Data
{
    public class EmployeeRepository
    {
        List<EmployeeDetails> employeeList = new List<EmployeeDetails>();
        public void AddEmployeeList(EmployeeDetails employee)
        {
            employee.Id = employeeList.Count + 1;
            employeeList.Add(employee);
        }

        public List<EmployeeDetails> GetEmployeeList()
        {
            return employeeList;
        }

        public EmployeeDetails GetEmployee(int id)
        {
            return employeeList.FirstOrDefault(e => e.Id == id);

        }

        public void UpdateEmployee(EmployeeDetails employee)
        {
            EmployeeDetails ExistEmployee = GetEmployee(employee.Id);
            if (ExistEmployee.Id !=null)
            {
                ExistEmployee.Id = employee.Id;
                ExistEmployee.FirstName=employee.FirstName;
                ExistEmployee.LastName=employee.LastName;
                ExistEmployee.Email=employee.Email;
                ExistEmployee.PhoneNo=employee.PhoneNo;
            }
        }

        public void DeleteEmployee(EmployeeDetails employee)
        {
            EmployeeDetails Existemployee=GetEmployee(employee.Id);
            if(Existemployee!=null)
                employeeList.Remove(Existemployee);
        }
    }
}
