using System;
using System.Net;
using System.Net.Sockets;



namespace Servidor
{
    class Program
    {
        const int door = 7000;

        static void Main(string[] args)
        {
            TcpListener servidor = new TcpListener(IPAddress.Any,door);
            try{

            
            Console.WriteLine("Servidor no ar !");
            servidor.Start();
            }catch(Exception){
                Console.WriteLine("Deu ruim! Não subiu o servidor");
            }
            while(true){
                TcpClient client = servidor.AcceptTcpClient();  
                Console.WriteLine("Conexão estabelecida!");


                client.Close();
                Console.WriteLine("Conexão encerrada!");
            }
        }
    }
}
