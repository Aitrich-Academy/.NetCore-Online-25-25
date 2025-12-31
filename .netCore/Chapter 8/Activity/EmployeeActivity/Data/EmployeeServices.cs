namespace EmployeeActivity.Data
{
    public class EmployeeServices
    {
        EmployeeRepository _repository;
        public EmployeeServices(EmployeeRepository repository)
        {
            _repository = repository;
        }
        public void AddEmployeeList(EmployeeDetails employee)
        {
            _repository.AddEmployeeList(employee);
        }

        public List<EmployeeDetails> GetEmployeeList()
        {
            return _repository.GetEmployeeList();
        }

        public EmployeeDetails GetEmployee(int id)
        {
            return _repository.GetEmployee(id);
        }

        public void UpdateEmployee(EmployeeDetails employee)
        {
            _repository.UpdateEmployee(employee);
        }

        public void DeleteEmployee(EmployeeDetails employee)
        {
            _repository.DeleteEmployee(employee);
        }
    }
}
