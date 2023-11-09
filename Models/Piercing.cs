public class Piercing{
    public int IdPiercing {get; set;}
    public int Precio {get; set;}
    public string Material {get; set;}
    public string Color {get; set;}
    public string Foto {get; set;}
    public string Nombre {get; set;}
    public int Likes {get; set;}

    public Piercing(){}

    public Piercing(int idPiercing, int precio, string material, string color, string foto, string nombre, int likes){
        IdPiercing=idPiercing;
        Precio=precio;
        Material=material;
        Color=color;
        Foto=foto;
        Nombre = nombre;
        Likes = likes;
    }
}