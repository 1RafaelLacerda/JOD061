using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace JOD061
{
    class Program
    {
        const int porta_ = 7000;
        const string ip = "192.168.0.19";
        static void Main(string[] args)
        {
            try
            {
                IPEndPoint pontoFinal = new IPEndPoint(IPAddress.Any, 0);
                UdpClient nossopar = new UdpClient(porta_);

                Console.WriteLine("Para sair, pressione - CTRL + C");
                while (true)
                {
                    byte[] bytesRecebidos = nossopar.Receive(ref pontoFinal);
                    Console.WriteLine("Mensagem recebida: {0}", Encoding.ASCII.GetString(bytesRecebidos));
                    Console.WriteLine("Mensagem enviada por {0}:{1}",pontoFinal.Address.ToString(), pontoFinal.Port.ToString());
                    
                }
            }
            catch (Exception)
            {
                UdpClient dupla = new UdpClient();
                dupla.EnableBroadcast = true;

                Console.WriteLine("Por favor envie sua mensagem. Para sair, Precione ENTER");
                Console.WriteLine("> ");
                string mensagem = Console.ReadLine();

                while (mensagem.Length > 0)
                {
                    byte[] bytesEnviados = Encoding.ASCII.GetBytes(mensagem);
                    dupla.Send(bytesEnviados, bytesEnviados.Length, ip, porta_);

                    Console.Write("> ");
                    mensagem = Console.ReadLine();

                }
                dupla.Close();

            }
        }
    }
}
