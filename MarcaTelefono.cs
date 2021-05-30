using System;
using System.IO; 
class MarcaTelefono:Telefono{
    public string mensajeAnio = "Como el año es correcto y válido, ahora validaremos la marca del teléfono.";
    public string mensajeAnioNoValido="El año es inválido. Tu teléfono no es candidato para recibir la actualización.";
    public string mensajeMarcaInvalida="\nEs una marca inválida. Por lo tanto tu teléfono no es candidato para recibir la actualización";
    public string mensajeMarcaValida="\nEs una marca válida. Por lo tanto tu teléfono es candidato para recibir la actualización";
    public string iphone = "iphone"; public string iPhone = "iphone";

    //Marcas Chinas
    public string Huawei = "Huawei"; public string huawei = "huawei"; public string Xiaomi = "Xiaomi"; public string xiaomi = "xiaomi";
    public string Meizu = "Meizu"; public string meizu = "meizu"; public string Jiayu = "Jiayu"; public string jiayu = "jiayu";
    public string THL = "THL"; public string thl = "thl"; public string Elephone = "Elephone"; public string elephone = "elephone";
    public string Cubot = "Cubot"; public string cubot = "cubot"; public string iOcean = "iOcean"; public string iocean = "iocean";
    public string Kingzone = "Kingzone"; public string kingzone = "kingzone"; public string No1 = "No.1."; public string no1 = "no.1.";
    public string Oneplus = "Oneplus"; public string oneplus = "oneplus"; public string Oppo = "Oppo"; public string oppo = "oppo";
    public string UMI = "UMI"; public string umi = "umi"; public string Xiaocai = "Xiaocai"; public string xiaocai = "xiaocai";
    public string Zopo = "Zopo"; public string zopo = "zopo";
    //Marcas mundiales
    public string Samsung ="Samsung"; public string samsung ="samsung"; public string Lenovo ="Lenovo"; public string lenovo ="lenovo"; 
    public string Lg = "Lg"; public string LG = "LG"; public string lg ="lg"; public string Sony ="Sony"; public string sony ="sony";
    public string Nokia="Nokia"; public string nokia="nokia"; public string Microsoft="Microsoft"; public string microsoft="microsoft";
    public string Motorola="Motorola"; public string motorola="motorola"; public string HTC="HTC"; public string htc="htc";
    public string BlackBerry="BlackBerry"; public string Blackberry="Blackberry"; public string blackberry="blackberry";
    public string Asus="Asus"; public string asus="asus"; public string ZTE="ZTE"; public string Zte="Zte"; 
    public string Lanix="Lanix"; public string lanix="lanix"; 

    public MarcaTelefono(int anio, string marca):base(anio, marca){}

    public override string anioValido()
    {
        try{
            if(anio>=2009)
            {
                System.Console.WriteLine(mensajeAnio);
            }
            else if(anio<2009)
            {
                System.Console.WriteLine(mensajeAnioNoValido);
                Environment.Exit(0);
            }
        }
        catch(IOException ioe){
            System.Console.WriteLine(ioe.ToString());
            throw new System.NotImplementedException();
        }
        return base.anio+"";
    }
    public override string marcaValidacion()
    {
        try
        {
            if(marca==iphone || marca == iPhone)
            {
                System.Console.WriteLine("Haz ingresado: {0}", marca);
                System.Console.WriteLine(mensajeMarcaInvalida);
                Environment.Exit(0);
            }
            else if(marca==Huawei||marca==huawei || marca==Xiaomi || marca==xiaomi || marca==Meizu || marca==meizu || 
            marca==Jiayu || marca==jiayu ||marca==THL|| marca==thl || marca==Elephone || marca==elephone || marca == Cubot ||
            marca==cubot || marca==iOcean || marca==iocean || marca==kingzone || marca==Kingzone || marca==No1 || marca==no1 ||
            marca==Oneplus || marca== oneplus || marca==Oppo || marca == oppo || marca==UMI || marca==umi || marca==Xiaocai ||
            marca == xiaocai || marca==Zopo || marca==zopo)
            {
                System.Console.WriteLine("Haz ingresado: {0}", marca);
                System.Console.WriteLine(mensajeMarcaInvalida);
                Environment.Exit(0);
            }
            else if(marca==Lanix || marca==lanix || marca==Samsung||marca==samsung||marca==Lenovo||marca==lenovo||
            marca==Lg||marca==lg||marca==Sony||marca==sony||marca==nokia||marca==Nokia||marca==Microsoft||marca==microsoft||
            marca==motorola||marca==Motorola||marca==HTC||marca==htc||marca==BlackBerry||marca==blackberry||marca==Blackberry||
            marca==Asus||marca==asus)
            {
                System.Console.WriteLine("Haz ingresado: {0}",marca);
                System.Console.WriteLine(mensajeMarcaValida);
                Environment.Exit(0);
            }
            
        }
        catch(IOException ioe)
        {
            System.Console.WriteLine(ioe.ToString());
            throw new System.NotImplementedException();
        }
        return base.anio+" "+base.marca;
    }
}