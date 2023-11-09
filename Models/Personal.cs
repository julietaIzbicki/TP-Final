public class Personal{
    public int IdPersonal {get; set;}
    public int IdNegocio {get; set;}
    public string Nombre {get; set;}
    public int Edad {get; set;}
    public int Telefono {get; set;}
    public string Genero {get; set;}

    public Personal(){}

    public Personal(int idPersonal, int idNegocio, string nombre, int edad, int telefono, string genero){
        IdPersonal=idPersonal;
        IdNegocio=idNegocio;
        Nombre=nombre;
        Edad=edad;
        Telefono=telefono;
        Genero=genero;
    }
}