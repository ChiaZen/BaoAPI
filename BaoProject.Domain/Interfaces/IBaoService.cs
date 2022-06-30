using BaoProject.Domain.Objects;

namespace BaoProject.Domain.Interfaces;

public interface IBaoService
{
    Bao GetBaoById(int id);
    IEnumerable<Bao> GetBao();
    IEnumerable<Bao> SearchBao(string query);
    void CreateBao(Bao bao);
}