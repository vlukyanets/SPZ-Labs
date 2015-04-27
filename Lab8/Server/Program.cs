using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
	using System.Net;
	using System.Net.Sockets;

	using System.Diagnostics;

	class Program
	{
		private static PerformanceCounter cpuPerformanceCounter
			= new PerformanceCounter("Processor", "% Processor Time", "_Total"); 

		static void Main(string[] args)
		{
			//cpuPerformanceCounter.

			//IPHostEntry ipHost = Dns.GetHostEntry("127.0.0.1");
			IPAddress ip = IPAddress.Parse("127.0.0.1");//ipHost.AddressList[0];
			IPEndPoint ipEndpoint = new IPEndPoint(ip, 10101);

			Socket listener = new Socket(ip.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

			listener.ReceiveBufferSize = 100;
			listener.SendBufferSize = 100;

			try
			{
				listener.Bind(ipEndpoint);
				listener.Listen(10); // Maximum 10 clients

				while (true)
				{
					Socket handler = listener.Accept();
					String data = null;

					byte[] bytes = new byte[10];
					int receivedBytes = handler.Receive(bytes);

					data = Encoding.UTF8.GetString(bytes, 0, receivedBytes);
					String response = null;

					Console.WriteLine(String.Format("Connected from {0}", handler.RemoteEndPoint));
					Console.WriteLine(String.Format("Request: {0}", data));

					switch (data)
					{
						case "cpu":
							float value = cpuPerformanceCounter.NextValue();
							response = value.ToString();
							break;

						default:
							break;
					}

					if (response != null)
					{
						byte[] responseBytes = Encoding.UTF8.GetBytes(response);
						handler.Send(responseBytes, 0, responseBytes.Length, SocketFlags.None);
					}

					handler.Shutdown(SocketShutdown.Both);
					handler.Close();
				}
			}
			catch (Exception e)
			{
				Console.WriteLine(String.Format("Unexpected error: {0}", e.Message));
			}
		}
	}
}
