/*
 * Created by SharpDevelop.
 * User: A949049
 * Date: 1/17/2012
 * Time: 1:33 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace MouseMover
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.tmrMouseMover = new System.Windows.Forms.Timer(this.components);
			this.txtIncrement = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// tmrMouseMover
			// 
			this.tmrMouseMover.Enabled = true;
			this.tmrMouseMover.Interval = 840000;
			// 
			// txtIncrement
			// 
			this.txtIncrement.Location = new System.Drawing.Point(12, 12);
			this.txtIncrement.Name = "txtIncrement";
			this.txtIncrement.Size = new System.Drawing.Size(100, 20);
			this.txtIncrement.TabIndex = 1;
			this.txtIncrement.Text = "0";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(125, 40);
			this.Controls.Add(this.txtIncrement);
			this.Name = "MainForm";
			this.Text = "MouseMover";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txtIncrement;
		private System.Windows.Forms.Timer tmrMouseMover;
	}
}
