using System;

namespace DPRN2_U3_A2_ANEA
{
    class Program
    {
        static void Main(string[] args)
        {
            int anioDelTelefono;
            string anioIn;
            string marcaIn;
            bool anioValido;
            System.Console.WriteLine("Escribe el año de tu teléfono: ");
            anioIn = System.Console.ReadLine();
            anioDelTelefono = System.Convert.ToInt32(anioIn);
            System.Console.WriteLine("Ingresa la marca de tu teléfono: ");
            marcaIn = System.Console.ReadLine();
            try
            {
                if(anioDelTelefono>=2009){
                    anioValido = true;
                    MarcaTelefono aniovalido = new MarcaTelefono(anioDelTelefono, marcaIn);
                    aniovalido.mostrarAnioElegido();
                    aniovalido.anioValido();
                    //Validación marca
                    MarcaTelefono marcavalidacion=new MarcaTelefono(anioDelTelefono,marcaIn);
                    marcavalidacion.marcaValidacion();
                }else if(anioDelTelefono<2009){
                    anioValido = false;
                    MarcaTelefono anioinvalido = new MarcaTelefono(anioDelTelefono, marcaIn);
                    anioinvalido.mostrarAnioElegido();
                    anioinvalido.anioValido();
                }
            }
            catch(FormatException fe)
            {
                System.Console.WriteLine("Escribiste un dato que no es válido: '" + anioIn + "' no es un número.");
                System.Console.WriteLine(fe);
            }
            System.Console.ReadLine();
        }
    }
}