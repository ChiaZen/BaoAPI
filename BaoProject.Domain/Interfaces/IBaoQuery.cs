using BaoProject.Domain.Objects;

namespace BaoProject.Domain.Interfaces;

public interface IBaoQuery
{
    IEnumerable<Bao> GetBao();
}