namespace BaoProject.Domain;

public class BaoFillingService
{
    private readonly IBaoFillingQuery _baoFillingQuery;
    
    public BaoFillingService(IBaoFillingQuery baoFillingQuery)
    {
        _baoFillingQuery = baoFillingQuery;
    }
    
    public IEnumerable<BaoFilling> GetBaoFilling()
    {
        return _baoFillingQuery.GetBaoFilling();
    }
}
