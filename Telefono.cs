abstract class Telefono{
    //Datos miembro.
    protected int anio;
    protected string marca;
    //Método Pais con parámetros
    public Telefono(int anioTelefono){
        anio=anioTelefono;
    }
    //Método para mostrar país elegido
    public void mostrarAnioElegido(){
        if(anio>=2009){
            System.Console.WriteLine("Año elegido: "+ anio + " (Válido)");
        }else if(anio<2009){
            System.Console.WriteLine("Año elegido: "+ anio + " (Inválido)");
        }
    }
    public abstract string anioValido();
    public abstract string marcaValida();
    public abstract string marcaInvalida();
    //Interfaz para el pais
    public int DatoAnio{
        get{
            return anio;
        }set{
            anio = value;
        }
    }
    //Destructor
    ~Telefono() {
        anio=0; 
        // Console.Write("Este es el destructor ejecutándose para destruir el objeto de la clase Factura");
    } 
}