using Assignment.BLL.DataTransferObject;
using Assignment.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.BLL.Services
{
    public class DepartmentServices : IDepartmentServices
    {
        private IDepartmentRepository _departmentRepository;
        public DepartmentServices(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        public int add(DepartmentRequest request)
        {
            throw new NotImplementedException();
        }

        public int delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DepartmentDetailsResponse> GetAll()
        {
            throw new NotImplementedException();
        }

        public DepartmentDetailsResponse? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int update(DepartmentUpdateRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
