using System;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoBruno = new ContaCorrente();

            contaDoBruno.titular = "Bruno";

            Console.WriteLine(contaDoBruno.saldo); 
            
            bool resultadoSaque = contaDoBruno.Sacar(500);

            Console.WriteLine(resultadoSaque);
            Console.WriteLine(contaDoBruno.saldo);
            


            contaDoBruno.Depositar(500);
            Console.WriteLine(contaDoBruno.saldo);



            ContaCorrente contaDaGrabriela = new ContaCorrente();

            contaDaGrabriela.titular = "Gabriela";

            Console.WriteLine("Saldo do Bruno : " + contaDoBruno.saldo);
            Console.WriteLine("Saldo da Gabriela : " + contaDaGrabriela.saldo);

            bool resultadoTransferencia = contaDoBruno.Transferir(200, contaDaGrabriela);

            Console.WriteLine("Saldo do Bruno : " + contaDoBruno.saldo);
            Console.WriteLine("Saldo da Gabriela : " + contaDaGrabriela.saldo);

            Console.WriteLine("Resultado Transferência : " + resultadoTransferencia);


            contaDaGrabriela.Transferir(100, contaDoBruno);

            Console.WriteLine("Saldo do Bruno : " + contaDoBruno.saldo);
            Console.WriteLine("Saldo da Gabriela : " + contaDaGrabriela.saldo);

            Console.ReadLine();

        }
    }
}
