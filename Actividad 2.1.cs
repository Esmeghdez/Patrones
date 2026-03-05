using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    public abstract class MaterialFactory
    {
        public abstract Guia CrearGuia();
        public abstract Examen CrearExamen();
    }

    public abstract class Guia
    {
        public abstract void Mostrar();
    }

    public abstract class Examen
    {
        public abstract void Aplicar();
    }

    public class GuiaImpresa : Guia
    {
        public override void Mostrar()
        {
            Console.WriteLine("Mostrando la guia impresa");
        }
    }

    public class ExamenEnPapel : Examen
    {
        public override void Aplicar()
        {
            Console.WriteLine("Se aplica examen en papel");
        }
    }
    public class GuiaPDF : Guia
    {
        public override void Mostrar()
        {
            Console.WriteLine("Mostrando la guia PDF");
        }
    }

    public class ExamenOnLine : Examen
    {
        public override void Aplicar()
        {
            Console.WriteLine("Se aplica examen en linea");
        }
    }

    public class GuiaHibrida : Guia
    {
        public override void Mostrar()
        {
            Console.WriteLine("Mostrando la guia hibrida");
        }
    }

    public class ExamenHibrido : Examen
    {
        public override void Aplicar()
        {
            Console.WriteLine("Se aplica el examen hibrido");
        }
    }

    public class MaterialPresencialFactory : MaterialFactory
    {
        public override Guia CrearGuia()
        {
            return new GuiaImpresa();
        }
        public override Examen CrearExamen()
        {
            return new ExamenEnPapel();
        }
    }

    public class MaterialVirtualFactory : MaterialFactory
    {
        public override Guia CrearGuia()
        {
            return new GuiaPDF();
        }
        public override Examen CrearExamen()
        {
            return new ExamenOnLine();
        }
    }

    public class MaterialHibridoFactory : MaterialFactory
    {
        public override Guia CrearGuia()
        {
            return new  GuiaHibrida();  
        }

        public override Examen CrearExamen()
        {
            return new ExamenHibrido();
        }
    }


    internal class Program

    {
        static void Main(string[] args)
        {
            MaterialFactory fabrica;
            fabrica = new MaterialPresencialFactory();

            Guia guia = fabrica.CrearGuia();
            Examen examen = fabrica.CrearExamen();

            guia.Mostrar();
            examen.Aplicar();

            Console.WriteLine("");

            fabrica = new MaterialVirtualFactory();

            guia = fabrica.CrearGuia();
            examen = fabrica.CrearExamen();

            guia.Mostrar();
            examen.Aplicar();

            fabrica = new MaterialHibridoFactory();

            guia = fabrica.CrearGuia();
            examen = fabrica.CrearExamen();

            guia.Mostrar();
            examen.Aplicar();

            Console.ReadKey();
        }
    }
}
