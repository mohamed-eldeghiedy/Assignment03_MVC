using Assignment.DAL.Entities;

namespace Assignment.DAL.Repositories
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetAll(bool trackChanges = false);
        Department GetById(int id);
        int Add(Department department);
        int Update(Department department);
        int Delete(Department department);
    }
}