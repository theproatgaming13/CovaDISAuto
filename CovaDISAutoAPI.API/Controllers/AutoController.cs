using Microsoft.AspNetCore.Mvc;
using CovaDISAutoAPI.Application.Repositories;
using CovaDISAutoAPI.Domain.Entities;

[ApiController]
[Route("api/[controller]")]
public class AutoController : ControllerBase
{
    private readonly IAutoRepository _autoRepository;

    public AutoController(IAutoRepository autoRepository)
    {
        _autoRepository = autoRepository;
    }

    [HttpGet("{id}")]
    public ActionResult<Auto> GetAuto(int id)
    {
        var auto = _autoRepository.GetById(id);
        if (auto == null)
            return NotFound();

        return Ok(auto);
    }
}
