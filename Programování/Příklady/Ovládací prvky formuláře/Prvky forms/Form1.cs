/*
 * Created by SharpDevelop.
 * User: Acer
 * Date: 01.04.2021
 * Time: 17:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Prvky_forms
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		String[] PoleText = new String[]{};
		String[] PoleSport = new String[]{};
		public Form1(List<String> text, List<String> sporty,String barva,Color color)
		{
			Application.EnableVisualStyles();
			InitializeComponent();
			PoleText = text.ToArray(); PoleSport = sporty.ToArray();
			Control[] Label = new Control[]{label1,label2,label3,label4,label5,label6};
			for(int i = 0;i < PoleText.Length;i++)
			{
				Label[i].Text += " "+ PoleText[i];
			}
			
			bool prvni = true;
			foreach(String s in PoleSport)
			{
				if(prvni)
				{
					SportLabel.Text += " " + s;
					prvni = false;
				}
				else{ SportLabel.Text += ", " + s;}
			}
			
			ColorLabel.Text += " "+ barva;
			pictureBox1.BackColor = color;
		}
	}
}
