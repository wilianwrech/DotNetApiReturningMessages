using Microsoft.AspNetCore.Mvc;
using ReturningMessages.BusinessLogic;
using ReturningMessages.Extensions;

namespace ReturningMessages.Controllers;

[ApiController]
[Route("[controller]")]
public class PeopleController : ControllerBase
{
    private readonly BlPeople _blPeople = new();

    [HttpGet("[action]/{id}")]
    public IActionResult GetPersonException([FromRoute] string id) =>
        Ok(_blPeople.GetPersonException(id));

    [HttpGet("[action]/{id}")]
    public IActionResult GetPersonLanguageExt([FromRoute] string id) =>
        _blPeople.GetPersonLanguageExt(id).ToActionResult(Ok);
}