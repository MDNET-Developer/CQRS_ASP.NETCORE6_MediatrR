using CQRS_ASP.NETCore6.CQRS.Commads;
using CQRS_ASP.NETCore6.CQRS.Handlers;
using CQRS_ASP.NETCore6.CQRS.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CQRS_ASP.NETCore6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        //private readonly GetStudentByIdQueryHandler _handler;
        //private readonly GetAllStudentsQueryHandler _handlerAllStudents;
        //private readonly CreateStudendCommandHandler _createStudent;
        //private readonly UpdateStudentCommandHandler _updateStudent;
        //private readonly DeleteStudentCommandHandler _deleteStudent;
        //public StudentsController(GetStudentByIdQueryHandler handler, GetAllStudentsQueryHandler handlerAllStudents, CreateStudendCommandHandler createStudent, UpdateStudentCommandHandler updateStudent, DeleteStudentCommandHandler deleteStudent)
        //{
        //    _handler = handler;
        //    _handlerAllStudents = handlerAllStudents;
        //    _createStudent = createStudent;
        //    _updateStudent = updateStudent;
        //    _deleteStudent = deleteStudent;
        //}

        private readonly IMediator _mediator;

        public StudentsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetStudentById(int id)
        {

            var data = await _mediator.Send(new GetStudentByIdQuery(id));
            return Ok(data);
        }
        //[HttpPost]
        //public async Task<IActionResult> CreateStudent(CreateStudentCommand command)
        //{

        //    await _createStudent.HandlerAsync(command);
        //    return Ok();
        //}
        [HttpGet]
        public async Task<IActionResult> GetAllStudent()
        {

            var data = await _mediator.Send(new GetAllStudentsQuery());
            return Ok(data);
        }


        //[HttpPut]
        //public async Task<IActionResult> UpdateStudent(UpdateStudentCommand command)
        //{

        //    await _updateStudent.HandlerAsync(command);
        //    return Ok();
        //}

        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteStudent(int id)
        //{

        //    await _deleteStudent.HandlerAsync(new DeleteStudentCommand(id));
        //    return Ok();
        //}
    }
}
