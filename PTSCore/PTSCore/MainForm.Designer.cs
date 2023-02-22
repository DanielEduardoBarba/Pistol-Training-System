/*
 * Created by SharpDevelop.
 * User: danie
 * Date: 12/16/2019
 * Time: 6:48 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PTSCore
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
			this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
			this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
			this.availableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
			this.SearchSerial = new System.Windows.Forms.Timer(this.components);
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.licenseCheck = new System.Windows.Forms.Timer(this.components);
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.richTextBox2 = new System.Windows.Forms.RichTextBox();
			this.richTextBox3 = new System.Windows.Forms.RichTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.richTextBox4 = new System.Windows.Forms.RichTextBox();
			this.richTextBox5 = new System.Windows.Forms.RichTextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label16 = new System.Windows.Forms.Label();
			this.trackBar8 = new System.Windows.Forms.TrackBar();
			this.label17 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.trackBar6 = new System.Windows.Forms.TrackBar();
			this.label13 = new System.Windows.Forms.Label();
			this.trackBar5 = new System.Windows.Forms.TrackBar();
			this.label11 = new System.Windows.Forms.Label();
			this.trackBar3 = new System.Windows.Forms.TrackBar();
			this.label9 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.trackBar4 = new System.Windows.Forms.TrackBar();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.trackBar2 = new System.Windows.Forms.TrackBar();
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			this.label1 = new System.Windows.Forms.Label();
			this.trackBar7 = new System.Windows.Forms.TrackBar();
			this.GUIrichtextbox = new System.Windows.Forms.RichTextBox();
			this.richTextBox6 = new System.Windows.Forms.RichTextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.DUMP = new System.Windows.Forms.GroupBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.searchTargets = new System.Windows.Forms.Timer(this.components);
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.button28 = new System.Windows.Forms.Button();
			this.button27 = new System.Windows.Forms.Button();
			this.button26 = new System.Windows.Forms.Button();
			this.button25 = new System.Windows.Forms.Button();
			this.button24 = new System.Windows.Forms.Button();
			this.button23 = new System.Windows.Forms.Button();
			this.button22 = new System.Windows.Forms.Button();
			this.button21 = new System.Windows.Forms.Button();
			this.button20 = new System.Windows.Forms.Button();
			this.button19 = new System.Windows.Forms.Button();
			this.button18 = new System.Windows.Forms.Button();
			this.button17 = new System.Windows.Forms.Button();
			this.button16 = new System.Windows.Forms.Button();
			this.button15 = new System.Windows.Forms.Button();
			this.button14 = new System.Windows.Forms.Button();
			this.button13 = new System.Windows.Forms.Button();
			this.button12 = new System.Windows.Forms.Button();
			this.button11 = new System.Windows.Forms.Button();
			this.button10 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button29 = new System.Windows.Forms.Button();
			this.button31 = new System.Windows.Forms.Button();
			this.button32 = new System.Windows.Forms.Button();
			this.button30 = new System.Windows.Forms.Button();
			this.Simulation = new System.Windows.Forms.Timer(this.components);
			this.delayTimer = new System.Windows.Forms.Timer(this.components);
			this.setIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripTextBox3 = new System.Windows.Forms.ToolStripTextBox();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.fROMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripTextBox4 = new System.Windows.Forms.ToolStripTextBox();
			this.sETNEWIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar8)).BeginInit();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar7)).BeginInit();
			this.DUMP.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.BackColor = System.Drawing.Color.LightGray;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripDropDownButton1,
									this.toolStripDropDownButton2,
									this.toolStripButton1,
									this.toolStripButton2});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(543, 25);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripDropDownButton1
			// 
			this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.connectToolStripMenuItem});
			this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
			this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
			this.toolStripDropDownButton1.Size = new System.Drawing.Size(44, 22);
			this.toolStripDropDownButton1.Text = "Base";
			this.toolStripDropDownButton1.DropDownClosed += new System.EventHandler(this.ToolStripDropDownButton1DropDownClosed);
			// 
			// connectToolStripMenuItem
			// 
			this.connectToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
			this.connectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripMenuItem1,
									this.toolStripSeparator1,
									this.toolStripTextBox1,
									this.toolStripSeparator2,
									this.toolStripTextBox2,
									this.manualToolStripMenuItem});
			this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
			this.connectToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.connectToolStripMenuItem.Text = "Connect";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(210, 22);
			this.toolStripMenuItem1.Text = "Search";
			this.toolStripMenuItem1.Click += new System.EventHandler(this.ToolStripMenuItem1Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(207, 6);
			// 
			// toolStripTextBox1
			// 
			this.toolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.toolStripTextBox1.Name = "toolStripTextBox1";
			this.toolStripTextBox1.Size = new System.Drawing.Size(150, 23);
			this.toolStripTextBox1.Text = "-";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(207, 6);
			// 
			// toolStripTextBox2
			// 
			this.toolStripTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.toolStripTextBox2.Name = "toolStripTextBox2";
			this.toolStripTextBox2.Size = new System.Drawing.Size(150, 23);
			this.toolStripTextBox2.Text = "-";
			this.toolStripTextBox2.TextChanged += new System.EventHandler(this.ToolStripTextBox2TextChanged);
			// 
			// manualToolStripMenuItem
			// 
			this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
			this.manualToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
			this.manualToolStripMenuItem.Text = "Manual";
			this.manualToolStripMenuItem.Click += new System.EventHandler(this.ManualToolStripMenuItemClick);
			// 
			// toolStripDropDownButton2
			// 
			this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.availableToolStripMenuItem,
									this.setIDToolStripMenuItem});
			this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
			this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
			this.toolStripDropDownButton2.Size = new System.Drawing.Size(52, 22);
			this.toolStripDropDownButton2.Text = "Target";
			this.toolStripDropDownButton2.Click += new System.EventHandler(this.ToolStripDropDownButton2Click);
			// 
			// availableToolStripMenuItem
			// 
			this.availableToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.searchToolStripMenuItem,
									this.toolStripSeparator3,
									this.toolStripComboBox1});
			this.availableToolStripMenuItem.Name = "availableToolStripMenuItem";
			this.availableToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.availableToolStripMenuItem.Text = "Available";
			// 
			// searchToolStripMenuItem
			// 
			this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
			this.searchToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
			this.searchToolStripMenuItem.Text = "Search";
			this.searchToolStripMenuItem.Click += new System.EventHandler(this.SearchToolStripMenuItemClick);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(178, 6);
			// 
			// toolStripComboBox1
			// 
			this.toolStripComboBox1.Name = "toolStripComboBox1";
			this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
			this.toolStripComboBox1.Text = "-";
			this.toolStripComboBox1.TextChanged += new System.EventHandler(this.ToolStripComboBox1TextChanged);
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(58, 22);
			this.toolStripButton1.Text = "REFRESH";
			this.toolStripButton1.Click += new System.EventHandler(this.ToolStripButton1Click);
			// 
			// toolStripButton2
			// 
			this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
			this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton2.Name = "toolStripButton2";
			this.toolStripButton2.Size = new System.Drawing.Size(78, 22);
			this.toolStripButton2.Text = "Quick SETUP";
			this.toolStripButton2.Click += new System.EventHandler(this.ToolStripButton2Click);
			// 
			// serialPort1
			// 
			this.serialPort1.BaudRate = 115200;
			this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort1DataReceived);
			// 
			// SearchSerial
			// 
			this.SearchSerial.Interval = 10;
			this.SearchSerial.Tick += new System.EventHandler(this.SearchSerialTick);
			// 
			// richTextBox1
			// 
			this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.richTextBox1.Location = new System.Drawing.Point(3, 55);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(379, 383);
			this.richTextBox1.TabIndex = 2;
			this.richTextBox1.Text = "";
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button1.BackColor = System.Drawing.Color.LightGray;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(12, 647);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(125, 45);
			this.button1.TabIndex = 4;
			this.button1.Text = "Training";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// licenseCheck
			// 
			this.licenseCheck.Tick += new System.EventHandler(this.LicenseCheckTick);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(6, 87);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(46, 20);
			this.textBox1.TabIndex = 1;
			// 
			// richTextBox2
			// 
			this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.richTextBox2.Location = new System.Drawing.Point(150, 32);
			this.richTextBox2.Name = "richTextBox2";
			this.richTextBox2.Size = new System.Drawing.Size(69, 321);
			this.richTextBox2.TabIndex = 7;
			this.richTextBox2.Text = "";
			// 
			// richTextBox3
			// 
			this.richTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.richTextBox3.Location = new System.Drawing.Point(225, 32);
			this.richTextBox3.Name = "richTextBox3";
			this.richTextBox3.Size = new System.Drawing.Size(62, 321);
			this.richTextBox3.TabIndex = 8;
			this.richTextBox3.Text = "";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(6, 29);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(379, 23);
			this.label2.TabIndex = 9;
			this.label2.Text = "ID          Time          Past Time     Lives         Condition ";
			this.label2.Click += new System.EventHandler(this.Label2Click);
			// 
			// richTextBox4
			// 
			this.richTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.richTextBox4.Location = new System.Drawing.Point(293, 32);
			this.richTextBox4.Name = "richTextBox4";
			this.richTextBox4.Size = new System.Drawing.Size(93, 321);
			this.richTextBox4.TabIndex = 10;
			this.richTextBox4.Text = "";
			// 
			// richTextBox5
			// 
			this.richTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.richTextBox5.Location = new System.Drawing.Point(390, 32);
			this.richTextBox5.Name = "richTextBox5";
			this.richTextBox5.Size = new System.Drawing.Size(61, 321);
			this.richTextBox5.TabIndex = 11;
			this.richTextBox5.Text = "";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label16);
			this.groupBox2.Controls.Add(this.trackBar8);
			this.groupBox2.Controls.Add(this.label17);
			this.groupBox2.Controls.Add(this.label14);
			this.groupBox2.Controls.Add(this.label15);
			this.groupBox2.Controls.Add(this.groupBox4);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.trackBar4);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.trackBar2);
			this.groupBox2.Controls.Add(this.trackBar1);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.richTextBox1);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.trackBar7);
			this.groupBox2.Location = new System.Drawing.Point(12, 28);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(527, 528);
			this.groupBox2.TabIndex = 12;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Target Feedback";
			this.groupBox2.Enter += new System.EventHandler(this.GroupBox2Enter);
			// 
			// label16
			// 
			this.label16.BackColor = System.Drawing.Color.Black;
			this.label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label16.Location = new System.Drawing.Point(473, 52);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(52, 23);
			this.label16.TabIndex = 47;
			this.label16.Text = "0.0";
			this.label16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.label16.Click += new System.EventHandler(this.Label16Click);
			// 
			// trackBar8
			// 
			this.trackBar8.LargeChange = 1;
			this.trackBar8.Location = new System.Drawing.Point(391, 73);
			this.trackBar8.Maximum = 10000;
			this.trackBar8.Name = "trackBar8";
			this.trackBar8.Size = new System.Drawing.Size(130, 45);
			this.trackBar8.TabIndex = 46;
			this.trackBar8.Scroll += new System.EventHandler(this.TrackBar8Scroll);
			// 
			// label17
			// 
			this.label17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label17.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.Location = new System.Drawing.Point(393, 52);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(85, 18);
			this.label17.TabIndex = 45;
			this.label17.Text = "Initial(ms):";
			this.label17.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label14
			// 
			this.label14.BackColor = System.Drawing.Color.Black;
			this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label14.Location = new System.Drawing.Point(289, 446);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(58, 23);
			this.label14.TabIndex = 37;
			this.label14.Text = "100";
			this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label15
			// 
			this.label15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label15.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(130, 449);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(153, 18);
			this.label15.TabIndex = 35;
			this.label15.Text = "Unpredictability:  %";
			this.label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.label10);
			this.groupBox4.Controls.Add(this.label12);
			this.groupBox4.Controls.Add(this.label4);
			this.groupBox4.Controls.Add(this.label8);
			this.groupBox4.Controls.Add(this.trackBar6);
			this.groupBox4.Controls.Add(this.label13);
			this.groupBox4.Controls.Add(this.trackBar5);
			this.groupBox4.Controls.Add(this.label11);
			this.groupBox4.Controls.Add(this.trackBar3);
			this.groupBox4.Location = new System.Drawing.Point(388, 310);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(139, 214);
			this.groupBox4.TabIndex = 29;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Effects";
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.Black;
			this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label10.Location = new System.Drawing.Point(81, 71);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(58, 23);
			this.label10.TabIndex = 31;
			this.label10.Text = "50";
			this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.Black;
			this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label12.Location = new System.Drawing.Point(81, 134);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(58, 23);
			this.label12.TabIndex = 34;
			this.label12.Text = "50";
			this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.label12.Click += new System.EventHandler(this.Label12Click);
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Black;
			this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label4.Location = new System.Drawing.Point(81, 19);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(58, 23);
			this.label4.TabIndex = 28;
			this.label4.Text = "20";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label8
			// 
			this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label8.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(6, 139);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(80, 18);
			this.label8.TabIndex = 24;
			this.label8.Text = "Resist %";
			this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// trackBar6
			// 
			this.trackBar6.LargeChange = 1;
			this.trackBar6.Location = new System.Drawing.Point(4, 97);
			this.trackBar6.Maximum = 100;
			this.trackBar6.Name = "trackBar6";
			this.trackBar6.Size = new System.Drawing.Size(130, 45);
			this.trackBar6.TabIndex = 33;
			this.trackBar6.Scroll += new System.EventHandler(this.TrackBar6Scroll);
			// 
			// label13
			// 
			this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label13.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(-2, 76);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(87, 18);
			this.label13.TabIndex = 32;
			this.label13.Text = "Bystand %";
			this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// trackBar5
			// 
			this.trackBar5.LargeChange = 1;
			this.trackBar5.Location = new System.Drawing.Point(4, 40);
			this.trackBar5.Maximum = 100;
			this.trackBar5.Name = "trackBar5";
			this.trackBar5.Size = new System.Drawing.Size(130, 45);
			this.trackBar5.TabIndex = 30;
			this.trackBar5.Scroll += new System.EventHandler(this.TrackBar5Scroll);
			// 
			// label11
			// 
			this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label11.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(6, 19);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(84, 18);
			this.label11.TabIndex = 29;
			this.label11.Text = "Bluff %";
			this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// trackBar3
			// 
			this.trackBar3.LargeChange = 1;
			this.trackBar3.Location = new System.Drawing.Point(4, 160);
			this.trackBar3.Maximum = 100;
			this.trackBar3.Name = "trackBar3";
			this.trackBar3.Size = new System.Drawing.Size(130, 45);
			this.trackBar3.TabIndex = 26;
			this.trackBar3.Scroll += new System.EventHandler(this.TrackBar3Scroll);
			// 
			// label9
			// 
			this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label9.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(388, 238);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(85, 18);
			this.label9.TabIndex = 23;
			this.label9.Text = "Lives:";
			this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label3
			// 
			this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label3.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(398, 181);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(68, 18);
			this.label3.TabIndex = 13;
			this.label3.Text = "Targets:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.label3.Click += new System.EventHandler(this.Label3Click);
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Black;
			this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label5.Location = new System.Drawing.Point(469, 121);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(52, 23);
			this.label5.TabIndex = 27;
			this.label5.Text = "1000";
			this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// trackBar4
			// 
			this.trackBar4.LargeChange = 1;
			this.trackBar4.Location = new System.Drawing.Point(392, 259);
			this.trackBar4.Maximum = 5;
			this.trackBar4.Name = "trackBar4";
			this.trackBar4.Size = new System.Drawing.Size(130, 45);
			this.trackBar4.TabIndex = 25;
			this.trackBar4.Scroll += new System.EventHandler(this.TrackBar4Scroll);
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Black;
			this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label7.Location = new System.Drawing.Point(469, 233);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(52, 23);
			this.label7.TabIndex = 22;
			this.label7.Text = "3";
			this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Black;
			this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label6.Location = new System.Drawing.Point(469, 176);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(52, 23);
			this.label6.TabIndex = 21;
			this.label6.Text = "10";
			this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// trackBar2
			// 
			this.trackBar2.LargeChange = 1;
			this.trackBar2.Location = new System.Drawing.Point(391, 202);
			this.trackBar2.Maximum = 20;
			this.trackBar2.Name = "trackBar2";
			this.trackBar2.Size = new System.Drawing.Size(130, 45);
			this.trackBar2.TabIndex = 20;
			this.trackBar2.Scroll += new System.EventHandler(this.TrackBar2Scroll);
			// 
			// trackBar1
			// 
			this.trackBar1.LargeChange = 1;
			this.trackBar1.Location = new System.Drawing.Point(392, 142);
			this.trackBar1.Maximum = 1000;
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(130, 45);
			this.trackBar1.TabIndex = 19;
			this.trackBar1.Scroll += new System.EventHandler(this.TrackBar1Scroll);
			// 
			// label1
			// 
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(388, 121);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(85, 18);
			this.label1.TabIndex = 3;
			this.label1.Text = "Delay(ms):";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// trackBar7
			// 
			this.trackBar7.LargeChange = 1;
			this.trackBar7.Location = new System.Drawing.Point(6, 477);
			this.trackBar7.Maximum = 100;
			this.trackBar7.Name = "trackBar7";
			this.trackBar7.Size = new System.Drawing.Size(345, 45);
			this.trackBar7.TabIndex = 36;
			this.trackBar7.Scroll += new System.EventHandler(this.TrackBar7Scroll);
			// 
			// GUIrichtextbox
			// 
			this.GUIrichtextbox.Location = new System.Drawing.Point(58, 15);
			this.GUIrichtextbox.Name = "GUIrichtextbox";
			this.GUIrichtextbox.Size = new System.Drawing.Size(86, 39);
			this.GUIrichtextbox.TabIndex = 43;
			this.GUIrichtextbox.Text = "incoming data gui handling";
			this.GUIrichtextbox.TextChanged += new System.EventHandler(this.GUIrichtextboxTextChanged);
			// 
			// richTextBox6
			// 
			this.richTextBox6.Location = new System.Drawing.Point(8, 15);
			this.richTextBox6.Name = "richTextBox6";
			this.richTextBox6.Size = new System.Drawing.Size(44, 44);
			this.richTextBox6.TabIndex = 44;
			this.richTextBox6.Text = "debug feed for output";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(0, 265);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 41;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// DUMP
			// 
			this.DUMP.Controls.Add(this.GUIrichtextbox);
			this.DUMP.Controls.Add(this.button2);
			this.DUMP.Controls.Add(this.textBox5);
			this.DUMP.Controls.Add(this.textBox4);
			this.DUMP.Controls.Add(this.numericUpDown2);
			this.DUMP.Controls.Add(this.richTextBox6);
			this.DUMP.Controls.Add(this.numericUpDown1);
			this.DUMP.Controls.Add(this.textBox3);
			this.DUMP.Controls.Add(this.textBox1);
			this.DUMP.Controls.Add(this.textBox2);
			this.DUMP.Controls.Add(this.richTextBox5);
			this.DUMP.Controls.Add(this.richTextBox3);
			this.DUMP.Controls.Add(this.richTextBox2);
			this.DUMP.Controls.Add(this.richTextBox4);
			this.DUMP.Location = new System.Drawing.Point(545, 57);
			this.DUMP.Name = "DUMP";
			this.DUMP.Size = new System.Drawing.Size(542, 366);
			this.DUMP.TabIndex = 44;
			this.DUMP.TabStop = false;
			this.DUMP.Text = "DUMP";
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(0, 182);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(110, 20);
			this.textBox5.TabIndex = 42;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(58, 87);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(65, 20);
			this.textBox4.TabIndex = 40;
			// 
			// numericUpDown2
			// 
			this.numericUpDown2.Location = new System.Drawing.Point(8, 61);
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Size = new System.Drawing.Size(44, 20);
			this.numericUpDown2.TabIndex = 14;
			this.numericUpDown2.Value = new decimal(new int[] {
									1,
									0,
									0,
									0});
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(60, 60);
			this.numericUpDown1.Maximum = new decimal(new int[] {
									30,
									0,
									0,
									0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(65, 20);
			this.numericUpDown1.TabIndex = 12;
			this.numericUpDown1.Value = new decimal(new int[] {
									3,
									0,
									0,
									0});
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(6, 139);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(46, 20);
			this.textBox3.TabIndex = 39;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(6, 113);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(46, 20);
			this.textBox2.TabIndex = 38;
			// 
			// groupBox3
			// 
			this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.groupBox3.Controls.Add(this.button28);
			this.groupBox3.Controls.Add(this.button27);
			this.groupBox3.Controls.Add(this.button26);
			this.groupBox3.Controls.Add(this.button25);
			this.groupBox3.Controls.Add(this.button24);
			this.groupBox3.Controls.Add(this.button23);
			this.groupBox3.Controls.Add(this.button22);
			this.groupBox3.Controls.Add(this.button21);
			this.groupBox3.Controls.Add(this.button20);
			this.groupBox3.Controls.Add(this.button19);
			this.groupBox3.Controls.Add(this.button18);
			this.groupBox3.Controls.Add(this.button17);
			this.groupBox3.Controls.Add(this.button16);
			this.groupBox3.Controls.Add(this.button15);
			this.groupBox3.Controls.Add(this.button14);
			this.groupBox3.Controls.Add(this.button13);
			this.groupBox3.Controls.Add(this.button12);
			this.groupBox3.Controls.Add(this.button11);
			this.groupBox3.Controls.Add(this.button10);
			this.groupBox3.Controls.Add(this.button9);
			this.groupBox3.Controls.Add(this.button8);
			this.groupBox3.Controls.Add(this.button7);
			this.groupBox3.Controls.Add(this.button6);
			this.groupBox3.Controls.Add(this.button5);
			this.groupBox3.Controls.Add(this.button4);
			this.groupBox3.Controls.Add(this.button3);
			this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox3.Location = new System.Drawing.Point(92, 562);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(358, 83);
			this.groupBox3.TabIndex = 13;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Range";
			this.groupBox3.Enter += new System.EventHandler(this.GroupBox3Enter);
			// 
			// button28
			// 
			this.button28.BackColor = System.Drawing.Color.LightGray;
			this.button28.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button28.Location = new System.Drawing.Point(318, 45);
			this.button28.Name = "button28";
			this.button28.Size = new System.Drawing.Size(27, 30);
			this.button28.TabIndex = 25;
			this.button28.Text = "Z";
			this.button28.UseVisualStyleBackColor = false;
			this.button28.Click += new System.EventHandler(this.Button28Click);
			// 
			// button27
			// 
			this.button27.BackColor = System.Drawing.Color.LightGray;
			this.button27.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button27.Location = new System.Drawing.Point(292, 45);
			this.button27.Name = "button27";
			this.button27.Size = new System.Drawing.Size(27, 30);
			this.button27.TabIndex = 24;
			this.button27.Text = "Y";
			this.button27.UseVisualStyleBackColor = false;
			this.button27.Click += new System.EventHandler(this.Button27Click);
			// 
			// button26
			// 
			this.button26.BackColor = System.Drawing.Color.LightGray;
			this.button26.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button26.Location = new System.Drawing.Point(266, 45);
			this.button26.Name = "button26";
			this.button26.Size = new System.Drawing.Size(27, 30);
			this.button26.TabIndex = 23;
			this.button26.Text = "X";
			this.button26.UseVisualStyleBackColor = false;
			this.button26.Click += new System.EventHandler(this.Button26Click);
			// 
			// button25
			// 
			this.button25.BackColor = System.Drawing.Color.LightGray;
			this.button25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button25.Location = new System.Drawing.Point(240, 45);
			this.button25.Name = "button25";
			this.button25.Size = new System.Drawing.Size(27, 30);
			this.button25.TabIndex = 22;
			this.button25.Text = "W";
			this.button25.UseVisualStyleBackColor = false;
			this.button25.Click += new System.EventHandler(this.Button25Click);
			// 
			// button24
			// 
			this.button24.BackColor = System.Drawing.Color.LightGray;
			this.button24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button24.Location = new System.Drawing.Point(214, 45);
			this.button24.Name = "button24";
			this.button24.Size = new System.Drawing.Size(27, 30);
			this.button24.TabIndex = 21;
			this.button24.Text = "V";
			this.button24.UseVisualStyleBackColor = false;
			this.button24.Click += new System.EventHandler(this.Button24Click);
			// 
			// button23
			// 
			this.button23.BackColor = System.Drawing.Color.LightGray;
			this.button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button23.Location = new System.Drawing.Point(188, 45);
			this.button23.Name = "button23";
			this.button23.Size = new System.Drawing.Size(27, 30);
			this.button23.TabIndex = 20;
			this.button23.Text = "U";
			this.button23.UseVisualStyleBackColor = false;
			this.button23.Click += new System.EventHandler(this.Button23Click);
			// 
			// button22
			// 
			this.button22.BackColor = System.Drawing.Color.LightGray;
			this.button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button22.Location = new System.Drawing.Point(162, 45);
			this.button22.Name = "button22";
			this.button22.Size = new System.Drawing.Size(27, 30);
			this.button22.TabIndex = 19;
			this.button22.Text = "T";
			this.button22.UseVisualStyleBackColor = false;
			this.button22.Click += new System.EventHandler(this.Button22Click);
			// 
			// button21
			// 
			this.button21.BackColor = System.Drawing.Color.LightGray;
			this.button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button21.Location = new System.Drawing.Point(136, 45);
			this.button21.Name = "button21";
			this.button21.Size = new System.Drawing.Size(27, 30);
			this.button21.TabIndex = 18;
			this.button21.Text = "S";
			this.button21.UseVisualStyleBackColor = false;
			this.button21.Click += new System.EventHandler(this.Button21Click);
			// 
			// button20
			// 
			this.button20.BackColor = System.Drawing.Color.LightGray;
			this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button20.Location = new System.Drawing.Point(110, 45);
			this.button20.Name = "button20";
			this.button20.Size = new System.Drawing.Size(27, 30);
			this.button20.TabIndex = 17;
			this.button20.Text = "R";
			this.button20.UseVisualStyleBackColor = false;
			this.button20.Click += new System.EventHandler(this.Button20Click);
			// 
			// button19
			// 
			this.button19.BackColor = System.Drawing.Color.LightGray;
			this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button19.Location = new System.Drawing.Point(84, 45);
			this.button19.Name = "button19";
			this.button19.Size = new System.Drawing.Size(27, 30);
			this.button19.TabIndex = 16;
			this.button19.Text = "Q";
			this.button19.UseVisualStyleBackColor = false;
			this.button19.Click += new System.EventHandler(this.Button19Click);
			// 
			// button18
			// 
			this.button18.BackColor = System.Drawing.Color.LightGray;
			this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button18.Location = new System.Drawing.Point(58, 45);
			this.button18.Name = "button18";
			this.button18.Size = new System.Drawing.Size(27, 30);
			this.button18.TabIndex = 15;
			this.button18.Text = "P";
			this.button18.UseVisualStyleBackColor = false;
			this.button18.Click += new System.EventHandler(this.Button18Click);
			// 
			// button17
			// 
			this.button17.BackColor = System.Drawing.Color.LightGray;
			this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button17.Location = new System.Drawing.Point(32, 45);
			this.button17.Name = "button17";
			this.button17.Size = new System.Drawing.Size(27, 30);
			this.button17.TabIndex = 14;
			this.button17.Text = "O";
			this.button17.UseVisualStyleBackColor = false;
			this.button17.Click += new System.EventHandler(this.Button17Click);
			// 
			// button16
			// 
			this.button16.BackColor = System.Drawing.Color.LightGray;
			this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button16.Location = new System.Drawing.Point(7, 45);
			this.button16.Name = "button16";
			this.button16.Size = new System.Drawing.Size(27, 30);
			this.button16.TabIndex = 13;
			this.button16.Text = "N";
			this.button16.UseVisualStyleBackColor = false;
			this.button16.Click += new System.EventHandler(this.Button16Click);
			// 
			// button15
			// 
			this.button15.BackColor = System.Drawing.Color.LightGray;
			this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button15.Location = new System.Drawing.Point(318, 16);
			this.button15.Name = "button15";
			this.button15.Size = new System.Drawing.Size(27, 30);
			this.button15.TabIndex = 12;
			this.button15.Text = "M";
			this.button15.UseVisualStyleBackColor = false;
			this.button15.Click += new System.EventHandler(this.Button15Click);
			// 
			// button14
			// 
			this.button14.BackColor = System.Drawing.Color.LightGray;
			this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button14.Location = new System.Drawing.Point(292, 16);
			this.button14.Name = "button14";
			this.button14.Size = new System.Drawing.Size(27, 30);
			this.button14.TabIndex = 11;
			this.button14.Text = "L";
			this.button14.UseVisualStyleBackColor = false;
			this.button14.Click += new System.EventHandler(this.Button14Click);
			// 
			// button13
			// 
			this.button13.BackColor = System.Drawing.Color.LightGray;
			this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button13.Location = new System.Drawing.Point(266, 16);
			this.button13.Name = "button13";
			this.button13.Size = new System.Drawing.Size(27, 30);
			this.button13.TabIndex = 10;
			this.button13.Text = "K";
			this.button13.UseVisualStyleBackColor = false;
			this.button13.Click += new System.EventHandler(this.Button13Click);
			// 
			// button12
			// 
			this.button12.BackColor = System.Drawing.Color.LightGray;
			this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button12.Location = new System.Drawing.Point(240, 16);
			this.button12.Name = "button12";
			this.button12.Size = new System.Drawing.Size(27, 30);
			this.button12.TabIndex = 9;
			this.button12.Text = "J";
			this.button12.UseVisualStyleBackColor = false;
			this.button12.Click += new System.EventHandler(this.Button12Click);
			// 
			// button11
			// 
			this.button11.BackColor = System.Drawing.Color.LightGray;
			this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button11.Location = new System.Drawing.Point(214, 16);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(27, 30);
			this.button11.TabIndex = 8;
			this.button11.Text = "I";
			this.button11.UseVisualStyleBackColor = false;
			this.button11.Click += new System.EventHandler(this.Button11Click);
			// 
			// button10
			// 
			this.button10.BackColor = System.Drawing.Color.LightGray;
			this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button10.Location = new System.Drawing.Point(188, 16);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(27, 30);
			this.button10.TabIndex = 7;
			this.button10.Text = "H";
			this.button10.UseVisualStyleBackColor = false;
			this.button10.Click += new System.EventHandler(this.Button10Click);
			// 
			// button9
			// 
			this.button9.BackColor = System.Drawing.Color.LightGray;
			this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button9.Location = new System.Drawing.Point(162, 16);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(27, 30);
			this.button9.TabIndex = 6;
			this.button9.Text = "G";
			this.button9.UseVisualStyleBackColor = false;
			this.button9.Click += new System.EventHandler(this.Button9Click);
			// 
			// button8
			// 
			this.button8.BackColor = System.Drawing.Color.LightGray;
			this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button8.Location = new System.Drawing.Point(136, 16);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(27, 30);
			this.button8.TabIndex = 5;
			this.button8.Text = "F";
			this.button8.UseVisualStyleBackColor = false;
			this.button8.Click += new System.EventHandler(this.Button8Click);
			// 
			// button7
			// 
			this.button7.BackColor = System.Drawing.Color.LightGray;
			this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button7.Location = new System.Drawing.Point(110, 16);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(27, 30);
			this.button7.TabIndex = 4;
			this.button7.Text = "E";
			this.button7.UseVisualStyleBackColor = false;
			this.button7.Click += new System.EventHandler(this.Button7Click);
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.LightGray;
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button6.Location = new System.Drawing.Point(84, 16);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(27, 30);
			this.button6.TabIndex = 3;
			this.button6.Text = "D";
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new System.EventHandler(this.Button6Click);
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.LightGray;
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Location = new System.Drawing.Point(58, 16);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(27, 30);
			this.button5.TabIndex = 2;
			this.button5.Text = "C";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.LightGray;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Location = new System.Drawing.Point(32, 16);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(27, 30);
			this.button4.TabIndex = 1;
			this.button4.Text = "B";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.LightGray;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Location = new System.Drawing.Point(7, 16);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(27, 30);
			this.button3.TabIndex = 0;
			this.button3.Text = "A";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button29
			// 
			this.button29.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button29.BackColor = System.Drawing.Color.LightGray;
			this.button29.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button29.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button29.Location = new System.Drawing.Point(414, 647);
			this.button29.Name = "button29";
			this.button29.Size = new System.Drawing.Size(125, 45);
			this.button29.TabIndex = 14;
			this.button29.Text = "Simulation";
			this.button29.UseVisualStyleBackColor = false;
			this.button29.Click += new System.EventHandler(this.Button29Click);
			// 
			// button31
			// 
			this.button31.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button31.BackColor = System.Drawing.Color.LightGray;
			this.button31.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button31.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button31.Location = new System.Drawing.Point(12, 578);
			this.button31.Name = "button31";
			this.button31.Size = new System.Drawing.Size(58, 63);
			this.button31.TabIndex = 16;
			this.button31.Text = "<<<";
			this.button31.UseVisualStyleBackColor = false;
			// 
			// button32
			// 
			this.button32.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button32.BackColor = System.Drawing.Color.LightGray;
			this.button32.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button32.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button32.Location = new System.Drawing.Point(481, 578);
			this.button32.Name = "button32";
			this.button32.Size = new System.Drawing.Size(58, 59);
			this.button32.TabIndex = 17;
			this.button32.Text = ">>>";
			this.button32.UseVisualStyleBackColor = false;
			// 
			// button30
			// 
			this.button30.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button30.BackColor = System.Drawing.Color.LightGray;
			this.button30.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button30.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button30.Location = new System.Drawing.Point(150, 647);
			this.button30.Name = "button30";
			this.button30.Size = new System.Drawing.Size(252, 45);
			this.button30.TabIndex = 18;
			this.button30.UseVisualStyleBackColor = false;
			this.button30.Click += new System.EventHandler(this.Button30Click);
			// 
			// Simulation
			// 
			this.Simulation.Interval = 5;
			this.Simulation.Tick += new System.EventHandler(this.SimulationTick);
			// 
			// delayTimer
			// 
			this.delayTimer.Interval = 3000;
			this.delayTimer.Tick += new System.EventHandler(this.DelayTimerTick);
			// 
			// setIDToolStripMenuItem
			// 
			this.setIDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.fROMToolStripMenuItem,
									this.toolStripTextBox3,
									this.toolStripSeparator4,
									this.tOToolStripMenuItem,
									this.toolStripTextBox4,
									this.sETNEWIDToolStripMenuItem});
			this.setIDToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
			this.setIDToolStripMenuItem.Name = "setIDToolStripMenuItem";
			this.setIDToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.setIDToolStripMenuItem.Text = "Set ID";
			// 
			// toolStripTextBox3
			// 
			this.toolStripTextBox3.BackColor = System.Drawing.Color.LightGray;
			this.toolStripTextBox3.Name = "toolStripTextBox3";
			this.toolStripTextBox3.Size = new System.Drawing.Size(100, 23);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(157, 6);
			// 
			// fROMToolStripMenuItem
			// 
			this.fROMToolStripMenuItem.Name = "fROMToolStripMenuItem";
			this.fROMToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
			this.fROMToolStripMenuItem.Text = "FROM:";
			// 
			// tOToolStripMenuItem
			// 
			this.tOToolStripMenuItem.Name = "tOToolStripMenuItem";
			this.tOToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
			this.tOToolStripMenuItem.Text = "TO:";
			// 
			// toolStripTextBox4
			// 
			this.toolStripTextBox4.BackColor = System.Drawing.Color.LightGray;
			this.toolStripTextBox4.Name = "toolStripTextBox4";
			this.toolStripTextBox4.Size = new System.Drawing.Size(100, 23);
			// 
			// sETNEWIDToolStripMenuItem
			// 
			this.sETNEWIDToolStripMenuItem.Name = "sETNEWIDToolStripMenuItem";
			this.sETNEWIDToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
			this.sETNEWIDToolStripMenuItem.Text = "SET NEW ID";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(543, 714);
			this.Controls.Add(this.button30);
			this.Controls.Add(this.button32);
			this.Controls.Add(this.button31);
			this.Controls.Add(this.DUMP);
			this.Controls.Add(this.button29);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.toolStrip1);
			this.Name = "MainForm";
			this.Text = "PTSCore";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar8)).EndInit();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar7)).EndInit();
			this.DUMP.ResumeLayout(false);
			this.DUMP.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem sETNEWIDToolStripMenuItem;
		private System.Windows.Forms.ToolStripTextBox toolStripTextBox4;
		private System.Windows.Forms.ToolStripMenuItem tOToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripTextBox toolStripTextBox3;
		private System.Windows.Forms.ToolStripMenuItem fROMToolStripMenuItem;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TrackBar trackBar8;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.GroupBox DUMP;
		private System.Windows.Forms.RichTextBox richTextBox6;
		private System.Windows.Forms.RichTextBox GUIrichtextbox;
		private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Timer delayTimer;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Timer Simulation;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TrackBar trackBar7;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TrackBar trackBar4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TrackBar trackBar3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TrackBar trackBar5;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TrackBar trackBar6;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TrackBar trackBar2;
		private System.Windows.Forms.TrackBar trackBar1;
		private System.Windows.Forms.Button button30;
		private System.Windows.Forms.Button button32;
		private System.Windows.Forms.Button button31;
		private System.Windows.Forms.Button button29;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.Button button14;
		private System.Windows.Forms.Button button15;
		private System.Windows.Forms.Button button16;
		private System.Windows.Forms.Button button17;
		private System.Windows.Forms.Button button18;
		private System.Windows.Forms.Button button19;
		private System.Windows.Forms.Button button20;
		private System.Windows.Forms.Button button21;
		private System.Windows.Forms.Button button22;
		private System.Windows.Forms.Button button23;
		private System.Windows.Forms.Button button24;
		private System.Windows.Forms.Button button25;
		private System.Windows.Forms.Button button26;
		private System.Windows.Forms.Button button27;
		private System.Windows.Forms.Button button28;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Button button11;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.ToolStripButton toolStripButton2;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.Timer searchTargets;
		private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem availableToolStripMenuItem;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.NumericUpDown numericUpDown2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RichTextBox richTextBox5;
		private System.Windows.Forms.RichTextBox richTextBox4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RichTextBox richTextBox3;
		private System.Windows.Forms.RichTextBox richTextBox2;
		private System.Windows.Forms.Timer licenseCheck;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
		private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
		private System.Windows.Forms.Timer SearchSerial;
		private System.IO.Ports.SerialPort serialPort1;
		private System.Windows.Forms.ToolStripMenuItem setIDToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
		private System.Windows.Forms.ToolStrip toolStrip1;
	}
}
