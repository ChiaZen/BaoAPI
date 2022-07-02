using BaoProject.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BaoProject.Controllers;

[ApiController]
[Route("[controller]")]
public class BaoFillingController
{
    private readonly IBaoFillingService _baoFillingService;

    public BaoFillingController(IBaoFillingService baoFillingService)
    {
        _baoFillingService = baoFillingService;
    }

    [HttpPost]
    public IActionResult CreateBao([FromBody] string name)
    {
        _baoFillingService.CreateBaoFilling(name);
        
        return new NoContentResult();
    }

} 