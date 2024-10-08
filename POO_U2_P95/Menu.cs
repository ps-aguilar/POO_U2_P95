using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_U2_P95
{
    internal class Menu
    {
        List<Opcion> opciones;
        List<Opcion> opcionesSecundarias;
        FiguraGeometrica figura;
        public Menu()
        {
            opcionesSecundarias = new List<Opcion>()
            {
                new Opcion("Área", calcularArea),
                new Opcion("Perímetro", calcularPerimetro),
                new Opcion("Ambos", calcularAreaPerimetro),
            };

            opciones = new List<Opcion>()
            {
                new Opcion("Circulo", Circulo),
                new Opcion("Rectángulo", Rectangulo),
                new Opcion("Triángulo", Triangulo),
                new Opcion("Pentágono", Pentagono),
                new Opcion("Hexágono", Hexagono),
                new Opcion("Salir", Salir),
             };

            while (true)
            {
                Console.WriteLine("**Calculadora de Área y Perímetro**");
                Console.WriteLine("Seleccione la opción deseada:");
                Console.WriteLine();
                MostrarMenu(opciones);
                Console.WriteLine();
                seleccionarOpcion(opciones);
                Console.Clear();
            }
        }

        ////
        public void MostrarMenu(List<Opcion> lista)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                Console.Write("{0}) ", (i + 1));
                Console.WriteLine("{0}", lista[i].Message);
            }
        }

        public void seleccionarOpcion(List<Opcion> lista)
        {
            int numOpcion = int.Parse(Console.ReadLine());
            Console.Clear();
            lista[numOpcion - 1].Action.Invoke();
        }
        public void Continuar()
        {
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadLine();
        }

        public void SeleccionarCalculo()
        {
            Console.WriteLine("\nSeleccione la opción que desee calcular: ");
            MostrarMenu(opcionesSecundarias);
            seleccionarOpcion(opcionesSecundarias);
            Console.WriteLine();
            Continuar();
        }

        ////

        public void Circulo()
        {
            Console.Write("Ingrese el radio del círculo: ");
            float radio = float.Parse(Console.ReadLine());

            figura = new Circulo("Círculo", radio);
            SeleccionarCalculo();
        }

        public void Rectangulo()
        {
            Console.Write("Ingrese la base del rectángulo: ");
            float largo = float.Parse(Console.ReadLine());

            Console.Write("Ingrese la altura del rectángulo: ");
            float ancho = float.Parse(Console.ReadLine());

            figura = new Rectangulo("Rectángulo", largo, ancho);
            SeleccionarCalculo();
        }

        public void Triangulo()
        {
            Console.WriteLine("Ingrese los valores para el triángulo:");

            Console.Write("Lado A (que será la base): ");
            float ladoA = float.Parse(Console.ReadLine());

            Console.Write("Lado B: ");
            float ladoB = float.Parse(Console.ReadLine());

            Console.Write("Lado C: ");
            float ladoC = float.Parse(Console.ReadLine());

            Console.Write("Altura: ");
            float altura = float.Parse(Console.ReadLine());

            figura = new Triangulo("Triángulo", ladoA, ladoB, ladoC, altura);
            SeleccionarCalculo();
        }
        public void Pentagono()
        {
            Console.Write("Ingrese el lado del pentágono: ");
            float lado = float.Parse(Console.ReadLine());

            Console.Write("Ingrese la apotema del pentágono: ");
            float apotema = float.Parse(Console.ReadLine());

            figura = new Pentagono("Pentágono", lado, apotema);
            SeleccionarCalculo();
        }

        public void Hexagono()
        {
            Console.Write("Ingrese el lado del hexágono: ");
            float lado = float.Parse(Console.ReadLine());

            Console.Write("Ingrese la apotema del hexágono: ");
            float apotema = float.Parse(Console.ReadLine());

            figura = new Hexagono("Hexágono", lado, apotema);
            SeleccionarCalculo();
        }

        public void Salir()
        {
            Console.WriteLine("Cerrando el programa...");
            Thread.Sleep(1000);
            Environment.Exit(0);
        }

        /// Opciones secundarias

        public void calcularArea()
        {
            Console.WriteLine("El área es: " + figura.CalcularArea());
        }

        public void calcularPerimetro()
        {
            Console.WriteLine("El perímetro es: " + figura.CalcularPerimetro());
        }

        public void calcularAreaPerimetro()
        {
            calcularArea();
            calcularPerimetro();
        }
    }
}
