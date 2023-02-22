/*
 * Created by SharpDevelop.
 * User: danie
 * Date: 12/16/2019
 * Time: 6:48 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Text.RegularExpressions;
using System.Media;
using System.Diagnostics;




namespace PTSCore
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			button1.Enabled=false;
			button29.Enabled=false;
			button30.Enabled=false;
			
			Rfresh=1;
			SearchSerial.Start();
			

			
		}
		Stopwatch stopWatch = new Stopwatch();
		Stopwatch totalStopWatch = new Stopwatch();
		
		void ToolStripComboBox1Click(object sender, EventArgs e)
		{
			
		}
		
		void ToolStripTextBox1Click(object sender, EventArgs e)
		{
			
			
		}
		
		int portnumber=0;
		void SearchSerialTick(object sender, EventArgs e)
		{
			

			
			
			
			SearchSerial.Interval=10;
			
			serialPort1.Close();
			serialPort1.PortName="COM"+Convert.ToString(portnumber);
			
			//textBox1.Text+=serialPort1.PortName;//debug
			
			
			
			
			try{
				serialPort1.Open();
				serialPort1.DiscardInBuffer();
				serialPort1.DiscardOutBuffer();
			}catch{
				//textBox1.Text+="%";//debug
			}
			
			if(serialPort1.IsOpen)
			{
				//textBox1.Text+="!";//debug
				button1.Enabled=false;
				button29.Enabled=false;
				button30.Enabled=false;
				SearchSerial.Interval=500;
				toolStripTextBox1.Text="COM"+Convert.ToString(portnumber);
				serialPort1.Write("BoardSerial");

			}
			portnumber++;
			
			if(portnumber>50)
			{
				SearchSerial.Stop();
				portnumber=0;
				Rfresh=0;
			}
			
			
			
		}
		
		void ToolStripMenuItem1Click(object sender, EventArgs e)
		{
			if(serialPort1.IsOpen)
			{
				serialPort1.Close();
				portnumber=0;
				toolStripTextBox2.Text="Disconnected...";
			}
			else{
				SearchSerial.Start();
			}
		}
		
		string incoming="";
		
		void SerialPort1DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
		{
			
			try
			{
				
				safeData(label1, serialPort1.ReadLine());
			}
			catch (Exception exception)
			{
				safeData(richTextBox1, exception.Message + "\n\n" + exception.Data);
			}
			finally
			{
				//serialPort1.Close();
			}
		}
		

		private delegate void safeDataWorker(Control control, string text);

		string[] availableID=new string[26];
		int avalableIDcycle=0;
		public void safeData(Control safeCOM, string txt)
		{
			if (this.InvokeRequired)
			{
				try{
					this.Invoke(new safeDataWorker(safeData), new object[] { safeCOM, txt });
				}catch{}
			}
			else{
				
				GUIrichtextbox.Text = txt;//GUIrichtextbox handles incoming data and is unfiltered
				string[] CRC= Regex.Split(GUIrichtextbox.Text, "[0-9]+");//CRC is filtered data from GUIrichtextbox
				
				
				if(GUIrichtextbox.Text.TrimEnd('\n')=="12345abcde")
				{
					//textBox1.Text+="!@!";//debug
					toolStripTextBox2.Text="License verified";
					toolStripDropDownButton1.BackColor=Color.LimeGreen;
					button1.Enabled=true;
					button29.Enabled=true;
					button30.Enabled=true;
					portnumber=0;
					
					SearchSerial.Stop();
					
					if(Rfresh==1)
					{
						serialPort1.Write("!S");
						Thread.Sleep(100);
						serialPort1.Write("!C");
						
					}
				}
				
				if(modeSelect==0 && CRC[1]=="C" && CRC[0]!="" && CRC[0] !=" ")
				{
					toolStripComboBox1.Items.Add(CRC[0]+"\n");//ID being added to combo box
					toolStripDropDownButton2.BackColor=Color.LimeGreen;
					availableID[avalableIDcycle]=CRC[0];
					avalableIDcycle++;
					occupiedTarget[Convert.ToInt32(Convert.ToChar(CRC[0]))-65]=1;
					
					
				}
				if(modeSelect==1 || modeSelect==2) gameMode(GUIrichtextbox.Text);
			}
		}

		
		void Button1Click(object sender, EventArgs e)
		{
			modeSelect=1;
			button30.Text="Start";
			button1.BackColor=Color.LimeGreen;
			button29.BackColor=Color.LightGray;
		}
		
		
		void Button2Click(object sender, EventArgs e)
		{
			//textBox5.Text+=Convert.ToString(occupiedTarget[0]);//Convert.ToString(avalableIDcycle);//Convert.ToString(Rfresh);
			//textBox5.Text+=Convert.ToString(occupiedTarget[1]);
			//textBox5.Text+=Convert.ToString(occupiedTarget[2]);
			//textBox5.Text=Convert.ToString(tempID);
			//serialPort1.PortName="COM8";
			//serialPort1.Open();
			//serialPort1.Write("BoardSerial");
			//playBackSound("chime");
			
			//textBox5.Text=Convert.ToString(mapCycle) + " | " + Convert.ToString(totalTarget)+ " | " + Convert.ToString(tempID);
			//string delimitLetters = "[a-zA-Z]+";
			//string delimitNumbers= "[0-9]+";  				// Split on any group of letters

			//string[] dataVal = Regex.Split(GUIrichtextbox.Text, delimitLetters);
			//string[] dataCmd= Regex.Split(GUIrichtextbox.Text, delimitNumbers);
			textBox5.Text=Convert.ToString(delayMap[mapCycle]+gameDelay)+ " | "+Convert.ToString(stopWatch.ElapsedMilliseconds);
			//richTextBox1.Text=Convert.ToString(trackbarHoldLongDouble);
		}
		
		void LicenseCheckTick(object sender, EventArgs e)
		{
			//*********************old code glitchy and needs GUI richtextbox to pass data properly**************
			/*if(incoming.TrimEnd('\r','\n')=="12345abcde")
			{
				toolStripTextBox2.Text="License verified";
				try{
					serialPort1.Open();
				}catch{
					
				}
				//searchTargets.Start();
				SearchSerial.Stop();
				if(Rfresh==1)
				{
					
					//searchTargets.Start();
					serialPort1.Write("!C");
					//add Refresh code*************************
					
				}
				
			}*/
		}
		
		
		
		void playBackVoice(string audioName)
		{
			try{
				string audio=@"C:\Program Files\PTS\voice\"+audioName+@".wav";
				SoundPlayer sound = new SoundPlayer(audio);
				//sound.Play();
				sound.PlaySync();
			}catch{MessageBox.Show("audio not available");}
			
		}
		void playBackSoundFast(string audioName)
		{
			try{
				string audio=@"C:\Program Files\PTS\"+audioName+@".wav";
				SoundPlayer sound = new SoundPlayer(audio);
				//sound.Play();
				sound.Play();
			}catch{MessageBox.Show("audio not available");}
		}
		void playBackSound(string audioName)
		{
			try{
				string audio=@"C:\Program Files\PTS\"+audioName+@".wav";
				SoundPlayer sound = new SoundPlayer(audio);
				//sound.Play();
				sound.PlaySync();
			}catch{MessageBox.Show("audio not available");}
		}
		
		
		
		void Label2Click(object sender, EventArgs e)
		{
			
		}
		
		

		
		void SearchToolStripMenuItemClick(object sender, EventArgs e)
		{
			toolStripComboBox1.Items.Clear();
			//searchTargets.Start();
			try{

				modeSelect=0;
				avalableIDcycle=0;
				delayTimer.Start();
				serialPort1.Write("!C");
				Thread.Sleep(10);
				
			}catch{MessageBox.Show("search error: base unit not found...");}
		}
		
		//*************old code****************
		/*int i=0;
		void SearchTargetsTick(object sender, EventArgs e)
		{
			
			
			try{
				serialPort1.Write(Convert.ToString(Convert.ToChar(i+65)+"C"));
				i++;
				if(i>25)
				{
					i=0;
					searchTargets.Stop();
				}
				
				
			}
			catch{
				Rfresh=0;
				searchTargets.Stop();
				MessageBox.Show("Base unit not connected");

			}
			
		}*/
		

		
		
		int Rfresh=0;
		
		void ToolStripButton1Click(object sender, EventArgs e)
		{
			Rfresh=1;
			serialPort1.Close();
			modeSelect=0;
			toolStripTextBox2.Text="Disconnected...";
			toolStripDropDownButton1.BackColor=Color.LightGray;
			toolStripDropDownButton2.BackColor=Color.LightGray;
			button1.BackColor=Color.LightGray;
			button29.BackColor=Color.LightGray;
			button1.Enabled=false;
			button29.Enabled=false;
			button30.Enabled=false;
			button30.Text="";
			Thread.Sleep(50);
			toolStripComboBox1.Items.Clear();
			toolStripMenuItem1.PerformClick();
		}
		
		void ToolStripDropDownButton1DropDownClosed(object sender, EventArgs e)
		{
			
		}
		
		void ToolStripDropDownButton2Click(object sender, EventArgs e)
		{
			
		}
		
		void ToolStripButton2Click(object sender, EventArgs e)
		{
			//richTextBox1.Text=Convert.ToString(toolStripComboBox1.Items);
		}
		
		void ToolStripTextBox2TextChanged(object sender, EventArgs e)
		{
			
		}
		
		void ToolStripComboBox1TextChanged(object sender, EventArgs e)
		{
			if(toolStripComboBox1.Items.Contains("A\n")) toolStripDropDownButton2.BackColor=Color.LimeGreen;//fix code
			else toolStripDropDownButton2.BackColor=Color.Gray;
		}
		
		void GroupBox3Enter(object sender, EventArgs e)
		{
			
		}
		
		void Button29Click(object sender, EventArgs e)
		{
			modeSelect=2;
			button30.Text="Start";
			button29.BackColor=Color.LimeGreen;
			button1.BackColor=Color.LightGray;
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			
			targetSelect('A');
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			targetSelect('B');
		}
		
		void targetSelect(char i)
		{
			
			button3.Font = new Font(button3.Font, FontStyle.Regular);
			button4.Font = new Font(button4.Font, FontStyle.Regular);
			button5.Font = new Font(button5.Font, FontStyle.Regular);
			button6.Font = new Font(button6.Font, FontStyle.Regular);
			button7.Font = new Font(button7.Font, FontStyle.Regular);
			button8.Font = new Font(button8.Font, FontStyle.Regular);
			button9.Font = new Font(button9.Font, FontStyle.Regular);
			button10.Font = new Font(button10.Font, FontStyle.Regular);
			button11.Font = new Font(button11.Font, FontStyle.Regular);
			button12.Font = new Font(button12.Font, FontStyle.Regular);
			button13.Font = new Font(button13.Font, FontStyle.Regular);
			button14.Font = new Font(button14.Font, FontStyle.Regular);
			button15.Font = new Font(button15.Font, FontStyle.Regular);
			button16.Font = new Font(button16.Font, FontStyle.Regular);
			button17.Font = new Font(button17.Font, FontStyle.Regular);
			button18.Font = new Font(button18.Font, FontStyle.Regular);
			button19.Font = new Font(button19.Font, FontStyle.Regular);
			button20.Font = new Font(button20.Font, FontStyle.Regular);
			button21.Font = new Font(button21.Font, FontStyle.Regular);
			button22.Font = new Font(button22.Font, FontStyle.Regular);
			button23.Font = new Font(button23.Font, FontStyle.Regular);
			button24.Font = new Font(button24.Font, FontStyle.Regular);
			button25.Font = new Font(button25.Font, FontStyle.Regular);
			button26.Font = new Font(button26.Font, FontStyle.Regular);
			button26.Font = new Font(button26.Font, FontStyle.Regular);
			button28.Font = new Font(button28.Font, FontStyle.Regular);
			button29.Font = new Font(button29.Font, FontStyle.Regular);
			
			switch(Convert.ToInt32(i)-65)
			{
					
				case 0:
					button3.Font = new Font(button3.Font, FontStyle.Bold);
					break;
				case 1:
					button4.Font = new Font(button4.Font, FontStyle.Bold);
					break;
				case 2:
					button5.Font = new Font(button5.Font, FontStyle.Bold);
					break;
				case 3:
					button6.Font = new Font(button6.Font, FontStyle.Bold);
					break;
				case 4:
					button7.Font = new Font(button7.Font, FontStyle.Bold);
					break;
				case 5:
					button8.Font = new Font(button8.Font, FontStyle.Bold);
					break;
				case 6:
					button9.Font = new Font(button9.Font, FontStyle.Bold);
					break;
				case 7:
					button10.Font = new Font(button10.Font, FontStyle.Bold);
					break;
				case 8:
					button11.Font = new Font(button11.Font, FontStyle.Bold);
					break;
				case 9:
					button12.Font = new Font(button12.Font, FontStyle.Bold);
					break;
				case 10:
					button13.Font = new Font(button13.Font, FontStyle.Bold);
					break;
				case 11:
					button14.Font = new Font(button14.Font, FontStyle.Bold);
					break;
				case 12:
					button15.Font = new Font(button15.Font, FontStyle.Bold);
					break;
				case 13:
					button16.Font = new Font(button16.Font, FontStyle.Bold);
					break;
				case 14:
					button17.Font = new Font(button17.Font, FontStyle.Bold);
					break;
				case 15:
					button18.Font = new Font(button18.Font, FontStyle.Bold);
					break;
				case 16:
					button19.Font = new Font(button19.Font, FontStyle.Bold);
					break;
				case 17:
					button20.Font = new Font(button20.Font, FontStyle.Bold);
					break;
				case 18:
					button21.Font = new Font(button21.Font, FontStyle.Bold);
					break;
				case 19:
					button22.Font = new Font(button22.Font, FontStyle.Bold);
					break;
				case 20:
					button23.Font = new Font(button23.Font, FontStyle.Bold);
					break;
				case 21:
					button24.Font = new Font(button24.Font, FontStyle.Bold);
					break;
				case 22:
					button25.Font = new Font(button25.Font, FontStyle.Bold);
					break;
				case 23:
					button26.Font = new Font(button26.Font, FontStyle.Bold);
					break;
				case 24:
					button26.Font = new Font(button26.Font, FontStyle.Bold);
					break;
				case 25:
					button28.Font = new Font(button28.Font, FontStyle.Bold);
					break;
				case 26:
					button29.Font = new Font(button29.Font, FontStyle.Bold);
					break;
					
					
					
					
			}
		}
		
		
		
		
		
		void Button5Click(object sender, EventArgs e)
		{
			targetSelect('C');
		}
		
		void Button6Click(object sender, EventArgs e)
		{
			targetSelect('D');
		}
		
		void Button7Click(object sender, EventArgs e)
		{
			targetSelect('E');
		}
		
		void Button8Click(object sender, EventArgs e)
		{
			targetSelect('F');
		}
		
		void Button9Click(object sender, EventArgs e)
		{
			targetSelect('G');
		}
		
		void Button10Click(object sender, EventArgs e)
		{
			targetSelect('H');
		}
		
		void Button11Click(object sender, EventArgs e)
		{
			targetSelect('I');
		}
		
		void Button12Click(object sender, EventArgs e)
		{
			targetSelect('J');
		}
		
		void Button13Click(object sender, EventArgs e)
		{
			targetSelect('K');
		}
		
		void Button14Click(object sender, EventArgs e)
		{
			targetSelect('L');
		}
		
		void Button15Click(object sender, EventArgs e)
		{
			targetSelect('M');
		}
		
		void Button16Click(object sender, EventArgs e)
		{
			targetSelect('N');
		}
		
		void Button17Click(object sender, EventArgs e)
		{
			targetSelect('O');
		}
		
		void Button18Click(object sender, EventArgs e)
		{
			targetSelect('P');
		}
		
		void Button19Click(object sender, EventArgs e)
		{
			targetSelect('Q');
		}
		
		void Button20Click(object sender, EventArgs e)
		{
			targetSelect('R');
		}
		
		void Button21Click(object sender, EventArgs e)
		{
			targetSelect('S');
		}
		
		void Button22Click(object sender, EventArgs e)
		{
			targetSelect('T');
		}
		
		void Button23Click(object sender, EventArgs e)
		{
			targetSelect('U');
		}
		
		void Button24Click(object sender, EventArgs e)
		{
			targetSelect('V');
		}
		
		void Button25Click(object sender, EventArgs e)
		{
			targetSelect('W');
		}
		
		void Button26Click(object sender, EventArgs e)
		{
			targetSelect('X');
		}
		
		void Button27Click(object sender, EventArgs e)
		{
			targetSelect('Y');
		}
		
		void Button28Click(object sender, EventArgs e)
		{
			targetSelect('Z');
		}
		
		void Button30Click(object sender, EventArgs e)
		{
			
			
			tempID=0;
		
			lastTarget="";
		
			Array.Clear(targetMap,0,targetMap.Length);
			Array.Clear(reslienceMap,0,targetMap.Length);
			Array.Clear(delayMap,0,targetMap.Length);
			
			gameDelay=trackbarHoldLongDouble;
			
			totalStopWatch.Reset();
			totalStopWatch.Stop();
			stopWatch.Reset();
			stopWatch.Stop();
			
			richTextBox1.Clear();
			if(modeSelect==1)target();
			if(modeSelect==2)simulationGenerate();
			
			
		}
		
		void GroupBox2Enter(object sender, EventArgs e)
		{
			
		}
		
		void TrackBar1Scroll(object sender, EventArgs e)
		{
			label5.Text=trackBar1.Value.ToString();
		}
		
		void Label3Click(object sender, EventArgs e)
		{
			
		}
		
		
		
		void target()
		{
			Tval=Convert.ToInt32(label6.Text);
			Lval=Convert.ToInt32(label7.Text);
			Dval=Convert.ToInt32(label5.Text);
			
			Bysteffect=Convert.ToInt32(label10.Text);
			Bysteffect/=100;
			Reffect=Convert.ToInt32(label12.Text);
			Reffect/=100;
			Beffect=Convert.ToInt32(label4.Text);
			Beffect/=100;
			
			unpredict=Convert.ToInt32(label14.Text);
			unpredict/=100;
			
			Bval=random.Next(Convert.ToInt32((Tval/2)*Bysteffect),Convert.ToInt32(Tval*Bysteffect));
			//Bval=random.Next(0,10);
			totalTarget=Tval+Bval;
			enemyTarget=Tval;
			bystanderTarget=Bval;
			
			textBox1.Text=Convert.ToString(enemyTarget);
			textBox2.Text=Convert.ToString(bystanderTarget);
			textBox3.Text=Convert.ToString(Dval-((unpredict)*Dval));
			textBox4.Text="";
			for(int i=0; i<totalTarget;i++)
			{
				sampleVal=random.Next(0,1000);
				//try{
				if((sampleVal<(1000/(enemyTarget+bystanderTarget))*enemyTarget))// && enemyTarget>1) || (enemyTarget==1 &&bystanderTarget==0))
				{
					targetMap[i]='E';
					enemyTarget--;
				}
				else
				{
					targetMap[i]='G';
					bystanderTarget--;
				}
				//}catch{}
			}
			
			for(int i=0; i<totalTarget;i++)
			{
				delayMap[i]=random.Next(Convert.ToInt32(Dval-unpredict*Dval),Convert.ToInt32(Dval+unpredict*Dval));
				
			}
			for(int i=0; i<Tval;i++)
			{
				sampleVal=random.Next(Convert.ToInt32(Lval-unpredict*Lval),Convert.ToInt32(Lval+unpredict*Lval));
				if(sampleVal>0) reslienceMap[i]=sampleVal;
				else reslienceMap[i]=1;
			}
			
			for(int a=0;a<Tval;a++)
			{
				textBox4.Text+=Convert.ToString(delayMap[a])+" ";
			}
			
			playBackSoundFast("beep");
			stopWatch.Start();
			totalStopWatch.Start();
			Simulation.Start();
			
		}
		
		
		
		int Tval=0, Lval=0, Dval=0, Bval=0, totalTarget=0, enemyTarget=0, bystanderTarget=0;
		double Bysteffect=0, Reffect=0, Beffect=0;
		
		double unpredict=0;
		char[] targetMap=new char[50];
		int[] reslienceMap=new int[50];
		int[] delayMap=new int[50];
		
		int sampleVal=0;
		
		Random random=new Random();
		void simulationGenerate()
		{
			

			
			Tval=Convert.ToInt32(label6.Text);
			Lval=Convert.ToInt32(label7.Text);
			Dval=Convert.ToInt32(label5.Text);
			
			Bysteffect=Convert.ToInt32(label10.Text);
			Bysteffect/=100;
			Reffect=Convert.ToInt32(label12.Text);
			Reffect/=100;
			Beffect=Convert.ToInt32(label4.Text);
			Beffect/=100;
			
			unpredict=Convert.ToInt32(label14.Text);
			unpredict/=100;
			
			Bval=random.Next(Convert.ToInt32((Tval/2)*Bysteffect),Convert.ToInt32(Tval*Bysteffect));
			//Bval=random.Next(0,10);
			totalTarget=Tval+Bval;
			enemyTarget=Tval;
			bystanderTarget=Bval;
			
			textBox1.Text=Convert.ToString(enemyTarget);
			textBox2.Text=Convert.ToString(bystanderTarget);
			textBox3.Text=Convert.ToString(Dval-((unpredict)*Dval));
			textBox4.Text="";
			for(int i=0; i<totalTarget;i++)
			{
				sampleVal=random.Next(0,1000);
				//try{
				if((sampleVal<(1000/(enemyTarget+bystanderTarget))*enemyTarget))// && enemyTarget>1) || (enemyTarget==1 &&bystanderTarget==0))
				{
					targetMap[i]='E';
					enemyTarget--;
				}
				else
				{
					targetMap[i]='G';
					bystanderTarget--;
				}
				//}catch{}
			}
			
			for(int i=0; i<totalTarget;i++)
			{
				delayMap[i]=random.Next(Convert.ToInt32(Dval-unpredict*Dval),Convert.ToInt32(Dval+unpredict*Dval));
				
			}
			for(int i=0; i<Tval;i++)
			{
				sampleVal=random.Next(Convert.ToInt32(Lval-unpredict*Lval),Convert.ToInt32(Lval+unpredict*Lval));
				if(sampleVal>0) reslienceMap[i]=sampleVal;
				else reslienceMap[i]=1;
			}
			
			for(int a=0;a<Tval;a++)
			{
				textBox4.Text+=Convert.ToString(delayMap[a])+" ";
			}
			
			playBackSoundFast("beep");
			stopWatch.Start();
			totalStopWatch.Start();
			Simulation.Start();
		}
		
		void TrackBar2Scroll(object sender, EventArgs e)
		{
			label6.Text=trackBar2.Value.ToString();
		}
		
		void TrackBar4Scroll(object sender, EventArgs e)
		{
			label7.Text=trackBar4.Value.ToString();
		}
		
		void TrackBar5Scroll(object sender, EventArgs e)
		{
			label4.Text=trackBar5.Value.ToString();
		}
		
		void TrackBar6Scroll(object sender, EventArgs e)
		{
			label10.Text=trackBar6.Value.ToString();
		}
		
		void TrackBar3Scroll(object sender, EventArgs e)
		{
			label12.Text=trackBar3.Value.ToString();
		}
		
		void Label12Click(object sender, EventArgs e)
		{
			
		}
		
		void TrackBar7Scroll(object sender, EventArgs e)
		{
			label14.Text=trackBar7.Value.ToString();
		}
		
		
		
		
		void lightUp(char signal)
		{
			///richTextBox5.Text+="SEL "+Convert.ToString(Convert.ToInt32(signal))+"\n";
			
			switch(Convert.ToInt32(signal)-65)
			{
					
				case 0:
					//button3.Font = new Font(button3.Font, FontStyle.Bold);
					if(targetMap[mapCycle]=='N') button3.BackColor=Color.RoyalBlue;
					else if(targetMap[mapCycle]=='E') button3.BackColor=Color.Red;
					else if(targetMap[mapCycle]=='G') button3.BackColor=Color.LimeGreen;
					break;
				case 1:
					//button4.Font = new Font(button4.Font, FontStyle.Bold);
					if(targetMap[mapCycle]=='N') button4.BackColor=Color.RoyalBlue;
					else if(targetMap[mapCycle]=='E') button4.BackColor=Color.Red;
					else if(targetMap[mapCycle]=='G') button4.BackColor=Color.LimeGreen;
					break;
				case 2:
					//button5.Font = new Font(button5.Font, FontStyle.Bold);
					if(targetMap[mapCycle]=='N') button5.BackColor=Color.RoyalBlue;
					else if(targetMap[mapCycle]=='E') button5.BackColor=Color.Red;
					else if(targetMap[mapCycle]=='G') button5.BackColor=Color.LimeGreen;
					break;
				case 3:
					//button6.Font = new Font(button6.Font, FontStyle.Bold);
					if(targetMap[mapCycle]=='N') button6.BackColor=Color.RoyalBlue;
					else if(targetMap[mapCycle]=='E') button6.BackColor=Color.Red;
					else if(targetMap[mapCycle]=='G') button6.BackColor=Color.LimeGreen;
					break;
				case 4:
					button7.Font = new Font(button7.Font, FontStyle.Bold);
					break;
				case 5:
					button8.Font = new Font(button8.Font, FontStyle.Bold);
					break;
				case 6:
					button9.Font = new Font(button9.Font, FontStyle.Bold);
					break;
				case 7:
					button10.Font = new Font(button10.Font, FontStyle.Bold);
					break;
				case 8:
					button11.Font = new Font(button11.Font, FontStyle.Bold);
					break;
				case 9:
					button12.Font = new Font(button12.Font, FontStyle.Bold);
					break;
				case 10:
					button13.Font = new Font(button13.Font, FontStyle.Bold);
					break;
				case 11:
					button14.Font = new Font(button14.Font, FontStyle.Bold);
					break;
				case 12:
					button15.Font = new Font(button15.Font, FontStyle.Bold);
					break;
				case 13:
					button16.Font = new Font(button16.Font, FontStyle.Bold);
					break;
				case 14:
					button17.Font = new Font(button17.Font, FontStyle.Bold);
					break;
				case 15:
					button18.Font = new Font(button18.Font, FontStyle.Bold);
					break;
				case 16:
					button19.Font = new Font(button19.Font, FontStyle.Bold);
					break;
				case 17:
					button20.Font = new Font(button20.Font, FontStyle.Bold);
					break;
				case 18:
					button21.Font = new Font(button21.Font, FontStyle.Bold);
					break;
				case 19:
					button22.Font = new Font(button22.Font, FontStyle.Bold);
					break;
				case 20:
					button23.Font = new Font(button23.Font, FontStyle.Bold);
					break;
				case 21:
					button24.Font = new Font(button24.Font, FontStyle.Bold);
					break;
				case 22:
					button25.Font = new Font(button25.Font, FontStyle.Bold);
					break;
				case 23:
					button26.Font = new Font(button26.Font, FontStyle.Bold);
					break;
				case 24:
					button26.Font = new Font(button26.Font, FontStyle.Bold);
					break;
				case 25:
					button28.Font = new Font(button28.Font, FontStyle.Bold);
					break;
				case 26:
					button29.Font = new Font(button29.Font, FontStyle.Bold);
					break;
					
					
					
					
					
			}
			
		}
		
		int mapCycle=0;
		int tempID=0;
		int[] occupiedTarget=new int[26];
		string lastTarget="";
		int gameDelay=0;
		void SimulationTick(object sender, EventArgs e)
		{
			tempID=random.Next(0,avalableIDcycle);
			try{
				if(occupiedTarget[Convert.ToInt32(Convert.ToChar(availableID[tempID]))-65]==1)
				{
					if(mapCycle>=totalTarget && delayMap[mapCycle-1]>stopWatch.ElapsedMilliseconds)Simulation.Stop();
					else{
						
						if((delayMap[mapCycle]+gameDelay)<stopWatch.ElapsedMilliseconds )
						{
							gameDelay=0;
							if(reslienceMap[mapCycle]<=0) reslienceMap[mapCycle]=1;
							serialPort1.Write(availableID[tempID]+Convert.ToString(targetMap[mapCycle])+Convert.ToString(reslienceMap[mapCycle]));
							playBackSoundFast("chime");
							lightUp(Convert.ToChar(availableID[tempID]));
							occupiedTarget[Convert.ToInt32(Convert.ToChar(availableID[tempID]))-65]=2;
							
							richTextBox6.Text+=Convert.ToString(stopWatch.ElapsedMilliseconds)+"\n";//debug
							richTextBox6.Text+=availableID[tempID]+Convert.ToString(targetMap[mapCycle])+Convert.ToString(reslienceMap[mapCycle])+"\n\n";//debug
							mapCycle++;
							if(mapCycle>=totalTarget)lastTarget=availableID[tempID];
							stopWatch.Reset();
							stopWatch.Start();
							Thread.Sleep(20);
							
							
							
						}
						else{
							//Simulation.Stop();
							//MessageBox.Show("no target units in range");
							//mapCycle++;
						}
					}
				}
				else
				{
					//stopWatch.Reset();
					//stopWatch.Start();
				}
				
			}catch{
				Simulation.Stop();
				MessageBox.Show("Run error!");
			}
			
			
		}
		
		
		
		
		
		
		int modeSelect=0;//***************temp setting
		double pastTimehold=0;
		double holdValue=0;
		string holdString="";
		string space="                   ";
		void gameMode(string data)
		{
			
			
			if(modeSelect==1)
			{
				
					
				string delimitLetters = "[a-zA-Z]+";
				string delimitNumbers= "[0-9]+";  				// Split on any group of letters

				string[] dataVal = Regex.Split(data, delimitLetters);
				string[] dataCmd= Regex.Split(data, delimitNumbers);
				
				//richTextBox4.Text+="\n"+dataCmd[1]+"\n";
				//richTextBox4.Text+="|"+dataVal[2]+"|";
				
				
				if(dataCmd[1]!="R")
				{
					richTextBox1.Text+=dataCmd[0]+space;
					
					holdValue=Convert.ToDouble(dataVal[1])/1000;
					richTextBox1.Text+=holdValue.ToString("#0.000")+space;
					
					pastTimehold=totalStopWatch.ElapsedMilliseconds;
					holdValue=Convert.ToDouble(pastTimehold/1000);
					richTextBox1.Text+=holdValue.ToString("#0.000")+space;
					
					holdString=dataVal[2];//automatic "\n" character from string data package
					richTextBox1.Text+=holdString.TrimEnd('\n')+space;
				}
				
				if(dataCmd[1]=="R" && Convert.ToInt32(dataVal[2])==0)
				{
					//playBackSound("chime");
					occupiedTarget[Convert.ToInt32(Convert.ToChar(dataCmd[0]))-65]=1;
				}
				
				
				if(lastTarget==dataCmd[0] && Convert.ToInt32(dataVal[2])==0)
				{
					playBackSoundFast("beep");
					
					button30.Text="TRAINING COMPLETE";
					button1.BackColor=Color.LightGray;
					mapCycle=0;
					
				}
				
				if(dataCmd[1]=="E")
				{
					if(Convert.ToInt32(dataVal[2])>0)
					{
						//playBackSound("chime");
						richTextBox1.Text+="Hit!\n";
					}
					if(Convert.ToInt32(dataVal[2])==0)
					{
						occupiedTarget[Convert.ToInt32(Convert.ToChar(dataCmd[0]))-65]=1;
						
						stopWatch.Reset();
						stopWatch.Start();
						
						//playBackSound("chime");
						richTextBox1.Text+="E-Down!\n";//"n" added later
					}
					
				}
				
				if(dataCmd[1]=="I" && Convert.ToInt32(dataVal[2])==0)
				{
					//playBackSound("chime");
					richTextBox1.Text+="E-Overkill!\n";//"n" added later
				}
				
				
				if(dataCmd[1]=="G"|| dataCmd[1]=="N" )
				{
					if(Convert.ToInt32(dataVal[2])>0)
					{
						//playBackSound("chime");
						richTextBox1.Text+="F-Fire!\n";//"n" added later
					}
					if(Convert.ToInt32(dataVal[2])==0)
					{
						//playBackSound("chime");
						occupiedTarget[Convert.ToInt32(Convert.ToChar(dataCmd[0]))-65]=1;
						richTextBox1.Text+="F-DEAD!\n";//"n" added later
					}
					
				}
				
				if (dataCmd[1]=="O"|| dataCmd[1]=="P")
				{
					//playBackSound("chime");
					richTextBox1.Text+="F-Overkill!\n";//ADD end of GAME code here because this is a serious casualty
				}
				
				
			}
			if(modeSelect==2)
			{
				
				
				string delimitLetters = "[a-zA-Z]+";
				string delimitNumbers= "[0-9]+";  				// Split on any group of letters

				string[] dataVal = Regex.Split(data, delimitLetters);
				string[] dataCmd= Regex.Split(data, delimitNumbers);
				
				//richTextBox4.Text+="\n"+dataCmd[1]+"\n";
				//richTextBox4.Text+="|"+dataVal[2]+"|";
				
				
				if(dataCmd[1]!="R")
				{
					richTextBox1.Text+=dataCmd[0]+space;
					
					holdValue=Convert.ToDouble(dataVal[1])/1000;
					richTextBox1.Text+=holdValue.ToString("#0.000")+space;
					
					pastTimehold=totalStopWatch.ElapsedMilliseconds;
					holdValue=Convert.ToDouble(pastTimehold/1000);
					richTextBox1.Text+=holdValue.ToString("#0.000")+space;
					
					holdString=dataVal[2];//automatic "\n" character from string data package
					richTextBox1.Text+=holdString.TrimEnd('\n')+space;
				}
				
				if(dataCmd[1]=="R" && Convert.ToInt32(dataVal[2])==0)
				{
					//playBackSound("chime");
					occupiedTarget[Convert.ToInt32(Convert.ToChar(dataCmd[0]))-65]=1;
				}
				
				
				if(lastTarget==dataCmd[0] && Convert.ToInt32(dataVal[2])==0)
				{
					playBackSoundFast("beep");
					Simulation.Stop();
					button30.Text="SIMULATION COMPLETE";
					button29.BackColor=Color.LightGray;
					mapCycle=0;
					
				}
				
				if(dataCmd[1]=="E")
				{
					if(Convert.ToInt32(dataVal[2])>0)
					{
						//playBackSound("chime");
						richTextBox1.Text+="Hit!\n";
					}
					if(Convert.ToInt32(dataVal[2])==0)
					{
						occupiedTarget[Convert.ToInt32(Convert.ToChar(dataCmd[0]))-65]=1;
						
						stopWatch.Reset();
						stopWatch.Start();
						
						//playBackSound("chime");
						richTextBox1.Text+="E-Down!\n";//"n" added later
					}
					
				}
				
				if(dataCmd[1]=="I" && Convert.ToInt32(dataVal[2])==0)
				{
					//playBackSound("chime");
					richTextBox1.Text+="E-Overkill!\n";//"n" added later
				}
				
				
				if(dataCmd[1]=="G"|| dataCmd[1]=="N" )
				{
					if(Convert.ToInt32(dataVal[2])>0)
					{
						//playBackSound("chime");
						richTextBox1.Text+="F-Fire!\n";//"n" added later
					}
					if(Convert.ToInt32(dataVal[2])==0)
					{
						//playBackSound("chime");
						occupiedTarget[Convert.ToInt32(Convert.ToChar(dataCmd[0]))-65]=1;
						richTextBox1.Text+="F-DEAD!\n";//"n" added later
					}
					
				}
				
				if (dataCmd[1]=="O"|| dataCmd[1]=="P")
				{
					//playBackSound("chime");
					richTextBox1.Text+="F-Overkill!\n";//ADD end of GAME code here because this is a serious casualty
				}
				
				
				
				
			}
			
		}
		
		int once=0;
		void DelayTimerTick(object sender, EventArgs e)
		{
			if(once==1)
			{
				modeSelect=3;
				once=0;
				delayTimer.Stop();
			}
			once++;
		}
		
		void ManualToolStripMenuItemClick(object sender, EventArgs e)
		{
			try{
				serialPort1.PortName=toolStripTextBox1.Text;
				serialPort1.Open();
				toolStripTextBox2.Text=serialPort1.PortName+" connected!";
			}
			catch{MessageBox.Show("Connection attempt failed");}
		}
		
		void GUIrichtextboxTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
		
		double trackbarHoldDouble=0;
		int trackbarHoldLongDouble=0;
		void TrackBar8Scroll(object sender, EventArgs e)
		{
			trackbarHoldLongDouble=trackBar8.Value;
			trackbarHoldDouble=trackBar8.Value;
			trackbarHoldDouble/=1000;
			label16.Text=Convert.ToString(trackbarHoldDouble.ToString("0.0"));
		}
		
		void Label16Click(object sender, EventArgs e)
		{
			
		}
	}
}
