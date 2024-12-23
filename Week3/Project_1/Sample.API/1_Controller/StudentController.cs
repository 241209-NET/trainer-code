using Microsoft.AspNetCore.Mvc;
using Sample.API.Service;

namespace Sample.API.Controller;

[Route("api/[controller]")]
[ApiController]
public class StudentController : ControllerBase
{
    private readonly IStudentService _studentService;

    public StudentController(IStudentService studentService) => _studentService  = studentService;

    [HttpGet]
    public IActionResult ReturnHello()
    {
        return Ok("Hello");
    }

    [HttpGet("even/{number}")]
    public IActionResult ReturnHello(int number)
    {
        return Ok(_studentService.IsEven(number));
    }
}