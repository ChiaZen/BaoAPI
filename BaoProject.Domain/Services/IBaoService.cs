using BaoProject.Domain.Objects;

namespace BaoProject.Domain.Services;

public interface IBaoService
{
    Bao GetBaoById(int id);
    IEnumerable<Bao> GetBao();
    IEnumerable<Bao> SearchBao(string query);
}