using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFRestaurante
{
    public abstract class Restaurantes
    {
        public abstract Comida PedirComida();
        public abstract Bebida ServirBebida();
        public abstract Postre OrdenarPostre();
    }

    public abstract class Comida
    {
        public abstract void PedirC();
    }

    public abstract class Bebida
    {
        public abstract void ServirB();
    }

    public abstract class Postre
    {
        public abstract void OrdenarP();
    }
    //Comida Mexicana
    public class Tacos : Comida
    {
        public override void PedirC()
        {
            Console.WriteLine("Comida: Tacos");
        }
    }

    public class AguaJamaica : Bebida
    {
        public override void ServirB()
        {
            Console.WriteLine("Bebida: Agua de Jamaica");
        }
    }

    public class PastelTresLeches : Postre
    {
        public override void OrdenarP()
        {
            Console.WriteLine("Postre: Pastel de Tres Leches");
        }
    }
    //Comida China
    public class Cantones : Comida
    {
        public override void PedirC()
        {
            Console.WriteLine("Comida: Pollo Cantones");
        }
    }

    public class TeJazmin : Bebida
    {
        public override void ServirB()
        {
            Console.WriteLine("Bebida: Te de Jazmin");
        }
    }
   
    public class RollosDulces : Postre
    {
        public override void OrdenarP()
        {
            Console.WriteLine("Postre: Rollos Dulces");
        }
    }
    //Comida Japonesa

    public class Ramen : Comida
    {
        public override void PedirC()
        {
            Console.WriteLine("Comida: Ramen");
        }
    }
    public class Sake : Bebida
    {
        public override void ServirB()
        {
            Console.WriteLine("Bebida: Sake");    
        }
    }

    public class Dango : Postre
    {
        public override void OrdenarP()
        {
            Console.WriteLine("Postre: Dango");
        }
    }
    //Comida Italiana
    public class Pizza : Comida
    {
        public override void PedirC()
        {
            Console.WriteLine("Comida: Pizza");
        }
    }
    public class Vino : Bebida
    {
        public override void ServirB()
        {

            Console.WriteLine("Bebida: Vino");
        }
    }
    public class Tiramisu : Postre
    {
        public override void OrdenarP()
        {
            Console.WriteLine("Postre: Tiramisu");
        }
    }
    //Comida Americana
    public class Hamburguesa : Comida
    {
        public override void PedirC()
        {
            Console.WriteLine("Comida: Hamburguesa");
        }
    }
    public class DrPepper : Bebida
    {
        public override void ServirB()
        {
            Console.WriteLine("Bebida: Dr Pepper");
        }
    }
    public class PayManzana : Postre
    {
        public override void OrdenarP()
        {
            Console.WriteLine("Postre: Pay de Manzana");
        }
    }
    //Fabricas concretas
    public class RestauranteMexicano : Restaurantes
    {
        public override Comida PedirComida()
        {
            return new Tacos();
        }
        public override Bebida ServirBebida()
        {
            return new AguaJamaica();
        }
        public override Postre OrdenarPostre()
        {
            return new PastelTresLeches();
        }
    }
    public class RestauranteChino : Restaurantes
    {
        public override Comida PedirComida()
        {
            return new Cantones();
        }
        public override Bebida ServirBebida()
        {
            return new TeJazmin();
        }
        public override Postre OrdenarPostre()
        {
            return new RollosDulces();
        }
    }
    public class RestauranteJapones : Restaurantes
    {
        public override Comida PedirComida()
        {
            return new Ramen();
        }
        public override Bebida ServirBebida()
        {
            return new Sake();
        }
        public override Postre OrdenarPostre()
        {
            return new Dango();
        }
    }
    public class RestauranteItaliano : Restaurantes
    {
        public override Comida PedirComida()
        {
            return new Pizza();
        }
        public override Bebida ServirBebida()
        {
            return new Vino();
        }
        public override Postre OrdenarPostre()
        {
            return new Tiramisu();
        }
    }
    public class RestauranteAmericano : Restaurantes
    {
        public override Comida PedirComida()
        {
            return new Hamburguesa();
        }
        public override Bebida ServirBebida()
        {
            return new DrPepper();
        }
        public override Postre OrdenarPostre()
        {
            return new PayManzana();
        }
    }

    internal class RestauranteFactory
    {
        static void Main(string[] args)
        {
            Restaurantes restaurante;
            restaurante = new RestauranteMexicano();

            Comida comida = restaurante.PedirComida();
            Bebida bebida = restaurante.ServirBebida();
            Postre postre = restaurante.OrdenarPostre();


            comida.PedirC();
            bebida.ServirB();
            postre.OrdenarP();

            Console.WriteLine("");

            restaurante = new RestauranteChino();

            comida = restaurante.PedirComida();
            bebida = restaurante.ServirBebida();
            postre = restaurante.OrdenarPostre();

            comida.PedirC();
            bebida.ServirB();
            postre.OrdenarP();

            

            restaurante = new RestauranteJapones();

            comida = restaurante.PedirComida();
            bebida = restaurante.ServirBebida();
            postre = restaurante.OrdenarPostre();

            comida.PedirC();
            bebida.ServirB();
            postre.OrdenarP();

            

            restaurante = new RestauranteItaliano();

            comida = restaurante.PedirComida();
            bebida = restaurante.ServirBebida();
            postre = restaurante.OrdenarPostre();

            comida.PedirC();
            bebida.ServirB();
            postre.OrdenarP();

            

            restaurante = new RestauranteAmericano();

            comida = restaurante.PedirComida();
            bebida = restaurante.ServirBebida();
            postre = restaurante.OrdenarPostre();

            comida.PedirC();
            bebida.ServirB();
            postre.OrdenarP();

            Console.ReadKey();
        }
    }
}
