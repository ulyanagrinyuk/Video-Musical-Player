using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_Musical_Player
{
	public partial class Video_or_Music : Form
	{
		string[] files, paths;
		public Video_or_Music()
		{
			InitializeComponent();
		}
		private void listBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			Player.URL = paths[listBox.SelectedIndex];
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			(listBox.SelectedIndex)++;
		}		

		private void btnBack_Click(object sender, EventArgs e)
		{
			(listBox.SelectedIndex)--;
		}

		private void btnStop_Click(object sender, EventArgs e)
		{
			Player.Ctlcontrols.stop();
		}

		private void btnPlay_Click(object sender, EventArgs e)
		{
			Player.Ctlcontrols.play();
		}

		private void btnPause_Click(object sender, EventArgs e)
		{
			Player.Ctlcontrols.pause();
		}

		private void btnOpen_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Multiselect = true;
			if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				files = ofd.SafeFileNames;
				paths = ofd.FileNames;
				for (int i = 0; i < files.Length; i++)
				{
					listBox.Items.Add(files[i]);
				}
			}
		}
	}
}
