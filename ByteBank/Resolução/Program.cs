using System;

namespace Resolução
{
    class Program
    {
        static void Main(string[] args)
        {
            //   ContaCorrente primeiraConta = new ContaCorrente();

            // primeiraConta.saldo = 200;
            //Console.WriteLine(primeiraConta.saldo);

            //primeiraConta.saldo += 100;
            //Console.WriteLine(primeiraConta.saldo);

            //ContaCorrente segundaConta = new ContaCorrente();
            //segundaConta.saldo = 50;

            //Console.WriteLine("A primeira conta tem " + primeiraConta.saldo);
            //Console.WriteLine("A segunda conta tem " + segundaConta.saldo);

            //  ContaCorrente contaDoBruno = new ContaCorrente();

            //contaDoBruno.titular = "Bruno";
            //contaDoBruno.saldo = 125;

            // ContaCorrente contaDaJessica = new ContaCorrente();

            //contaDaJessica.titular = "Jessica";
            //contaDaJessica.saldo = 200;

            //contaDaJessica.depositar(50);
            //contaDoBruno.depositar(15);

            //  Console.WriteLine("Saldo da conta do Bruno : " + contaDoBruno.saldo);
            //Console.WriteLine("Saldo da conta da Jessica : " + contaDaJessica.saldo);

            //contaDaJessica.Sacar(22);
            //           contaDoBruno.Sacar(22);

            //         Console.WriteLine("Saldo da conta do Bruno : " + contaDoBruno.saldo);
            //       Console.WriteLine("Saldo da conta da Jessica : " + contaDaJessica.saldo);

            //     contaDoBruno.Transferir(100, contaDaJessica);
            //   Console.WriteLine("Saldo da conta do Bruno : " + contaDoBruno.saldo);
            // Console.WriteLine("Saldo da conta da Jessica : " + contaDaJessica.saldo);

            ContaCorrente contaDaCamila = new ContaCorrente();
            contaDaCamila.titular = new Cliente();
            Console.WriteLine(contaDaCamila.titular.nome);

            contaDaCamila.titular.nome = "Camila";
            Console.WriteLine(contaDaCamila.titular.nome);


            Console.ReadLine();
        }
    }
}
