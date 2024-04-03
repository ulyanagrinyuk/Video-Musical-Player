namespace Video_Musical_Player
{
	partial class Video_or_Music
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Video_or_Music));
			this.listBox = new System.Windows.Forms.ListBox();
			this.btnOpen = new System.Windows.Forms.Button();
			this.btnPause = new System.Windows.Forms.Button();
			this.btnPlay = new System.Windows.Forms.Button();
			this.btnStop = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.btnNext = new System.Windows.Forms.Button();
			this.Player = new AxWMPLib.AxWindowsMediaPlayer();
			((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
			this.SuspendLayout();
			// 
			// listBox
			// 
			this.listBox.BackColor = System.Drawing.Color.DodgerBlue;
			this.listBox.FormattingEnabled = true;
			this.listBox.Location = new System.Drawing.Point(0, 0);
			this.listBox.Name = "listBox";
			this.listBox.Size = new System.Drawing.Size(109, 303);
			this.listBox.TabIndex = 1;
			this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
			// 
			// btnOpen
			// 
			this.btnOpen.BackColor = System.Drawing.Color.Yellow;
			this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnOpen.Location = new System.Drawing.Point(698, 985);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.Size = new System.Drawing.Size(102, 33);
			this.btnOpen.TabIndex = 2;
			this.btnOpen.Text = "File Open";
			this.btnOpen.UseVisualStyleBackColor = false;
			this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
			// 
			// btnPause
			// 
			this.btnPause.BackColor = System.Drawing.Color.Pink;
			this.btnPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnPause.Location = new System.Drawing.Point(0, 985);
			this.btnPause.Name = "btnPause";
			this.btnPause.Size = new System.Drawing.Size(109, 33);
			this.btnPause.TabIndex = 3;
			this.btnPause.Text = "Pause";
			this.btnPause.UseVisualStyleBackColor = false;
			this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
			// 
			// btnPlay
			// 
			this.btnPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnPlay.BackColor = System.Drawing.Color.GreenYellow;
			this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnPlay.Location = new System.Drawing.Point(237, 985);
			this.btnPlay.Name = "btnPlay";
			this.btnPlay.Size = new System.Drawing.Size(84, 33);
			this.btnPlay.TabIndex = 4;
			this.btnPlay.Text = "Play";
			this.btnPlay.UseVisualStyleBackColor = false;
			this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
			// 
			// btnStop
			// 
			this.btnStop.BackColor = System.Drawing.Color.Crimson;
			this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnStop.Location = new System.Drawing.Point(346, 985);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(83, 33);
			this.btnStop.TabIndex = 5;
			this.btnStop.Text = "Stop";
			this.btnStop.UseVisualStyleBackColor = false;
			this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
			// 
			// btnBack
			// 
			this.btnBack.BackColor = System.Drawing.Color.Black;
			this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnBack.ForeColor = System.Drawing.Color.Snow;
			this.btnBack.Location = new System.Drawing.Point(462, 985);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(84, 33);
			this.btnBack.TabIndex = 6;
			this.btnBack.Text = "Back";
			this.btnBack.UseVisualStyleBackColor = false;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// btnNext
			// 
			this.btnNext.BackColor = System.Drawing.Color.Indigo;
			this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnNext.ForeColor = System.Drawing.Color.Snow;
			this.btnNext.Location = new System.Drawing.Point(578, 985);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(85, 33);
			this.btnNext.TabIndex = 7;
			this.btnNext.Text = "Next";
			this.btnNext.UseVisualStyleBackColor = false;
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// Player
			// 
			this.Player.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Player.Enabled = true;
			this.Player.Location = new System.Drawing.Point(0, 0);
			this.Player.Name = "Player";
			this.Player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Player.OcxState")));
			this.Player.Size = new System.Drawing.Size(800, 450);
			this.Player.TabIndex = 0;
			// 
			// Video_or_Music
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnNext);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.btnStop);
			this.Controls.Add(this.btnPlay);
			this.Controls.Add(this.btnPause);
			this.Controls.Add(this.btnOpen);
			this.Controls.Add(this.listBox);
			this.Controls.Add(this.Player);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Video_or_Music";
			this.Text = "Video_or_Music";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.ListBox listBox;
		private System.Windows.Forms.Button btnOpen;
		private System.Windows.Forms.Button btnPause;
		private System.Windows.Forms.Button btnPlay;
		private System.Windows.Forms.Button btnStop;
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.Button btnNext;
		private AxWMPLib.AxWindowsMediaPlayer Player;
	}
}