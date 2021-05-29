using System;

namespace DPRN2_U3_A2_ANEA
{
    class Program
    {
        static void Main(string[] args)
        {
            int anioDelTelefono;
            string anioIn;
            System.Console.WriteLine("Escribe el año de tu teléfono: ");
            anioIn = System.Console.ReadLine();
            try
            {
                anioDelTelefono = System.Convert.ToInt32(anioIn);
                switch(anioDelTelefono)
                {
                    case 1 when (anioDelTelefono>=2009):
                    int adt = anioDelTelefono;
                    MarcaTelefono marcatelefono = new MarcaTelefono(adt);
                    marcatelefono.mostrarAnioElegido();

                    break;
                    case 2 when (anioDelTelefono<2009):

                    break;
                }
            }
            catch(FormatException fe)
            {
                System.Console.WriteLine("Escribiste un dato que no es válido: '" + anioIn + "' no es un número.");
            }
            System.Console.ReadLine();
        }
    }
}
