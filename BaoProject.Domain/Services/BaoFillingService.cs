using BaoProject.Domain.Interfaces;

namespace BaoProject.Domain.Services;

public class BaoFillingService : IBaoFillingService
{
    private readonly IBaoFillingCreateCommand _baoFillingCreateCommand;

    public BaoFillingService(IBaoFillingCreateCommand baoFillingCreateCommand)
    {
        _baoFillingCreateCommand = baoFillingCreateCommand;   
    }

    public void CreateBaoFilling(string name)
    {
        _baoFillingCreateCommand.CreateBaoFilling(name);
    }


}