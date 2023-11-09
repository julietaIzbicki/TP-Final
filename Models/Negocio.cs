public class Negocio{
    public int IdNegocio {get; set;}
    public string Nombre {get; set;}
    public string Horarios {get; set;}
    public string Direccion {get; set;}
    public string Foto {get; set;}
    public int Telefono {get; set;}
    public string Mapa {get; set;}
    

    public Negocio(){}

    public Negocio(int idNegocio, string nombre, string horarios, string direccion, string foto, int telefono, string mapa){
        IdNegocio=idNegocio;
        Nombre=nombre;
        Horarios=horarios;
        Direccion=direccion;
        Foto=foto;
        Telefono=telefono;
        Mapa=mapa;
    }
}