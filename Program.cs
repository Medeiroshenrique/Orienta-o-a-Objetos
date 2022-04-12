using System;
namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            Paciente p1 =new Paciente();
            p1.SetNome("Jhonatta");
            p1.Idade =20;
            Paciente p2 = new Paciente();
            p2.SetNome("Daniel");
            p2.Idade = 22;
            Paciente p3 = new Paciente();
            p3.SetNome("Marcela");
            p3.Idade = 21;
            Console.WriteLine(p1.GetNome());
            Console.WriteLine(p1.Idade);
            Console.WriteLine(p2.GetNome());
            Console.WriteLine(p2.Idade);
            Console.WriteLine(p3.GetNome());
            Console.WriteLine(p3.Idade);

        }  
    }
}
