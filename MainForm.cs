/*
 * Created by SharpDevelop.
 * User: A949049
 * Date: 1/17/2012
 * Time: 1:33 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MouseMover
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		[DllImport("User32.dll")]
		private static extern int SetForegroundWindow(IntPtr hWnd);
		[DllImport("User32.dll")]
		private static extern IntPtr GetForegroundWindow();

		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			tmrMouseMover.Start();
			tmrMouseMover.Tick += new EventHandler(OnTimerExpired);
		}
		
		private void OnTimerExpired(object sender, EventArgs e) {
			IntPtr previous = GetForegroundWindow();
			SetForegroundWindow(this.Handle);
			txtIncrement.Text = (int.Parse(txtIncrement.Text.Trim()) + 1).ToString();
			SendKeys.Send(" ");
			SetForegroundWindow(previous);
		}
	}
}
