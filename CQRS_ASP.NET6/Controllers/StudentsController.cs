using CQRS_ASP.NETCore6.CQRS.Handlers;
using CQRS_ASP.NETCore6.CQRS.Queries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CQRS_ASP.NETCore6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly GetStudentByIdQueryHandler _handler;
        private readonly GetAllStudentsQueryHandler _handlerAllStudents;

        public StudentsController(GetStudentByIdQueryHandler handler, GetAllStudentsQueryHandler handlerAllStudents)
        {
            _handler = handler;
            _handlerAllStudents = handlerAllStudents;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetStudentById(int id)
        {
           
            var data = await _handler.HandlerAsync(new GetStudentByIdQuery(id));
            return Ok(data);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllStudent()
        {

            var data = await _handlerAllStudents.HandlerAsync(new GetAllStudentsQuery());
            return Ok(data);
        }
    }
}
