using BaoProject.Domain.Objects;

namespace BaoProject.Requests;

public class BaoRequest
{
    public string Name { get; set; }
    public BaoFilling Filling { get; set; }
    public bool IsGlutenFree { get; set; }
    public bool IsVegan { get; set; }
}