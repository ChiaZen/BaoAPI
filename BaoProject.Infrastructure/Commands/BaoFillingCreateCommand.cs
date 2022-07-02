using BaoProject.Domain.Interfaces;
using BaoProject.Domain.Objects;
using Dapper;
using Microsoft.Data.SqlClient;

namespace BaoProject.Infrastructure.Commands;

public class BaoFillingCreateCommand : IBaoFillingCreateCommand
{
    public void CreateBaoFilling(string name)
    {
        using var connection = new SqlConnection(@"Data Source=LAPTOP-KV67E26Q\LOCALDB;Database=Bao; uid=Baoapi;pwd=abc;Trusted_Connection=True;Encrypt=False;");
        connection.Query(Sql,new
        {
            Name = name
        });
    }
    
    private const string Sql = @"
      INSERT INTO BaoFilling ([Name]) VALUES (@Name)
    ";
}