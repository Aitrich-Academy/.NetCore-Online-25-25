using EmployeeManagementActivity.Model;
using EmployeeManagementActivity.Repository;


namespace EmployeeManagementActivity.Services
{
    public class EmployeeServices
    {
        private readonly EmployeeRepository repository;
        public EmployeeServices(EmployeeRepository _repository)

        {
           repository = _repository;
        }
        public async Task<IList<EmployeeMgt>> GetEmployeeAsync()
        {
            return await repository.GetEmployeeAsync();
        }
        public async Task AddNewEmployee(EmployeeMgt employee)
        {
            await repository.AddNewEmployee(employee);
        }
        public async Task<EmployeeMgt> GetEmployeebyIdAsync(int id)
        {
            return await repository.GetEmployeebyIdAsync(id);
        }
        public async Task UpdateEmployeeDetails(EmployeeMgt employee)
        {
            await repository.UpdateEmployeeDetails(employee);
        }
        public async Task deleteEmployee(EmployeeMgt employee)
        {
            await repository.deleteEmployee(employee);
        }
    }
}
