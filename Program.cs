using System;
using POO_Heranca.classes;

namespace POO_Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica pf = new PessoaFisica ();
            pf.nome = "Yan";
            
            Console.WriteLine("Digite seu CPF");
            pf.cpf = Console.ReadLine();

            Console.WriteLine(pf.DarBoasVindas(pf.nome));
            Console.WriteLine(pf.ValidarCPF(pf.cpf));
        }
    }
}
