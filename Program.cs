using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Central_911
    {
        private static Central_911 _instance;
        private static readonly object _lock = new object();

        public string Central { get; private set; }

        private Central_911()
        {
            Central = "Central 911";
        }

        public static Central_911 Obtener_Instancia()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Central_911();
                    }
                }

            }
            return _instance;
        }

        public void ConectarLlamada(Operador operador, string tipoEmergencia)
        {
            Console.WriteLine("\nLlamada conectada con el operador " + operador.Nombre);
            operador.AtiendeEmergencia(tipoEmergencia);
        }

        public class Operador
        {
            public int Id_Operador { get; set; }
            public string Nombre { get; set; }

            public Operador(int id, string nombre)
            {
                Id_Operador = id;
                Nombre = nombre;
            }

            public void AtiendeEmergencia(string tipoEmergencia)
            {
                Console.WriteLine($"Operador {Nombre} atendiendo emergencia de tipo: {tipoEmergencia}");

                switch (tipoEmergencia)
                {
                    case "Intento de Suicidio":
                        Console.WriteLine("Enviando unidades de apoyo y rescate");
                        break;
                    case "Incendio":
                        Console.WriteLine("Enviando bomberos");
                        break;
                    case "Accidente":
                        Console.WriteLine("Enviando paramedicos y oficiales");
                        break;
                    case "Violeta":
                        Console.WriteLine("Enviando una patrulla");
                        break;
                    default:
                        Console.WriteLine("Tipo de emergencia no reconocido");
                        break;
                }
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Central_911 Llamada1 = Central_911.Obtener_Instancia();
                Central_911 Llamada2 = Central_911.Obtener_Instancia();
                Central_911 Llamada3 = Central_911.Obtener_Instancia();
                Central_911 Llamada4 = Central_911.Obtener_Instancia();

                Operador op1 = new Operador(1, "Laura");
                Operador op2 = new Operador(2, "Carlos");
                Operador op3 = new Operador(3, "Yomara");
                Operador op4 = new Operador(4, "Yessica");

                Llamada1.ConectarLlamada(op1, "Incendio");
                Llamada2.ConectarLlamada(op2, "Violeta");
                Llamada3.ConectarLlamada(op3, "Accidente");
                Llamada4.ConectarLlamada(op4, "Intento de Suicidio");

                Console.WriteLine("\nLlamada1 y Llamada2: " + ReferenceEquals(Llamada1, Llamada2));
                Console.WriteLine("Llamada1 y Llamada3: " + ReferenceEquals(Llamada1, Llamada3));
                Console.WriteLine("Llamada1 y Llamada4: " + ReferenceEquals(Llamada1, Llamada4));
                Console.ReadKey();
            }
        }
    }
}
