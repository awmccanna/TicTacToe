using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
	public partial class Form1 : Form
	{
		private System.Drawing.Graphics g;
		public Form1()
		{
			InitializeComponent();
		}

		private void optionOnePlayer_Click(object sender, EventArgs e)
		{
			if(!this.optionOnePlayer.Checked)
			{
				this.optionOnePlayer.Checked = true;
				this.optionTwoPlayers.Checked = false;
			}
		}

		private void optionTwoPlayers_Click(object sender, EventArgs e)
		{
			if (!this.optionTwoPlayers.Checked)
			{
				this.optionOnePlayer.Checked = false;
				this.optionTwoPlayers.Checked = true;
			}
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			this.StartGame();
		}

		private void StartGame()
		{
			Boolean twoPlayers = this.optionTwoPlayers.Checked;
			Boolean winner = false;
			Boolean playerOneTurn;

			if(!twoPlayers)
			{
				MessageBox.Show("Sorry, we don't have a computer opponent up and running yet!");
			}
			else
			{
				DrawGameBoard();
				int goesFirst = ChooseFirstPlayer();
				if(goesFirst == 1)
				{
					playerOneTurn = true;
					MessageBox.Show("Player one goes first.");
				}
				else
				{
					playerOneTurn = false;
					MessageBox.Show("Player two goes first.");
				}

				while(!winner)
				{

					if(playerOneTurn)
					{
						PlayerOneGo();
					}
					else
					{
						PlayerTwoGo();
					}





					winner = CheckForWinner();

				}



			}






		}

		private void PlayerTwoGo()
		{
			this.txtOut.Text = "Player Twos turn to go!";
		}

		private void PlayerOneGo()
		{
			this.txtOut.Text = "Player Ones turn to go!";
		}

		private bool CheckForWinner()
		{
			return true;
		}

		private int ChooseFirstPlayer()
		{
			Random rnd = new Random();
			return (rnd.Next(100) % 2)+1;
		}

		private void DrawGameBoard()
		{
			System.Drawing.Pen boardPen = new System.Drawing.Pen(Color.Black, 6);
			g = pictureBox1.CreateGraphics();
			g.DrawLine(boardPen, 162, 0, 162, 379);
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
