
namespace SocketsServerApp
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Net.Sockets;
    using System.Text;
    using System.Xml.Schema;

    public class SynchronousSocketListener
    {
        public static void StartListening(System.Windows.Forms.PictureBox piPictureBox)
        {
            // Data buffer for incoming data.  
            byte[] bytes = new Byte[1024];
            byte[] bytesImgSize = new Byte[4];

            // Establish the local endpoint for the socket.  
            // Dns.GetHostName returns the name of the
            // host running the application.  
            IPAddress ipAddress = IPAddress.Parse("0.0.0.0");
            IPEndPoint endPoint = new IPEndPoint(ipAddress, 5555);

            // Create a TCP/IP socket.  
            Socket listener = new Socket(ipAddress.AddressFamily,
                SocketType.Stream, ProtocolType.Tcp);

            // Bind the socket to the local endpoint and
            // listen for incoming connections.  
            try
            {
                listener.Bind(endPoint);
                listener.Listen(3);

                var imgBytes = new List<byte>();
                // Start listening for connections.  
                //while (true)
                {
                    Console.WriteLine("Waiting for a connection...");
                    // Program is suspended while waiting for an incoming connection.  
                    Socket handler = listener.Accept();

                    //while (true)
                    {
                        // An incoming connection needs to be processed.  
                        int bytesRec = handler.Receive(bytesImgSize);
                        int imgSize = BitConverter.ToInt32(bytesImgSize, 0);

                        while (imgBytes.Count < imgSize)
                        {
                            bytesRec = handler.Receive(bytes);
                            imgBytes.AddRange(bytes.Take(bytesRec));
                        }

                        using (var ms = new MemoryStream(imgBytes.GetRange(0, imgBytes.Count - 4).ToArray()))
                        {
                            piPictureBox.Image = new Bitmap(ms);
                        }
                    }

                    handler.Shutdown(SocketShutdown.Both);
                    handler.Close();
                    
                    //break;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            //Console.WriteLine("\nPress ENTER to continue...");
            //Console.Read();

        }
    }
}
