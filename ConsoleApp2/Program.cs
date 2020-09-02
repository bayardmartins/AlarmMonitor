using System;
using System.Buffers.Binary;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;

class MyTcpListener
{
    public static void Main()
    {
        TcpListener server = null;
        try
        {
            // Set the TcpListener on port 13000.
            Int32 port = 9000;
            IPAddress localAddr = IPAddress.Parse("127.0.0.1");

            // TcpListener server = new TcpListener(port);
            server = new TcpListener(localAddr, port);

            // Start listening for client requests.
            server.Start();
            
            int i = 0;
            Console.Write("Starting Server...");
            // Enter the listening loop.
            while (i < 4)
            {
                i++;
                Console.Write(" Waiting for a connection... ");
                // Perform a blocking call to accept requests.
                // You could also use server.AcceptSocket() here.
                TcpClient client = server.AcceptTcpClient();
                new Thread(() => HandleClient(client)).Start();
            }
        }
        catch (SocketException e)
        {
            Console.WriteLine("SocketException: {0}", e);
        }
        finally
        {
            // Stop listening for new clients.
            server.Stop();
        }

        Console.WriteLine("\nHit enter to continue...");
        Console.Read();
    }

    public static void HandleClient(TcpClient client)
    {
        Console.WriteLine("\nClient Connected!");

        String data;
        Byte[] clientId = new Byte[4];
        // Buffer for reading data
        Byte[] bytes = new Byte[9];

        // Get a stream object for reading and writing
        NetworkStream stream = client.GetStream();

        stream.Read(clientId, 0, clientId.Length);
        int cliNum = clientId[2];
        int i;

        // Loop to receive all the data sent by the client.
        while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
        {
            Byte[] ct = new Byte[] { bytes[1], bytes[2] };
            Byte[] ev = new Byte[] { bytes[3], bytes[4] };
            //Byte[] ct = new Byte[2];
            //Byte[] ev = new Byte[2];
            //Buffer.BlockCopy(bytes, 1, ct, 0, 2);
            //Buffer.BlockCopy(bytes, 3, ev, 0, 2);
            //
            int conta = MyConverter(ct);
            int evento = MyConverter(ev);

            //int conta = BitConverter.ToInt16(ct,0);       //Encoding.UTF8.GetString(bytes,1,2);  
            //int evento = BitConverter.ToInt16(ev,0);      //Encoding.UTF8.GetString(bytes, 3, 2);

            string particao = bytes[5].ToString();      //Encoding.UTF8.GetString(bytes, 5, 1);
            string usuario =    bytes[7].ToString();    //Encoding.UTF8.GetString(bytes, 7, 1);
            string zona =       bytes[6].ToString();    //Encoding.UTF8.GetString(bytes, 6, 1);
            string check =      bytes[8].ToString();    //Encoding.UTF8.GetString(bytes, 8, 1);

            Console.Write("\nPainel {0} enviou:",cliNum);
            Console.Write("\nConta: {0}", conta);
            Console.Write("\nEvento: {0}", evento);
            Console.Write("\nPartição: {0}", particao);
            Console.Write("\nZona: {0}", zona);
            Console.Write("\nUsuário: {0}", usuario);
            Console.Write("\nCheck: {0}", check);

            // Translate data bytes to a ASCII string.
            //data = Encoding.ASCII.GetString(bytes, 0, i);

            //data = data.ToUpper();

            //byte[] msg = Encoding.ASCII.GetBytes(data);

            data = check.ToString();

            byte[] msg = Encoding.ASCII.GetBytes(data);

            // Send back a response.
            stream.Write(msg, 0, msg.Length);
            Console.WriteLine("Sent: {0}", data);
        }

        // Shutdown and end connection
        client.Close();
    }

    public static int MyConverter(Byte[] btArray)
    {
        int result = btArray[0] * 16 * 16 + btArray[1];
        return result;
    }
}