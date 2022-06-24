using System.IO.Compression;
using BaoProject.Domain.Interface;

namespace BaoProject.Domain;

public class BaoService : IBaoService
{
    private readonly IBaoQuery _baoQuery;
    private readonly IBaoByIdQuery _baoByIdQuery;
    
    public BaoService(IBaoQuery baoQuery, IBaoByIdQuery baoByIdQuery)
    {
        _baoQuery = baoQuery;
        _baoByIdQuery = baoByIdQuery;
    }
    
    public IEnumerable<Bao> GetBao()
    {
        return _baoQuery.GetBao();
    }

    public Bao GetBaoById(int id)
    {
        return _baoByIdQuery.GetBao(id);
    }
}