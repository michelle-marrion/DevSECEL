﻿using System.Net.Sockets ;
using System.Net ;
using System.Text ;

var socket = new Socket (
      AddressFamily.InterNetwork,
      SocketType.Stream,
      ProtocolType.Tcp
);
var endpoint = new IPEndPoint(
      IPAddress.Loopback,
      2345
);
try
{
      socket.Connect(endpoint);

      while (true)
      {
            string? message = Console.ReadLine();
            if (message == "q")
            {
                  break ;
            }
            if (!string.IsNullOrEmpty(message))
            {
                  var buffer = Encoding.UTF8.GetBytes(message);
                  socket.Send(buffer); 
            }
            
      }
}
catch
{
      Console.WriteLine("Le serveur est Injoignable !");
}
finally
{
      if (socket.Connected)
      {
            socket.Shutdown(SocketShutdown.Both);
      }
      socket.Close();
}