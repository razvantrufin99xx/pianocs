/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 5/27/2024
 * Time: 10:39 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Media;

namespace musicaSoundPlayer
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
			//
		}
		SoundPlayer s ;
		void MainFormLoad(object sender, EventArgs e)
		{
			
	
		}
		void Button1Click(object sender, EventArgs e)
		{
				s = new SoundPlayer("do.wav");
				s.Play();
		}
		void Button2Click(object sender, EventArgs e)
		{
	s = new SoundPlayer("re.wav");
				s.Play();
		}
		void Button3Click(object sender, EventArgs e)
		{
	s = new SoundPlayer("mi.wav");
				s.Play();
		}
		void Button4Click(object sender, EventArgs e)
		{
	s = new SoundPlayer("fa.wav");
				s.Play();
		}
		void Button5Click(object sender, EventArgs e)
		{
	s = new SoundPlayer("so.wav");
				s.Play();
		}
		void Button6Click(object sender, EventArgs e)
		{
	s = new SoundPlayer("la.wav");
				s.Play();
		}
		void Button7Click(object sender, EventArgs e)
		{
	s = new SoundPlayer("si.wav");
				s.Play();
		}
		void Button8Click(object sender, EventArgs e)
		{
	s = new SoundPlayer("dosus.wav");
				s.Play();
		}
	
	}
}
