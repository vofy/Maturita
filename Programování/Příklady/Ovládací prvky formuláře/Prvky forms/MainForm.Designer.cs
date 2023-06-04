/*
 * Created by SharpDevelop.
 * User: Acer
 * Date: 31.03.2021
 * Time: 11:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Prvky_forms
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.HScrollBar RHScrollBar;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.CheckedListBox checkedListBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.HScrollBar GHScrollBar;
		private System.Windows.Forms.HScrollBar BHScrollBar;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.Label Blabel;
		private System.Windows.Forms.Label Glabel;
		private System.Windows.Forms.Label Rlabel;
		
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
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.button1 = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.RHScrollBar = new System.Windows.Forms.HScrollBar();
			this.label3 = new System.Windows.Forms.Label();
			this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.GHScrollBar = new System.Windows.Forms.HScrollBar();
			this.BHScrollBar = new System.Windows.Forms.HScrollBar();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.Rlabel = new System.Windows.Forms.Label();
			this.Glabel = new System.Windows.Forms.Label();
			this.Blabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(148, 90);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(189, 20);
			this.dateTimePicker1.TabIndex = 0;
			this.dateTimePicker1.Validating += new System.ComponentModel.CancelEventHandler(this.DateTimePicker1Validating);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Jméno";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(24, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Příjmení";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(148, 34);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(140, 20);
			this.textBox1.TabIndex = 3;
			this.textBox1.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxValidating);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(148, 60);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(140, 20);
			this.textBox2.TabIndex = 4;
			this.textBox2.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox2Validating);
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(147, 116);
			this.numericUpDown1.Maximum = new decimal(new int[] {
			999999999,
			0,
			0,
			0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(141, 20);
			this.numericUpDown1.TabIndex = 5;
			this.numericUpDown1.Validating += new System.ComponentModel.CancelEventHandler(this.NumericUpDown1Validating);
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(23, 462);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(149, 24);
			this.checkBox1.TabIndex = 6;
			this.checkBox1.Text = "Souhlasím s podmínkami";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1CheckedChanged);
			// 
			// button1
			// 
			this.button1.Enabled = false;
			this.button1.Location = new System.Drawing.Point(62, 492);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(198, 34);
			this.button1.TabIndex = 7;
			this.button1.Text = "Odeslat";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Odeslat_Click);
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
			"Afghánistán",
			"Albánie",
			"Alžírsko",
			"Andorra",
			"Angola",
			"Antigua a Barbuda",
			"Argentina",
			"Arménie",
			"Austrálie",
			"Ázerbájdžán",
			"Bahamy",
			"Bahrajn",
			"Bangladéš",
			"Barbados",
			"Belgie",
			"Belize",
			"Bělorusko",
			"Benin",
			"Bhútán",
			"Bolívie",
			"Bosna a Hercegovina",
			"Botswana",
			"Brazílie",
			"Brunej",
			"Bulharsko",
			"Burkina Faso",
			"Burundi",
			"Čad",
			"Černá Hora",
			"Česká republika",
			"Čína",
			"Dánsko",
			"Dominika",
			"Dominikánská republika",
			"Džibutsko",
			"Egypt",
			"Ekvádor",
			"Eritrea",
			"Estonsko",
			"Etiopie",
			"Fidži",
			"Filipíny",
			"Finsko",
			"Francie",
			"Gabon",
			"Gambie",
			"Ghana",
			"Grenada",
			"Gruzie",
			"Guatemala",
			"Guinea",
			"Guinea-Bissau",
			"Guyana",
			"Haiti",
			"Honduras",
			"Chile",
			"Chorvatsko",
			"Indie",
			"Indonésie",
			"Irák",
			"Írán",
			"Irsko",
			"Island",
			"Itálie",
			"Izrael",
			"Jamajka",
			"Japonsko",
			"Jemen",
			"Jihoafrická republika",
			"Jižní Korea",
			"Jižní Súdán",
			"Jordánsko",
			"Kambodža",
			"Kamerun",
			"Kanada",
			"Kapverdy",
			"Katar",
			"Kazachstán",
			"Keňa",
			"Kiribati",
			"Kolumbie",
			"Komory",
			"Konžská republika",
			"Konžská demokratická republika",
			"Kostarika",
			"Kuba",
			"Kuvajt",
			"Kypr",
			"Kyrgyzstán",
			"Laos",
			"Lesotho",
			"Libanon",
			"Libérie",
			"Libye",
			"Lichtenštejnsko",
			"Litva",
			"Lotyšsko",
			"Lucembursko",
			"Madagaskar",
			"Maďarsko",
			"Malajsie",
			"Malawi",
			"Maledivy",
			"Mali",
			"Malta",
			"Maroko",
			"Marshallovy ostrovy",
			"Mauricius",
			"Mauritánie",
			"Mexiko",
			"Mikronésie",
			"Moldavsko",
			"Monako",
			"Mongolsko",
			"Mosambik",
			"Myanmar (Barma)",
			"Namibie",
			"Nauru",
			"Německo",
			"Nepál",
			"Niger",
			"Nigérie",
			"Nikaragua",
			"Nizozemsko",
			"Norsko",
			"Nový Zéland",
			"Omán",
			"Pákistán",
			"Palau",
			"Palestina",
			"Panama",
			"Papua Nová Guinea",
			"Paraguay",
			"Peru",
			"Pobřeží slonoviny",
			"Polsko",
			"Portugalsko",
			"Rakousko",
			"Rovníková Guinea",
			"Rumunsko",
			"Rusko",
			"Rwanda",
			"Řecko",
			"Salvador",
			"Samoa",
			"San Marino",
			"Saúdská Arábie",
			"Senegal",
			"Severní Korea",
			"Severní Makedonie",
			"Seychely",
			"Sierra Leone",
			"Singapur",
			"Slovensko",
			"Slovinsko",
			"Somálsko",
			"Spojené arabské emiráty",
			"Spojené království (Velká Británie)",
			"Spojené státy americké",
			"Srbsko",
			"Srí Lanka",
			"Středoafrická republika",
			"Súdán",
			"Surinam",
			"Svatá Lucie",
			"Svatý Kryštof a Nevis",
			"Svatý Tomáš a Princův ostrov",
			"Svatý Vincenc a Grenadiny",
			"Svazijsko",
			"Sýrie",
			"Šalomounovy ostrovy",
			"Španělsko",
			"Švédsko",
			"Švýcarsko",
			"Tádžikistán",
			"Taiwan",
			"Tanzanie",
			"Thajsko",
			"Togo",
			"Tonga",
			"Trinidad a Tobago",
			"Tunisko",
			"Turecko",
			"Turkmenistán",
			"Tuvalu",
			"Uganda",
			"Ukrajina",
			"Uruguay",
			"Uzbekistán",
			"Vanuatu",
			"Vatikán",
			"Venezuela",
			"Vietnam",
			"Východní Timor",
			"Zambie",
			"Zimbabwe"});
			this.comboBox1.Location = new System.Drawing.Point(146, 149);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(142, 21);
			this.comboBox1.TabIndex = 8;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1SelectedIndexChanged);
			this.comboBox1.Validating += new System.ComponentModel.CancelEventHandler(this.ComboBox1Validating);
			// 
			// radioButton1
			// 
			this.radioButton1.Location = new System.Drawing.Point(9, 19);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(104, 24);
			this.radioButton1.TabIndex = 9;
			this.radioButton1.Text = "Muž";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			this.radioButton2.Location = new System.Drawing.Point(9, 40);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(104, 24);
			this.radioButton2.TabIndex = 10;
			this.radioButton2.Text = "Žena";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// radioButton3
			// 
			this.radioButton3.Checked = true;
			this.radioButton3.Location = new System.Drawing.Point(9, 60);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(124, 24);
			this.radioButton3.TabIndex = 11;
			this.radioButton3.TabStop = true;
			this.radioButton3.Text = "Jiné/Nechi uvádět";
			this.radioButton3.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioButton1);
			this.groupBox1.Controls.Add(this.radioButton3);
			this.groupBox1.Controls.Add(this.radioButton2);
			this.groupBox1.Location = new System.Drawing.Point(148, 177);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(140, 96);
			this.groupBox1.TabIndex = 12;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Pohlaví";
			this.groupBox1.Validating += new System.ComponentModel.CancelEventHandler(this.GroupBox1Validating);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.pictureBox1.Location = new System.Drawing.Point(409, 379);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(86, 79);
			this.pictureBox1.TabIndex = 13;
			this.pictureBox1.TabStop = false;
			// 
			// RHScrollBar
			// 
			this.RHScrollBar.Location = new System.Drawing.Point(146, 389);
			this.RHScrollBar.Maximum = 264;
			this.RHScrollBar.Name = "RHScrollBar";
			this.RHScrollBar.Size = new System.Drawing.Size(141, 17);
			this.RHScrollBar.TabIndex = 15;
			this.RHScrollBar.ValueChanged += new System.EventHandler(this.HScrollBarValueChanged);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(24, 90);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(83, 23);
			this.label3.TabIndex = 16;
			this.label3.Text = "Datum narození";
			// 
			// checkedListBox1
			// 
			this.checkedListBox1.FormattingEnabled = true;
			this.checkedListBox1.Items.AddRange(new object[] {
			"Fotbal",
			"Volejbal",
			"Floorball",
			"Golf",
			"Hokej",
			"Basketball",
			"Baseball",
			"Tenis",
			"Biatlon"});
			this.checkedListBox1.Location = new System.Drawing.Point(147, 279);
			this.checkedListBox1.Name = "checkedListBox1";
			this.checkedListBox1.Size = new System.Drawing.Size(134, 94);
			this.checkedListBox1.TabIndex = 17;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(24, 118);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(113, 23);
			this.label4.TabIndex = 18;
			this.label4.Text = "Telefoní číslo (+420)";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(25, 148);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(113, 23);
			this.label5.TabIndex = 19;
			this.label5.Text = "Oblíbená destinace";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(29, 279);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(83, 23);
			this.label6.TabIndex = 20;
			this.label6.Text = "Oblíbený sport";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(24, 389);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(113, 23);
			this.label7.TabIndex = 21;
			this.label7.Text = "Vaše oblíbená barva";
			// 
			// linkLabel1
			// 
			this.linkLabel1.Location = new System.Drawing.Point(160, 466);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(100, 23);
			this.linkLabel1.TabIndex = 22;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "smlouvy";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1LinkClicked);
			// 
			// GHScrollBar
			// 
			this.GHScrollBar.Location = new System.Drawing.Point(147, 415);
			this.GHScrollBar.Maximum = 264;
			this.GHScrollBar.Name = "GHScrollBar";
			this.GHScrollBar.Size = new System.Drawing.Size(140, 17);
			this.GHScrollBar.TabIndex = 23;
			this.GHScrollBar.ValueChanged += new System.EventHandler(this.HScrollBarValueChanged);
			// 
			// BHScrollBar
			// 
			this.BHScrollBar.Location = new System.Drawing.Point(147, 442);
			this.BHScrollBar.Maximum = 264;
			this.BHScrollBar.Name = "BHScrollBar";
			this.BHScrollBar.Size = new System.Drawing.Size(140, 17);
			this.BHScrollBar.TabIndex = 24;
			this.BHScrollBar.ValueChanged += new System.EventHandler(this.HScrollBarValueChanged);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// Rlabel
			// 
			this.Rlabel.Location = new System.Drawing.Point(303, 396);
			this.Rlabel.Name = "Rlabel";
			this.Rlabel.Size = new System.Drawing.Size(63, 23);
			this.Rlabel.TabIndex = 25;
			this.Rlabel.Text = "0";
			// 
			// Glabel
			// 
			this.Glabel.Location = new System.Drawing.Point(303, 419);
			this.Glabel.Name = "Glabel";
			this.Glabel.Size = new System.Drawing.Size(63, 23);
			this.Glabel.TabIndex = 26;
			this.Glabel.Text = "0";
			// 
			// Blabel
			// 
			this.Blabel.Location = new System.Drawing.Point(303, 442);
			this.Blabel.Name = "Blabel";
			this.Blabel.Size = new System.Drawing.Size(63, 23);
			this.Blabel.TabIndex = 27;
			this.Blabel.Text = "0";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(636, 587);
			this.Controls.Add(this.Blabel);
			this.Controls.Add(this.Glabel);
			this.Controls.Add(this.Rlabel);
			this.Controls.Add(this.BHScrollBar);
			this.Controls.Add(this.GHScrollBar);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.checkedListBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.RHScrollBar);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dateTimePicker1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "Prvky forms";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
