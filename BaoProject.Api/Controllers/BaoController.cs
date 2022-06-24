using BaoProject.Domain;
using Microsoft.AspNetCore.Mvc;

namespace BaoProject.Controllers;

[ApiController]
[Route("[controller]")]
public class BaoController
{
    private readonly IBaoService _baoService;
    
    public BaoController(IBaoService baoService)
    {
        _baoService = baoService;
    }
    
    [HttpGet]
    public IEnumerable<BaoResponse> GetBao()
    {
        return _baoService.GetBao().Select(x => new BaoResponse()
        {
            Filling = x.Filling,
            IsGlutenFree = x.IsGlutenFree,
            IsVegan = x.IsVegan,
            Name = x.Name
        });
    }
    
    [HttpGet("{id}")]
    public BaoResponse GetBaoById([FromRoute] int id)
    {
        var bao = _baoService.GetBaoById(id);
        return new BaoResponse()
        {
            Name = bao.Name,
            Filling = bao.Filling,
            IsGlutenFree = bao.IsGlutenFree,
            IsVegan = bao.IsVegan
        };
    }
}