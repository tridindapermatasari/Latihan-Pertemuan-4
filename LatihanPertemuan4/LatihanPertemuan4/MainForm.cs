/*
 * Created by SharpDevelop.
 * User: ASUS
 * Date: 2/3/2022
 * Time: 3:35 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LatihanPertemuan4
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
		
		void Button1Click(object sender, EventArgs e)
		{
			MessageBox.Show ("Nama : " + this.textBox1.Text);
			MessageBox.Show ("NIM : " + this.textBox2.Text);
			MessageBox.Show ("Kelas : " + this.textBox3.Text);
			MessageBox.Show ("Mata Kuliah : " + this.textBox4.Text);
		}
	}
}
