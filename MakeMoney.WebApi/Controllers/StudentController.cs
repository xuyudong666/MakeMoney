using MakeMoney.Domain.Students;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MakeMoney.WebApi.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase {
        private readonly IStudentRepository _studentRepository;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public StudentController(IStudentRepository studentRepository) {
            _studentRepository = studentRepository;
        }
        [HttpGet]
        public ActionResult<Student?> GetAsync() {
            return _studentRepository.GetAsync();
        }
    }
}
