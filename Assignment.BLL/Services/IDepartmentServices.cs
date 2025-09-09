using Assignment.BLL.DataTransferObject;

namespace Assignment.BLL.Services
{
    public interface IDepartmentServices
    {
        DepartmentDetailsResponse? GetById(int id);

        IEnumerable<DepartmentDetailsResponse> GetAll();

        int update(DepartmentUpdateRequest request);
        int delete (int id);

        int add(DepartmentRequest request);
    }
}