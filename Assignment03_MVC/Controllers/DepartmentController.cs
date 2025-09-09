using Assignment.BLL.Services;
using Microsoft.AspNetCore.Mvc;
namespace Assignment.PL.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentServices _departmentServices;
        public DepartmentController(IDepartmentServices departmentServices)
        {
            _departmentServices = departmentServices;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
