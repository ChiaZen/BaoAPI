namespace BaoProject.Domain;

public class Bao
{
    public string Name { get; set; }
    public BaoFilling Filling { get; set; }
    public bool IsGlutenFree { get; set; }
    public bool IsVegan { get; set; }
}