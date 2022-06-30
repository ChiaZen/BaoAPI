using BaoProject.Domain.Objects;

namespace BaoProject.Domain.Interfaces;

public interface IBaoByIdQuery
{
    Bao GetBao(int id);
}