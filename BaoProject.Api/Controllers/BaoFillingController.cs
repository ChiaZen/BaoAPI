using Microsoft.AspNetCore.Mvc;

namespace BaoProject.Controllers;

[ApiController]
[Route("[controller]")]
public class BaoFillingController
{
    private readonly IBaoFilling _baoFillingService;

    public BaoController(IBaoFillingService baoFillingService)
    {
        _baoFillingService = baoFillingService;
    }
    
    [HttpGet]
    public IEnumerable<BaoFillingResponse> GetBaoFilling()
    {
        return _baoFillingService.GetBaoFilling().Select(x => new BaoFillingResponse()
        {
            Name = x.Name,
            Id = x.Id
        });
    }
}