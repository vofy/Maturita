/*
 * Created by SharpDevelop.
 * User: Acer
 * Date: 31.03.2021
 * Time: 11:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Prvky_forms
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		Control[] prvky = new Control[]{};
		
		public MainForm()
		{
			Application.EnableVisualStyles();
			InitializeComponent();
			Control[] IP = new Control[]{textBox1,textBox2,dateTimePicker1,numericUpDown1,comboBox1};
			prvky = IP;
		}
		
		// po kliknutí otevře html stránku
		void LinkLabel1LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("https://tools.google.com/dlpage/res/webmmf/en/eula.html");
		}
		
		void Odeslat_Click(object sender, EventArgs e)
		{
			List<String> text = new List<String>{}; List<String> sporty = new List<String>{}; int pocet = 0; String barva1 = "Black";
			for(int i = 0;i<prvky.Length;i++)
			{
				switch(prvky[i].GetType().Name)
				{
						case "NumericUpDown": String cislo;
						cislo = "+420 " + Convert.ToString(numericUpDown1.Value).Substring(0,3) + " " + Convert.ToString(numericUpDown1.Value).Substring(3,3) + " " + Convert.ToString(numericUpDown1.Value).Substring(6,3);
						text.Add(cislo);
						break;
						case "DateTimePicker":
						String datum = dateTimePicker1.Value.ToShortDateString();
							text.Add(datum);break;
						default: text.Add(prvky[i].Text); break;
				}
			}
			
			if(radioButton1.Checked) { text.Add(radioButton1.Text); }
			else if(radioButton2.Checked) { text.Add(radioButton2.Text); }
			else { text.Add(radioButton3.Text); }
			
			foreach(String s in checkedListBox1.CheckedItems)
			{
				sporty.Add(s);
				pocet++;
			}
			
			//Zjišťuje název barvy porovnáním barvy s barvami ve výčtovým typu KnownColor
			foreach (KnownColor kc in Enum.GetValues(typeof(KnownColor)))
			{
        		Color known = Color.FromKnownColor(kc);
        		if (Color.FromArgb(Convert.ToInt32(Rlabel.Text),Convert.ToInt32(Glabel.Text),Convert.ToInt32(Blabel.Text)).ToArgb() == known.ToArgb())
        		{
        			barva1 = known.Name;
        		}
			}
			
			pocet = 0;
			Form1 frm = new Form1(text,sporty,barva1,pictureBox1.BackColor);
			frm.Show();
		}
		
		void CheckBox1CheckedChanged(object sender, EventArgs e)
		{
			bool pravda = checkBox1.Checked;
			if(Vyplneno())
			{
				checkBox1.Checked = pravda;
				button1.Enabled = pravda;
			}
			else
			{
				button1.Enabled = false;
				checkBox1.Checked = false;
			}
		}
		
		public bool Vyplneno()
		{
			bool plne = true;
			foreach(Control c in prvky)
			{
				switch(c.GetType().Name)
				{
					case "NumericUpDown": if(Convert.ToInt32(Convert.ToString(c.Text).Length) != 9){
									errorProvider1.SetError(c,"Nesprávný formát čísla (musí zde být 9 čísel)!");
									plne = false;
						}break;
						case "DateTimePicker": if(DateTime.Compare(dateTimePicker1.Value,DateTime.Today) > 0)
							{
								plne=false;
							}break;
					default: if(c.Text == String.Empty)
							{
								errorProvider1.SetError(c,"Tato položka musí být vyplněná!!");
								plne = false;
							}break;
				}
			}
			return plne;
		}
		
		
		
		void HScrollBarValueChanged(object sender, EventArgs e)
		{
			Rlabel.Text = Convert.ToString(RHScrollBar.Value);
			Glabel.Text = Convert.ToString(GHScrollBar.Value);
			Blabel.Text = Convert.ToString(BHScrollBar.Value);
			pictureBox1.BackColor = Color.FromArgb(Convert.ToInt32(Rlabel.Text),Convert.ToInt32(Glabel.Text),Convert.ToInt32(Blabel.Text));
		}
		
		void Reset()
		{
			checkBox1.Checked = false;
			button1.Enabled = false;
		}
		
		//nastavuje error pro prvky s textem
		void TBErrorProvider(Control prvek)
		{
			if(prvek.Text == string.Empty)
			{
				errorProvider1.SetError(prvek,"Položka nesmí být prázdná!");
			}
			else{ errorProvider1.SetError(prvek,"");}
		}
		
		#region Obslužné metody události Validating
		void TextBoxValidating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			TBErrorProvider(textBox1);
			Reset();
		}
		
		void TextBox2Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			TBErrorProvider(textBox2); 
			Reset();
		}
		
		void ComboBox1Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if(comboBox1.SelectedItem == null)
			{
				errorProvider1.SetError(comboBox1,"Vyberte alespoň jednu položku!");
			}
			else{errorProvider1.SetError(comboBox1,"");}
			Reset();
		}
		
		void GroupBox1Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if(radioButton1.Checked || radioButton2.Checked || radioButton3.Checked)
			{
				errorProvider1.SetError(groupBox1,"");
				
			}
			else{errorProvider1.SetError(groupBox1,"Alespoň jedna položka musí být zaškrtnuta");}
			Reset();
		}
		
		void NumericUpDown1Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if(Convert.ToInt32(Convert.ToString(numericUpDown1.Value).Length) != 9)
			{
				errorProvider1.SetError(numericUpDown1,"Nesprávný formát čísla (musí zde být 9 čísel)!");
			}
			else{errorProvider1.SetError(numericUpDown1,"");}
			Reset();
		}
		
		void DateTimePicker1Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if(DateTime.Compare(dateTimePicker1.Value,DateTime.Today) > 0)
			{
				errorProvider1.SetError(dateTimePicker1,"Vyberte datum v minulosti!");
			}
			else{errorProvider1.SetError(dateTimePicker1,"");}
			Reset();
		}
		#endregion
	}
}
