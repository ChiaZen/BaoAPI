using System.IO.Compression;
using BaoProject.Domain.Interface;

namespace BaoProject.Domain;

public class BaoService : IBaoService
{
    private readonly IBaoQuery _baoQuery;
    private readonly IBaoByIdQuery _baoByIdQuery;
    private readonly IBaoSearchQuery _baoSearchQuery;
    
    public BaoService(IBaoQuery baoQuery, IBaoByIdQuery baoByIdQuery, IBaoSearchQuery baoSearchQuery)
    {
        _baoQuery = baoQuery;
        _baoByIdQuery = baoByIdQuery;
        _baoSearchQuery = baoSearchQuery;
    }
    
    public IEnumerable<Bao> GetBao()
    {
        return _baoQuery.GetBao();
    }

    public Bao GetBaoById(int id)
    {
        return _baoByIdQuery.GetBao(id);
    }

    public IEnumerable<Bao> SearchBao(string query)
    {
        return _baoSearchQuery.SearchBao(query);
    }
}