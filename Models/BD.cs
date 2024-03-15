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

       public static List<Piercing> ListarDeAcero(){
        string sql = "SELECT * FROM Piercing WHERE Material='Acero'";
        using(SqlConnection db = new SqlConnection(_connectionString)){
            return db.Query<Piercing>(sql).ToList();
        }
    }
    
    public static List<Piercing> ListarDeTitanio(){
        string sql = "SELECT * FROM Piercing WHERE Material='Titanio'";
        using(SqlConnection db = new SqlConnection(_connectionString)){
            return db.Query<Piercing>(sql).ToList();
        }
    }

    public static void AgregarLikes(int id){
        string sql = "UPDATE Piercing SET Likes = Likes + 1 WHERE IdPiercing = @pid";
        using(SqlConnection db = new SqlConnection(_connectionString)){
            db.QueryFirstOrDefault<Piercing>(sql, new {pid= id});
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
            sede = db.QueryFirstOrDefault<Negocio>(sql, new {pid= id});
        }
        return sede;
    }
//insert reserva en bd y return idreserva
    public static Reserva GuardarReserva(Reserva R){
     
        string SQL = "INSERT INTO  Reservas (Nombre, Apellido, Mail, Edad, IdPiercing, IdNegocio, Fecha) VALUES (@pNombre, @pApellido, @pMail, @pEdad, @pIdPiercing, @pIdNegocio, @pFecha)";
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            db.Execute(SQL, new {pNombre=R.Nombre, pApellido=R.Apellido, pMail=R.Mail, pEdad=R.Edad, pIdPiercing=R.IdPiercing, pIdNegocio=R.IdNegocio, pFecha=R.Fecha});
        }

        return R;
    }

//usamo storedprocedures :)
    public static void ElmiminarReserva(string mail) {
        string SQL = "EXEC SP_EliminarReserva @mail";
        using (SqlConnection db = new SqlConnection(_connectionString)) 
        {
            db.Execute(SQL, new { mail });
        }
    }

    public static List<Personal> ListarPersonal(int id){
        string sql = "SELECT * FROM Personal WHERE IdNegocio = @pid";
        using(SqlConnection db = new SqlConnection(_connectionString)){
            return db.Query<Personal>(sql, new {pid= id}).ToList();
        }
    }

    public static List<Reserva> TraerReserva(string mail){
        string sql = "SELECT * FROM Reservas WHERE Mail = @Pmail";
        using(SqlConnection db = new SqlConnection(_connectionString)){
            return db.Query<Reserva>(sql, new {Pmail= mail}).ToList();
        }
    }

}