using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly ILogger<StudentController> _logger;
        private List<Student> _student;
        public StudentController(ILogger<StudentController> logger){
            _logger = logger;
            _student = new List<Student>{
                new Student{
                    BirthPlace = "Ha Noi",
                    Gender = "Male",
                    University = "Bach Khoa",
                    StudentName = "Pham Van Du"
                },
                new Student{
                    BirthPlace = "Thai Binh",
                    Gender = "FeMale",
                    University = "Kinh Te Quoc Dan",
                    StudentName = "Tran Dung Nhi"
                },
                new Student{
                    BirthPlace = "Ha Noi",
                    Gender = "FeMale",
                    University = "Kinh Cong",
                    StudentName = "Pham Quynh Anh"
                },
                new Student{
                    BirthPlace = "Nam Dinh",
                    Gender = "Male",
                    University = "Xay Dung",
                    StudentName = "Nguyen Van Nam"
                },
                new Student{
                    BirthPlace = "Ha Noi",
                    Gender = "FeMale",
                    University = "Nhan Van",
                    StudentName = "Pham Thi Hong Lieu"
                },
                new Student{
                    BirthPlace = "Ha Noi",
                    Gender = "Male",
                    University = "ApTech",
                    StudentName = "Pham Dinh Quan"
                },
                new Student{
                    BirthPlace = "Ha Noi",
                    Gender = "Male",
                    University = "Bach Khoa",
                    StudentName = "Do Tien Thanh"
                }
            };
        }
        [HttpGet]
        public IEnumerable<Student> Get(string? birthplace){
            if(string.IsNullOrEmpty(birthplace))
                return _student.Where(x=>x.BirthPlace=="Ha Noi").ToList();
            else
                return _student.Where(x=>x.BirthPlace == birthplace).ToList();
           
        }
        
    }
}