/*
 * Created by SharpDevelop.
 * User: Wollitoo
 * Date: 20.12.2016
 * Time: 19:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Name_Check
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
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//Process.Start("http://www.line-lan.net");
		}
		void Button1Click(object sender, EventArgs e)
		{
			if(firstName.Text.Equals("") || lastName.Text.Equals(""))	{
			   	MessageBox.Show("Pls fill in all needed fields!");
			}else{
			   	if(firstName.Text.Equals("André") && lastName.Text.Equals("Kienzle"))	{
			   		MessageBox.Show("Happy Birthday! Mach weiter so wie du bist! Du machst ne Hammer Arbeit als Serveradmin, Programmierer und Freund. Ich beneide dich um deine Skills für mehr als das reichts im mom net.");
			   	}else{
			   		MessageBox.Show("Wrong User!");
			   	}
			}
		}
		void PictureBox1Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("http://www.line-lan.net");
		}
	}
}
