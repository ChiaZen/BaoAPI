using BaoProject.Domain.Objects;

namespace BaoProject.Domain.Interfaces;

public interface IBaoSearchQuery
{ 
    IEnumerable<Bao> SearchBao(string query);
}