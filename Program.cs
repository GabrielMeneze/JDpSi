using System;

namespace Poliformismo_10
{
    class Program
    {
        static void Main(string[] args)
        {
             System.Console.WriteLine("Kratos");
            Kratos kratos = new Kratos();
            kratos.Atirar();
            kratos.Curar();
            System.Console.WriteLine();
            System.Console.WriteLine("Zeus");
            Zeus zeus = new Zeus();
            zeus.Atirar();
            zeus.Curar();
        }
    }
}
