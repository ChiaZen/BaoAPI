using BaoProject.Domain;
using BaoProject.Domain.Objects;

namespace BaoProject.Responses;

public class BaoResponse
{
    public string Name { get; set; }
    public BaoFilling Filling { get; set; }
    public bool IsGlutenFree { get; set; }
    public bool IsVegan { get; set; }
}