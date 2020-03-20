using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using NetDimension.WinForm;

namespace DemoApp
{
	public partial class frmAbout : ModernUIForm
	{
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		[DllImport("user32.dll")]
		public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

		public const int WM_SYSCOMMAND = 0x0112;
		public const int SC_MOVE = 0xF010;
		public const int HTCAPTION = 0x0002;

		public frmAbout()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("https://www.paypal.me/mrjson");
		}

		private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}