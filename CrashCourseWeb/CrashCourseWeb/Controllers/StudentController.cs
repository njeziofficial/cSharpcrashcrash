using CrashCourseWeb.CQRS.Commands;
using CrashCourseWeb.Data;
using CrashCourseWeb.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CrashCourseWeb.Controllers;

[Route("api/v1")]
[ApiController]
public class StudentController : ControllerBase
{
    readonly IMediator _mediator;

    public StudentController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> CreateStudent([FromBody] CreateStudentCommand command)
    {
        var response = await _mediator.Send(command);
        return Ok(response);
    }
}
