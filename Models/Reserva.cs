public class Reserva{
    public int IdReserva {get; set;}
    public string Nombre {get; set;}
    public string Apellido {get; set;}
    public string Mail {get; set;}
    public int Edad {get; set;}
    public int IdPiercing {get; set;}
    public int IdNegocio {get; set;}
    public DateTime Fecha {get; set;}

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