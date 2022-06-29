namespace BaoProject.Domain.Interface;

public interface IBaoSearchQuery
{ 
    IEnumerable<Bao> SearchBao(string query);
}