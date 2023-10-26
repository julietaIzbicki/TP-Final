using System.Data.SqlClient;
using Dapper;
public class BD{
    private static string _connectionString = @"Server=localhost; DataBase=TPFinal - Prog;Trusted_Connection=True;";
    
     public static List<Negocio> ListarNegocios(){
        string sql = "SELECT * FROM Negocio";
        using(SqlConnection db = new SqlConnection(_connectionString)){
            return db.Query<Negocio>(sql).ToList();
        }
    }

    public static List<Piercing> ListarPiercings(){
        string sql = "SELECT * FROM Piercing";
        using(SqlConnection db = new SqlConnection(_connectionString)){
            return db.Query<Piercing>(sql).ToList();
        }
    }

    public static List<Negocio> ListarNegocios(){
        string sql = "SELECT * FROM Negocio";
        using(SqlConnection db = new SqlConnection(_connectionString)){
            return db.Query<Negocio>(sql).ToList();
        }
    }

//devuelve un objeto solo 
     public static Piercing InfoPiercing(int id){
        Piercing pi = new Piercing();
        using(SqlConnection db = new SqlConnection(_connectionString)){
            string sql = "SELECT * FROM Piercing WHERE IdPiercing = @pid";
            pi = db.QueryFirstOrDefault<Piercing>(sql, new {pid= pi});
        }
        return pi;
    }

    public static Negocio InfoSede(int id){
        Negocio sede = new Negocio();
        using(SqlConnection db = new SqlConnection(_connectionString)){
            string sql = "SELECT * FROM Negocio WHERE IdNegocio = @pid";
            sede = db.QueryFirstOrDefault<Negocio>(sql, new {pid= sede});
        }
        return sede;
    }
//insert reserva en bd y return idreserva
    public static int GuardarReserva(Reserva R){
        string SQL = "INSERT INTO  Reservas (IdReserva, Nombre, Apellido, Mail, Edad, IdPiercing, IdNegocio, Fecha) VALUES (@pIdReserva, @pNombre, @pApellido, @pMail, @pEdad, @pIdPiercing, @pIdNegocio, @pFecha)";
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            db.Execute(SQL, new {pIdReserva=R.IdReserva, pNombre=R.Nombre, pApellido=R.Apellido, pMail=R.Mail, pEdad=R.Edad, pIdPiercing=R.IdPiercing, pIdNegocio=R.IdNegocio, pFecha=R.Fecha});
        }
        return R.IdReserva;
    }

//usamo storedprocedures :)
    public static void ElmiminarReserva(int Id){
        string SQL = "EXEC SP_EliminarReserva @Id";
        using(SqlConnection db = new SqlConnection(_connectionString)){
        db.Execute(SQL, new{Id});
        }
    }
}