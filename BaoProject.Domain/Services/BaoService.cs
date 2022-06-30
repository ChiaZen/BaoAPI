using BaoProject.Domain.Interfaces;
using BaoProject.Domain.Objects;

namespace BaoProject.Domain.Services;

public class BaoService : IBaoService
{
    private readonly IBaoQuery _baoQuery;
    private readonly IBaoByIdQuery _baoByIdQuery;
    private readonly IBaoSearchQuery _baoSearchQuery;
    private readonly IBaoCreateCommand _baoCreateCommand;
    
    public BaoService(
        IBaoQuery baoQuery, 
        IBaoByIdQuery baoByIdQuery, 
        IBaoSearchQuery baoSearchQuery, 
        IBaoCreateCommand baoCreateCommand)
    {
        _baoQuery = baoQuery;
        _baoByIdQuery = baoByIdQuery;
        _baoSearchQuery = baoSearchQuery;
        _baoCreateCommand = baoCreateCommand;
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

    public void CreateBao(Bao bao)
    {
        _baoCreateCommand.CreateBao(bao);
    }
}
