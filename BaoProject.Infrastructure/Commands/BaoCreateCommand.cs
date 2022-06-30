using BaoProject.Domain.Interfaces;
using BaoProject.Domain.Objects;
using Dapper;
using Microsoft.Data.SqlClient;

namespace BaoProject.Infrastructure.Commands;

public class BaoCreateCommand : IBaoCreateCommand
{
    public void CreateBao(Bao bao)
    {
        using var connection = new SqlConnection(@"Data Source=LAPTOP-KV67E26Q\LOCALDB;Database=Bao; uid=Baoapi;pwd=abc;Trusted_Connection=True;Encrypt=False;");
        connection.Query(Sql,new
        {
            BaoFillingID = (int)bao.Filling,
            Name = bao.Name,
            IsGlutenFree = bao.IsGlutenFree,
            IsVegan = bao.IsVegan
        });
    }
    
    private const string Sql = @"
        INSERT INTO Bao (
            BaoFillingId,
            Name,
            IsGlutenFree,
            IsVegan
        ) 
        VALUES (
            @BaoFillingId,
            @Name,
            @IsGlutenFree,
            @IsVegan
        )
    ";
}