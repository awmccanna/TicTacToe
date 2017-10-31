namespace TicTacToe
{
	partial class Form1
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.startGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.playersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.optionOnePlayer = new System.Windows.Forms.ToolStripMenuItem();
			this.optionTwoPlayers = new System.Windows.Forms.ToolStripMenuItem();
			this.btnStart = new System.Windows.Forms.Button();
			this.btnReset = new System.Windows.Forms.Button();
			this.txtOut = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.pictureBox9 = new System.Windows.Forms.PictureBox();
			this.pictureBox10 = new System.Windows.Forms.PictureBox();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(484, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startGameToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// startGameToolStripMenuItem
			// 
			this.startGameToolStripMenuItem.Name = "startGameToolStripMenuItem";
			this.startGameToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.startGameToolStripMenuItem.Text = "&Start Game";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.exitToolStripMenuItem.Text = "&Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// settingsToolStripMenuItem
			// 
			this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playersToolStripMenuItem});
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.settingsToolStripMenuItem.Text = "Se&ttings";
			// 
			// playersToolStripMenuItem
			// 
			this.playersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionOnePlayer,
            this.optionTwoPlayers});
			this.playersToolStripMenuItem.Name = "playersToolStripMenuItem";
			this.playersToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.playersToolStripMenuItem.Text = "Pla&yers";
			// 
			// optionOnePlayer
			// 
			this.optionOnePlayer.Name = "optionOnePlayer";
			this.optionOnePlayer.Size = new System.Drawing.Size(152, 22);
			this.optionOnePlayer.Text = "One player";
			this.optionOnePlayer.Click += new System.EventHandler(this.optionOnePlayer_Click);
			// 
			// optionTwoPlayers
			// 
			this.optionTwoPlayers.Checked = true;
			this.optionTwoPlayers.CheckState = System.Windows.Forms.CheckState.Checked;
			this.optionTwoPlayers.Name = "optionTwoPlayers";
			this.optionTwoPlayers.Size = new System.Drawing.Size(152, 22);
			this.optionTwoPlayers.Text = "Two players";
			this.optionTwoPlayers.Click += new System.EventHandler(this.optionTwoPlayers_Click);
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(216, 498);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(80, 28);
			this.btnStart.TabIndex = 2;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// btnReset
			// 
			this.btnReset.Location = new System.Drawing.Point(302, 498);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(81, 28);
			this.btnReset.TabIndex = 3;
			this.btnReset.Text = "Reset";
			this.btnReset.UseVisualStyleBackColor = true;
			// 
			// txtOut
			// 
			this.txtOut.BackColor = System.Drawing.SystemColors.Control;
			this.txtOut.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtOut.Location = new System.Drawing.Point(9, 472);
			this.txtOut.Multiline = true;
			this.txtOut.Name = "txtOut";
			this.txtOut.Size = new System.Drawing.Size(222, 54);
			this.txtOut.TabIndex = 4;
			this.txtOut.Text = "Press Start to begin game.";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Location = new System.Drawing.Point(42, 42);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(400, 400);
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Location = new System.Drawing.Point(67, 67);
			this.pictureBox3.Margin = new System.Windows.Forms.Padding(5);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(100, 100);
			this.pictureBox3.TabIndex = 7;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Location = new System.Drawing.Point(192, 67);
			this.pictureBox2.Margin = new System.Windows.Forms.Padding(5);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(100, 100);
			this.pictureBox2.TabIndex = 8;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Location = new System.Drawing.Point(317, 67);
			this.pictureBox4.Margin = new System.Windows.Forms.Padding(5);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(100, 100);
			this.pictureBox4.TabIndex = 9;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox5
			// 
			this.pictureBox5.Location = new System.Drawing.Point(67, 192);
			this.pictureBox5.Margin = new System.Windows.Forms.Padding(5);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(100, 100);
			this.pictureBox5.TabIndex = 10;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox6
			// 
			this.pictureBox6.Location = new System.Drawing.Point(192, 192);
			this.pictureBox6.Margin = new System.Windows.Forms.Padding(5);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(100, 100);
			this.pictureBox6.TabIndex = 11;
			this.pictureBox6.TabStop = false;
			// 
			// pictureBox7
			// 
			this.pictureBox7.Location = new System.Drawing.Point(317, 192);
			this.pictureBox7.Margin = new System.Windows.Forms.Padding(5);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(100, 100);
			this.pictureBox7.TabIndex = 12;
			this.pictureBox7.TabStop = false;
			// 
			// pictureBox8
			// 
			this.pictureBox8.Location = new System.Drawing.Point(67, 317);
			this.pictureBox8.Margin = new System.Windows.Forms.Padding(5);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(100, 100);
			this.pictureBox8.TabIndex = 13;
			this.pictureBox8.TabStop = false;
			// 
			// pictureBox9
			// 
			this.pictureBox9.Location = new System.Drawing.Point(192, 317);
			this.pictureBox9.Margin = new System.Windows.Forms.Padding(5);
			this.pictureBox9.Name = "pictureBox9";
			this.pictureBox9.Size = new System.Drawing.Size(100, 100);
			this.pictureBox9.TabIndex = 14;
			this.pictureBox9.TabStop = false;
			// 
			// pictureBox10
			// 
			this.pictureBox10.Location = new System.Drawing.Point(317, 317);
			this.pictureBox10.Margin = new System.Windows.Forms.Padding(5);
			this.pictureBox10.Name = "pictureBox10";
			this.pictureBox10.Size = new System.Drawing.Size(100, 100);
			this.pictureBox10.TabIndex = 15;
			this.pictureBox10.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(484, 561);
			this.Controls.Add(this.pictureBox10);
			this.Controls.Add(this.pictureBox9);
			this.Controls.Add(this.pictureBox8);
			this.Controls.Add(this.pictureBox7);
			this.Controls.Add(this.pictureBox6);
			this.Controls.Add(this.pictureBox5);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.txtOut);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Form1";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem startGameToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem playersToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem optionOnePlayer;
		private System.Windows.Forms.ToolStripMenuItem optionTwoPlayers;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.TextBox txtOut;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.PictureBox pictureBox7;
		private System.Windows.Forms.PictureBox pictureBox8;
		private System.Windows.Forms.PictureBox pictureBox9;
		private System.Windows.Forms.PictureBox pictureBox10;
	}
}

