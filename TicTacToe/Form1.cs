using System;
using System.Collections;
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
		private Boolean playerOneTurn;
		
		private PictureBox[] boxes = new PictureBox[9];//box order is UL, UM, UR, ML, MM, MR, LL, LM, LR

		private int[][] grid = new int[3][];


		public Form1()
		{
			InitializeComponent();
		}

		#region PlayerOptions
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
#endregion

		#region StartAndReset
		private void ResetBoxes()
		{
			
			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					grid[i][j] = -1;
				}
			}

			foreach(PictureBox p in boxes)
			{
				p.Image = null;
				p.Invalidate();
				p.Enabled = true;
			}

		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < 3; i++)
			{
				grid[i] = new int[3];
			}

			DrawGameBoard();
			ResetBoxes();
			StartGame();
		}

		private void startGameToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if(btnStart.Enabled)
			{
				btnStart_Click(sender, e);
			}
			else
			{
				MessageBox.Show("Game already in progress.");
			}
		}

		private void StartGame()
		{
			Boolean twoPlayers = this.optionTwoPlayers.Checked;

			if (!twoPlayers)
			{
				MessageBox.Show("Sorry, we don't have a computer opponent up and running yet!");
			}
			else
			{
				btnReset.Enabled = true;
				btnStart.Enabled = false;
				
				int goesFirst = ChooseFirstPlayer();
				if(goesFirst == 1)
				{
					playerOneTurn = true;
					MessageBox.Show("Player one goes first.", "Coin Flip");
				}
				else
				{
					playerOneTurn = false;
					MessageBox.Show("Player two goes first.", "Coin Flip");
				}

				DisplayPlayerTurn();
			}


		}
