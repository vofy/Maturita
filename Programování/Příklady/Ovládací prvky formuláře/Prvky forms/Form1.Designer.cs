/*
 * Created by SharpDevelop.
 * User: Acer
 * Date: 01.04.2021
 * Time: 17:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Prvky_forms
{
	partial class Form1
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label ColorLabel;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label SportLabel;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.ColorLabel = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.SportLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(259, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Jméno:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(13, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(259, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Příjmení:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(13, 67);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(259, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Datum narození:";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(13, 94);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(259, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Telefonní číslo:";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(13, 121);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(259, 23);
			this.label5.TabIndex = 4;
			this.label5.Text = "Oblíbená destinace:";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(13, 148);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(402, 23);
			this.label6.TabIndex = 5;
			this.label6.Text = "Pohlaví:";
			// 
			// ColorLabel
			// 
			this.ColorLabel.Location = new System.Drawing.Point(13, 197);
			this.ColorLabel.Name = "ColorLabel";
			this.ColorLabel.Size = new System.Drawing.Size(165, 14);
			this.ColorLabel.TabIndex = 6;
			this.ColorLabel.Text = "Oblíbená barva:";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(175, 197);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(13, 14);
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// SportLabel
			// 
			this.SportLabel.Location = new System.Drawing.Point(13, 171);
			this.SportLabel.Name = "SportLabel";
			this.SportLabel.Size = new System.Drawing.Size(512, 23);
			this.SportLabel.TabIndex = 8;
			this.SportLabel.Text = "Oblíbený sport:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(531, 259);
			this.Controls.Add(this.SportLabel);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.ColorLabel);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
