using EmployeeManagementActivity.Model;
using LibGit2Sharp;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace EmployeeManagementActivity.Repository
{
    public class EmployeeRepository
    {
        private readonly ApplicationDBContext _dbContext;
        public EmployeeMgt EmployeeMgt { get; set; }
        public EmployeeRepository(ApplicationDBContext dbContext)

        {
            _dbContext = dbContext;
        }
        public async Task<IList<EmployeeMgt>> GetEmployeeAsync()
        {
          
            return await _dbContext.NewEmployees.ToListAsync();
        }
        public async Task AddNewEmployee(EmployeeMgt employee)
        {
             _dbContext.NewEmployees.Add(employee);
            await _dbContext.SaveChangesAsync();
        }
        public async Task<EmployeeMgt> GetEmployeebyIdAsync(int id)
        {
            return await _dbContext.NewEmployees.FindAsync(id);
        }
        public async Task UpdateEmployeeDetails(EmployeeMgt employee)
        {
            _dbContext.NewEmployees.Update(employee);
            await _dbContext.SaveChangesAsync();
        }
        public async Task deleteEmployee(EmployeeMgt employee)
        {
            _dbContext.NewEmployees.Remove(employee);
            await _dbContext.SaveChangesAsync();
        }
    }
}
