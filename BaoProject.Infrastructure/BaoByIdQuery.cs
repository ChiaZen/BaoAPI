using BaoProject.Domain;
using BaoProject.Domain.Interface;
using Dapper;
using Microsoft.Data.SqlClient;

namespace BaoProject.Infrastructure;

public class BaoByIdQuery : IBaoByIdQuery
{
    public Bao GetBao(int id)
    {
        using var connection = new SqlConnection(@"Data Source=LAPTOP-KV67E26Q\LOCALDB;Database=Bao; uid=Baoapi;pwd=abc;Trusted_Connection=True;Encrypt=False;");
        return connection.QuerySingle<Bao>("SELECT * FROM Bao WHERE Id = @baoId",new { baoId = id });
    }
}