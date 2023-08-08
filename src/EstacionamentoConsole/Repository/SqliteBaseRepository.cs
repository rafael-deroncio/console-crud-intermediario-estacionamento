using Dapper;
using Estacionamento.Extensions;
using Estacionamento.Models;
using Estacionamento.Repository.Interfaces;
using System.Data;
using System.Data.SQLite;

namespace Estacionamento.Repository;

public class SqLiteBaseRepository
{
    private static SQLiteConnection _sqliteConnection;
    private const string DATABASE_NAME = "EstacionamentoDatabase.db";

    public SqLiteBaseRepository()
    {

    }

    public static IDbConnection GetConnection() // CONNECTION
    {
        _sqliteConnection = new SQLiteConnection(GetConnectionString());
        _sqliteConnection.Open();
        return _sqliteConnection;
    }

    public static string GetConnectionString()
    {
        string path = Environment.CurrentDirectory
            .Replace("bin", string.Empty)
            .Replace("Debug", string.Empty)
            .Replace("net7.0", string.Empty)
            .Replace("\\\\\\", string.Empty);

        return "Data Source=" + Path.Combine(path, DATABASE_NAME);
    }
}