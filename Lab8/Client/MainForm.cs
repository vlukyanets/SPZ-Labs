using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
	using System.Net;
	using System.Net.Sockets;

	public partial class MainForm : Form
	{
		private String ip = "";

		public MainForm()
		{
			InitializeComponent();
			this.updateTimer.Enabled = false;
		}

		private void setIpButton_Click(object sender, EventArgs e)
		{
			ip = this.ipTextBox.Text;
			this.updateTimer.Enabled = true;
		}

		private void updateTimer_Tick(object sender, EventArgs e)
		{
			try
			{
				String request = "cpu";
				IPHostEntry ipHost = Dns.GetHostEntry(ip);
				IPAddress ipAddress = ipHost.AddressList[0];
				IPEndPoint ipEndpoint = new IPEndPoint(ipAddress, 10101);

				Socket socket = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
				socket.Connect(ipEndpoint);

				byte[] requestBytes = Encoding.UTF8.GetBytes(request);
				socket.Send(requestBytes, requestBytes.Length, SocketFlags.None);

				byte[] bytes = new byte[10];
				socket.Receive(bytes);

				String result = Encoding.UTF8.GetString(bytes);
				resultLabel.Text = String.Format("{0:2} %", result);

				socket.Shutdown(SocketShutdown.Both);
				socket.Close();
			}
			catch (Exception)
			{}
		}
	}
}
