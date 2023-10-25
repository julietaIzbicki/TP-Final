public class Personal{
    public int IdPersonal; 
    public int IdNegocio;
    public string Nombre;
    public int Edad;
    public int Telefono;
    public string Genero;

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