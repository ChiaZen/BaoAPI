namespace BaoProject.Domain;

public interface IBaoService
{
    Bao GetBaoById(int id);
    IEnumerable<Bao> GetBao();
    IEnumerable<Bao> SearchBao(string query);
}