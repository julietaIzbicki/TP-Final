public class Reserva{
    public int IdReserva; 
    public string Nombre;
    public string Apellido;
    public string Mail;
    public int Edad;
    public int IdPiercing;
    public int IdNegocio;
    public DateTime Fecha;

    public Reserva(){}

    public Reserva(int idReserva, string nombre, string apellido, string mail, int edad, int idPiercing, int idNegocio, DateTime fecha){
        IdReserva=idReserva;
        Nombre=nombre;
        Apellido=apellido;
        Mail=mail;
        Edad=edad;
        IdPiercing=idPiercing;
        IdNegocio=idNegocio;
        Fecha=fecha;
    }

    public Reserva(string nombre, string apellido, string mail, int edad, int idpiercing, int idnegocio, DateTime fecha){
        Nombre=nombre;
        Apellido=apellido;
        Mail=mail;
        Edad=edad;
        IdPiercing=idpiercing;
        IdNegocio=idnegocio;
        Fecha=fecha;
    }
}