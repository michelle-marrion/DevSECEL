using System.Net.Sockets ;
using System.Net ;
using System.Text;

// Serveur en ecoute et acceptant des connexions

      Socket socket = new Socket(
            AddressFamily.InterNetwork,
            SocketType.Stream,
            ProtocolType.Tcp
      ) ;
      IPEndPoint endpoint = new IPEndPoint(
            IPAddress.Any,
            2345
      ) ;
      try
      {
            socket.Bind(endpoint) ;
            socket.Listen();
      }
      catch
      {
            System.Console.WriteLine("Impossible de demarrer le seveur !!");
            Environment.Exit(-1);
      }
      
try
{
      var clientSocket = socket.Accept();
      
      if (clientSocket.RemoteEndPoint is not null)
      {
          Console.WriteLine("Client Connecté depuis "+clientSocket.RemoteEndPoint.ToString()); 
          while(true)
          {
            byte[] buffer = new byte[128];
            int nb = clientSocket.Receive(buffer);
            Console.WriteLine("Message reçu : "+Encoding.UTF8.GetString(buffer, 0, nb));
          }
      }    
}
catch 
{
   Console.WriteLine("La communication avec le client n'est pas possible !!!");
}
finally
{
      if (socket.Connected)
      {
            socket.Shutdown(SocketShutdown.Both);
      }
      socket.Close();
}

