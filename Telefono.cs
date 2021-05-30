abstract class Telefono{
    //Datos miembro.
    protected int anio;
    protected string marca;
    //Método Pais con parámetros
    public Telefono(int anioTelefono, string MarcaTelefono){
        anio=anioTelefono;
        marca=MarcaTelefono;
    }
    //Método para mostrar país elegido
    public void mostrarAnioElegido(){
        if(anio>=2009){
            System.Console.WriteLine("Año del teléfono: "+ anio + " (Válido)");
        }else if(anio<2009){
            System.Console.WriteLine("Año del teléfono: "+ anio + " (Inválido)");
        }
    }
    public abstract string anioValido();
    public abstract string marcaValidacion();
    //Interfaz para el pais
    public int DatoAnio{
        get{
            return anio;
        }set{
            anio = value;
        }
    }
    public string DatoMarca{
        get
        {
            return marca;
        }
        set
        {
            marca = value;
        }
    }
    //Destructor
    ~Telefono() {
        anio=0; 
        marca="";
        // Console.Write("Este es el destructor ejecutándose para destruir el objeto de la clase Factura");
    } 
}