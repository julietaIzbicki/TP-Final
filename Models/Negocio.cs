public class Negocio{
    public int IdNegocio;
    public string Nombre;
    public string Horarios;
    public string Direccion;
    public string Foto;
    public int Telefono;
    public string Mapa;
    

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