using BaoProject.Domain.Objects;

namespace BaoProject.Domain.Interfaces;

public interface IBaoCreateCommand
{
    void CreateBao(Bao bao);
}