using BaoProject.Domain;
using BaoProject.Domain.Interfaces;
using BaoProject.Domain.Objects;
using Dapper;
using Microsoft.Data.SqlClient;


namespace BaoProject.Infrastructure.Queries;

public class BaoQuery : IBaoQuery
{
    public IEnumerable<Bao> GetBao()
    {
        using (var connection = new SqlConnection(@"Data Source=LAPTOP-KV67E26Q\LOCALDB;Database=Bao; uid=Baoapi;pwd=abc;Trusted_Connection=True;Encrypt=False;"))
        {
            return connection.Query<Bao>("SELECT * FROM Bao");
        }
    }
}