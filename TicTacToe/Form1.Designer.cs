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
			this.picUL = new System.Windows.Forms.PictureBox();
			this.picUM = new System.Windows.Forms.PictureBox();
			this.picUR = new System.Windows.Forms.PictureBox();
			this.picML = new System.Windows.Forms.PictureBox();
			this.picMM = new System.Windows.Forms.PictureBox();
			this.picMR = new System.Windows.Forms.PictureBox();
			this.picLL = new System.Windows.Forms.PictureBox();
			this.picLM = new System.Windows.Forms.PictureBox();
			this.picLR = new System.Windows.Forms.PictureBox();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.howToPlayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picUL)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picUM)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picUR)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picML)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picMM)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picMR)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picLL)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picLM)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picLR)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
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
            this.aboutToolStripMenuItem,
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
			this.startGameToolStripMenuItem.Click += new System.EventHandler(this.startGameToolStripMenuItem_Click);
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
			this.playersToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
			this.playersToolStripMenuItem.Text = "Pla&yers";
			// 
			// optionOnePlayer
			// 
			this.optionOnePlayer.Name = "optionOnePlayer";
			this.optionOnePlayer.Size = new System.Drawing.Size(136, 22);
			this.optionOnePlayer.Text = "One player";
			this.optionOnePlayer.Click += new System.EventHandler(this.optionOnePlayer_Click);
			// 
			// optionTwoPlayers
			// 
			this.optionTwoPlayers.Checked = true;
			this.optionTwoPlayers.CheckState = System.Windows.Forms.CheckState.Checked;
			this.optionTwoPlayers.Name = "optionTwoPlayers";
			this.optionTwoPlayers.Size = new System.Drawing.Size(136, 22);
			this.optionTwoPlayers.Text = "Two players";
			this.optionTwoPlayers.Click += new System.EventHandler(this.optionTwoPlayers_Click);
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(305, 521);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(80, 28);
			this.btnStart.TabIndex = 2;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// btnReset
			// 
			this.btnReset.Enabled = false;
			this.btnReset.Location = new System.Drawing.Point(391, 521);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(81, 28);
			this.btnReset.TabIndex = 3;
			this.btnReset.Text = "Reset";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// txtOut
			// 
			this.txtOut.BackColor = System.Drawing.Color.Honeydew;
			this.txtOut.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtOut.Location = new System.Drawing.Point(9, 480);
			this.txtOut.Multiline = true;
			this.txtOut.Name = "txtOut";
			this.txtOut.Size = new System.Drawing.Size(262, 69);
			this.txtOut.TabIndex = 4;
			this.txtOut.Text = "Press Start to begin game.";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Honeydew;
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Location = new System.Drawing.Point(42, 42);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(400, 400);
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
			// 
			// picUL
			// 
			this.picUL.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.picUL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picUL.Location = new System.Drawing.Point(67, 67);
			this.picUL.Margin = new System.Windows.Forms.Padding(5);
			this.picUL.Name = "picUL";
			this.picUL.Size = new System.Drawing.Size(100, 100);
			this.picUL.TabIndex = 7;
			this.picUL.TabStop = false;
			this.picUL.Visible = false;
			this.picUL.Click += new System.EventHandler(this.picUL_Click);
			// 
			// picUM
			// 
			this.picUM.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.picUM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picUM.Location = new System.Drawing.Point(192, 67);
			this.picUM.Margin = new System.Windows.Forms.Padding(5);
			this.picUM.Name = "picUM";
			this.picUM.Size = new System.Drawing.Size(100, 100);
			this.picUM.TabIndex = 8;
			this.picUM.TabStop = false;
			this.picUM.Visible = false;
			this.picUM.Click += new System.EventHandler(this.picUM_Click);
			// 
			// picUR
			// 
			this.picUR.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.picUR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picUR.Location = new System.Drawing.Point(317, 67);
			this.picUR.Margin = new System.Windows.Forms.Padding(5);
			this.picUR.Name = "picUR";
			this.picUR.Size = new System.Drawing.Size(100, 100);
			this.picUR.TabIndex = 9;
			this.picUR.TabStop = false;
			this.picUR.Visible = false;
			this.picUR.Click += new System.EventHandler(this.picUR_Click);
			// 
			// picML
			// 
			this.picML.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.picML.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picML.Location = new System.Drawing.Point(67, 192);
			this.picML.Margin = new System.Windows.Forms.Padding(5);
			this.picML.Name = "picML";
			this.picML.Size = new System.Drawing.Size(100, 100);
			this.picML.TabIndex = 10;
			this.picML.TabStop = false;
			this.picML.Visible = false;
			this.picML.Click += new System.EventHandler(this.picML_Click);
			// 
			// picMM
			// 
			this.picMM.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.picMM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picMM.Location = new System.Drawing.Point(192, 192);
			this.picMM.Margin = new System.Windows.Forms.Padding(5);
			this.picMM.Name = "picMM";
			this.picMM.Size = new System.Drawing.Size(100, 100);
			this.picMM.TabIndex = 11;
			this.picMM.TabStop = false;
			this.picMM.Visible = false;
			this.picMM.Click += new System.EventHandler(this.picMM_Click);
			// 
			// picMR
			// 
			this.picMR.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.picMR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picMR.Location = new System.Drawing.Point(317, 192);
			this.picMR.Margin = new System.Windows.Forms.Padding(5);
			this.picMR.Name = "picMR";
			this.picMR.Size = new System.Drawing.Size(100, 100);
			this.picMR.TabIndex = 12;
			this.picMR.TabStop = false;
			this.picMR.Visible = false;
			this.picMR.Click += new System.EventHandler(this.picMR_Click);
			// 
			// picLL
			// 
			this.picLL.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.picLL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picLL.Location = new System.Drawing.Point(67, 317);
			this.picLL.Margin = new System.Windows.Forms.Padding(5);
			this.picLL.Name = "picLL";
			this.picLL.Size = new System.Drawing.Size(100, 100);
			this.picLL.TabIndex = 13;
			this.picLL.TabStop = false;
			this.picLL.Visible = false;
			this.picLL.Click += new System.EventHandler(this.picLL_Click);
			// 
			// picLM
			// 
			this.picLM.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.picLM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picLM.Location = new System.Drawing.Point(192, 317);
			this.picLM.Margin = new System.Windows.Forms.Padding(5);
			this.picLM.Name = "picLM";
			this.picLM.Size = new System.Drawing.Size(100, 100);
			this.picLM.TabIndex = 14;
			this.picLM.TabStop = false;
			this.picLM.Visible = false;
			this.picLM.Click += new System.EventHandler(this.picLM_Click);
			// 
			// picLR
			// 
			this.picLR.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.picLR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picLR.Location = new System.Drawing.Point(317, 317);
			this.picLR.Margin = new System.Windows.Forms.Padding(5);
			this.picLR.Name = "picLR";
			this.picLR.Size = new System.Drawing.Size(100, 100);
			this.picLR.TabIndex = 15;
			this.picLR.TabStop = false;
			this.picLR.Visible = false;
			this.picLR.Click += new System.EventHandler(this.picLR_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToPlayToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "&Help";
			// 
			// howToPlayToolStripMenuItem
			// 
			this.howToPlayToolStripMenuItem.Name = "howToPlayToolStripMenuItem";
			this.howToPlayToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.howToPlayToolStripMenuItem.Text = "How To Pla&y";
			this.howToPlayToolStripMenuItem.Click += new System.EventHandler(this.howToPlayToolStripMenuItem_Click);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.aboutToolStripMenuItem.Text = "A&bout";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.Honeydew;
			this.ClientSize = new System.Drawing.Size(484, 561);
			this.Controls.Add(this.picLR);
			this.Controls.Add(this.picLM);
			this.Controls.Add(this.picLL);
			this.Controls.Add(this.picMR);
			this.Controls.Add(this.picMM);
			this.Controls.Add(this.picML);
			this.Controls.Add(this.picUR);
			this.Controls.Add(this.picUM);
			this.Controls.Add(this.picUL);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.txtOut);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Tic Tac Toe";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picUL)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picUM)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picUR)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picML)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picMM)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picMR)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picLL)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picLM)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picLR)).EndInit();
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
		private System.Windows.Forms.PictureBox picUL;
		private System.Windows.Forms.PictureBox picUM;
		private System.Windows.Forms.PictureBox picUR;
		private System.Windows.Forms.PictureBox picML;
		private System.Windows.Forms.PictureBox picMM;
		private System.Windows.Forms.PictureBox picMR;
		private System.Windows.Forms.PictureBox picLL;
		private System.Windows.Forms.PictureBox picLM;
		private System.Windows.Forms.PictureBox picLR;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem howToPlayToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
	}
}