#endregion




		private void DisplayPlayerTurn()
		{
			if (playerOneTurn)
			{
				PlayerOneGo();
			}
			else
			{
				PlayerTwoGo();
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

		private Boolean CheckForWinner()
		{
			for(int i = 0; i < 3; i++)
			{
				if(grid[i][0] > 0 && grid[i][0] == grid[i][1] && grid[i][0] == grid[i][2])
				{
					return true;
				}
				if(grid[0][i] > 0 && grid[0][i] == grid[1][i] && grid[0][i] == grid[2][i])
				{
					return true;
				}

			}
			if (grid[1][1] > 0 && grid[0][0] == grid[1][1] && grid[1][1] == grid[2][2])
			{
				return true;
			}
			if (grid[1][1] > 0 && grid[2][0] == grid[1][1] && grid[1][1] == grid[0][2])
			{
				return true;
			}

			return false;
		}

		private Boolean CheckForDraw()
		{
			Boolean draw = true;

			for(int i = 0; i < 3; i++)
			{
				for(int j = 0; j < 3; j++)
				{
					if(grid[i][j] < 0)
					{
						draw = false;
					}
				}
			}
			return draw;
		}

		private void DrawGameBoard()
		{
			System.Drawing.Pen boardPen = new System.Drawing.Pen(Color.ForestGreen, 20);
			g = pictureBox1.CreateGraphics();
			g.DrawLine(boardPen, 137, 20, 137, 380);
			g.DrawLine(boardPen, 262, 20, 262, 380);
			g.DrawLine(boardPen, 20, 137, 380, 137);
			g.DrawLine(boardPen, 20, 262, 380, 262);

			this.picLL.Visible = true;
			this.picLM.Visible = true;
			this.picLR.Visible = true;
			this.picML.Visible = true;
			this.picMM.Visible = true;
			this.picMR.Visible = true;
			this.picUL.Visible = true;
			this.picUM.Visible = true;
			this.picUR.Visible = true;


			boxes[0] = picUL;
			boxes[1] = picUM;
			boxes[2] = picUR;

			boxes[3] = picML;
			boxes[4] = picMM;
			boxes[5] = picMR;

			boxes[6] = picLL;
			boxes[7] = picLM;
			boxes[8] = picLR;


		}

		private int ChooseFirstPlayer()
		{
			Random rnd = new Random();
			return (rnd.Next(100) % 2)+1;
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}

		#region pictureBoxClicks
		private void picUL_Click(object sender, EventArgs e)
		{
			UpdateGrid(0, 0);
			DrawOnBoard(sender);
		}

		private void picUM_Click(object sender, EventArgs e)
		{
			UpdateGrid(0, 1);
			DrawOnBoard(sender);
		}

		private void picUR_Click(object sender, EventArgs e)
		{
			UpdateGrid(0, 2);
			DrawOnBoard(sender);
		}

		private void picML_Click(object sender, EventArgs e)
		{
			UpdateGrid(1, 0);
			DrawOnBoard(sender);
		}

		private void picMM_Click(object sender, EventArgs e)
		{
			UpdateGrid(1, 1);
			DrawOnBoard(sender);

		}

		private void picMR_Click(object sender, EventArgs e)
		{
			UpdateGrid(1, 2);
			DrawOnBoard(sender);

		}

		private void picLL_Click(object sender, EventArgs e)
		{
			UpdateGrid(2, 0);
			DrawOnBoard(sender);

		}

		private void picLM_Click(object sender, EventArgs e)
		{
			UpdateGrid(2, 1);
			DrawOnBoard(sender);
		}

		private void picLR_Click(object sender, EventArgs e)
		{
			UpdateGrid(2, 2);
			DrawOnBoard(sender);
		}
		#endregion

		private void UpdateGrid(int v1, int v2)
		{
			if(playerOneTurn)
			{
				grid[v1][v2] = 1;
			}
			else
			{
				grid[v1][v2] = 2;
			}
		}

		private void DrawOnBoard(object sender)
		{
			
			if (this.playerOneTurn)
			{
				DrawX(sender);
			}
			else
			{
				DrawO(sender);
			}

			if(CheckForWinner())
			{
				if(playerOneTurn)
				{
					MessageBox.Show("Player One wins! Congratulations!");
					this.txtOut.Text = "Player One wins!";
				}
				else
				{
					MessageBox.Show("Player Two wins! Congratulations!");
					this.txtOut.Text = "Player Two wins!";
				}
			}
			else if(CheckForDraw())
			{
				MessageBox.Show("It's a draw!");
				this.txtOut.Text = "Draw!";
			}
			else
			{
				NextPlayer();
			}

			
		}

		private void NextPlayer()
		{
			playerOneTurn = !playerOneTurn;
			DisplayPlayerTurn();
		}

		private void DrawO(object sender)
		{
			System.Drawing.Pen oPen = new System.Drawing.Pen(Color.Blue, 10);
			PictureBox toDraw = (PictureBox)sender;
			toDraw.Enabled = false;
			g = toDraw.CreateGraphics();
			g.DrawEllipse(oPen, 8, 8, toDraw.Width - 20, toDraw.Width - 20);
		}

		private void DrawX(object sender)
		{
			System.Drawing.Pen xPen = new System.Drawing.Pen(Color.Red, 10);
			PictureBox toDraw = (PictureBox)sender;
			toDraw.Enabled = false;
			g = toDraw.CreateGraphics();
			g.DrawLine(xPen, 10, 10, toDraw.Width-20, toDraw.Width - 20);
			g.DrawLine(xPen, 10, toDraw.Width - 20, toDraw.Width - 20, 10);
			

		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			ResetBoxes();
			btnReset.Enabled = false;
			btnStart.Enabled = true;
		}

		private void howToPlayToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("The game is Tic Tac Toe, the goal is three in a row.\nPlayer One - X\nPlayer Two - O\nPlayers alternate placing X's and O's, and if somebody gets 3 in a row, they win.");
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Created by Alex McCanna for CSCD 371 at EWU.");
		}
	}
	

}
