using System;

namespace estructura_de_datos_u
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteData();
            if (GetPassword())
            {
                Taxes taxes = new Taxes();
                taxes.getDataUser();
                taxes.calculateValue();
            }
            else
            {
                Console.WriteLine("LO SENTIMOS CONTRASEÑA INCORRECTA");
            }
        }

        static bool GetPassword()
        {
            Seguridad validate = new Seguridad();
            Console.WriteLine(":::  INGRESE LA CONTRASEÑA");
            int Password = int.Parse(Console.ReadLine());
            return validate.ValidarPassword(Password);
        }

        static void WriteData()
        {
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(":::  BIENVENIDO  :::");
            Console.WriteLine(":::  NOMBRE -> ANDRES MAURICIO ACELAS  :::");
            Console.WriteLine(":::  SOFTWARE PARA CALCULAR EL IMPUESTO PREDIAL  :::");
            Console.WriteLine(":::  CURSO -> ESTRUCTURA DE DATOS  :::");
            Console.WriteLine("----------------------------------------------");
        }
    }


}
