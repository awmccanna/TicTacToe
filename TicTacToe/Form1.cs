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
/*
 * Tic Tac Toe
 * Alex McCanna
 * CSCD 371
 * This can be played as single player or two player
 * Single player computer is pretty basic, and will occasionally make a good play but is "dumb" for the most part
 * 
 */
namespace TicTacToe
{
	public partial class Form1 : Form
	{
		private System.Drawing.Graphics g;
		private Boolean playerOneTurn, twoPlayers, gameInProgress;
		
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
			twoPlayers = this.optionTwoPlayers.Checked;
			gameInProgress = true;
			if(!twoPlayers)
			{
				MessageBox.Show("The computer will be Player Two");
			}

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
		private void PlayerOneGo()
		{
			this.txtOut.Text = "Player Ones turn to go!";
		}
		private void PlayerTwoGo()
		{
			this.txtOut.Text = "Player Twos turn to go!";
			if(!twoPlayers)
			{
				ComputerTurn();
			}
		}

		/*
		 * This is the code for the "AI"
		 * It will be ugly
		 */
		private void ComputerTurn()
		{
			if (picMM.Enabled)
			{
				picMM_Click(picMM, null);
				return;
			}
			for (int i = 0; i < 3; i++)
			{
				//First check is to see if any columns are going to be filled by either person. Will block or win
				if (grid[i][0] < 0 && grid[i][1] == grid[i][2])//Is top not filled, but bottom two are
				{
					if(i == 0 && picUL.Enabled)
					{
						picUL_Click(picUL, null);//Upper left box
						return;
					}
					else if( i == 1 && picUM.Enabled)
					{
						picUM_Click(picUM, null);//Upper middle box
						return;
					}
					else if(i == 2 && picUR.Enabled)
					{
						picUR_Click(picUR, null);//Upper right box. Told you it would be ugly
						return;
					}
				}
				else if(grid[i][1] < 0 && grid[i][0] == grid[i][2])//Is middle empty, but top and bottom are filled
				{
					if (i == 0 && picML.Enabled)
					{
						picML_Click(picML, null);//Middle left box
						return;
					}
					else if (i == 1 && picMM.Enabled)
					{
						picMM_Click(picMM, null);//Middle middle box
						return;
					}
					else if (i == 2 && picMR.Enabled)
					{
						picMR_Click(picMR, null);//Middle right box
						return;
					}
				}
				else if(grid[i][2] < 0 && grid[i][1] == grid[i][0])//Is bottom empty but top two aren't
				{
					if (i == 0 && picLL.Enabled)
					{
						picLL_Click(picLL, null);//Lower left box
						return;
					}
					else if (i == 1 && picLM.Enabled)
					{
						picLM_Click(picLM, null);//Lower middle box
						return;
					}
					else if (i == 2 && picLR.Enabled)
					{
						picLR_Click(picLR, null);//Lower right box
						return;
					}
				}




				//Now check if any of the rows are about to be filled
				if (grid[0][i] < 0 && grid[1][i] == grid[2][i])//Left box not filled
				{
					if (i == 0 && picUL.Enabled)
					{
						picUL_Click(picUL, null);//Upper left box
						return;
					}
					else if (i == 1 && picML.Enabled)
					{
						picML_Click(picML, null);//Middle left box
						return;
					}
					else if (i == 2 && picLL.Enabled)
					{
						picLL_Click(picLL, null);//Lower left box
						return;
					}
				}
				else if (grid[1][i] < 0 && grid[0][i] == grid[2][i])//Middle box not filled
				{
					if (i == 0 && picUM.Enabled)
					{
						picUM_Click(picUM, null);//Upper Middle box
						return;
					}
					else if (i == 1 && picMM.Enabled)
					{
						picMM_Click(picMM, null);//Middle Middle box
						return;
					}
					else if (i == 2 && picLM.Enabled)
					{
						picLM_Click(picLM, null);//Lower Middle box
						return;
					}
				}
				else if (grid[2][i] < 0 && grid[0][i] == grid[1][i])
				{
					if (i == 0 && picUR.Enabled)
					{
						picUR_Click(picUR, null);//Upper Right box
						return;
					}
					else if (i == 1 && picMR.Enabled)
					{
						picMR_Click(picMR, null);//Middle Right box
						return;
					}
					else if (i == 2 && picLR.Enabled)
					{
						picLR_Click(picLR, null);//Lower Right box
						return;
					}
				}

			}
			if(grid[0][0] < 0 && grid[1][1] == grid[2][2] && picUL.Enabled)
			{
				picUL_Click(picUL, null);//Upper Left
				return;
			}
			if (grid[1][1] < 0 && grid[0][0] == grid[2][2] && picMM.Enabled)
			{
				picMM_Click(picMM, null);//Middle Middle
				return;
			}
			if (grid[1][1] < 0 && grid[0][0] == grid[2][2] && picLR.Enabled)
			{
				picLR_Click(picLR, null);//Lower Right
				return;
			}
			if (grid[0][2] < 0 && grid[2][0] == grid[1][1] && picLL.Enabled)
			{
				picLL_Click(picLL, null);//Lower left
				return;
			}
			if (grid[1][1] < 0 && grid[2][0] == grid[0][2] && picMM.Enabled)
			{
				picMM_Click(picMM, null);//Middle middle
				return;
			}
			if (grid[2][0] < 0 && grid[0][2] == grid[1][1] && picUR.Enabled)
			{
				picUR_Click(picUR, null);//Upper right
				return;
			}


			//Everything above is the "smart" decision making. Everything below here will be the straight brute force stuff.
			//Even uglier if you can believe it

			
			if(picUL.Enabled)
			{
				picUL_Click(picUL, null);
				return;
			}
			if (picUM.Enabled)
			{
				picUM_Click(picUM, null);
				return;
			}
			if (picLR.Enabled)
			{
				picLR_Click(picLR, null);
				return;
			}
			if (picLL.Enabled)
			{
				picLL_Click(picLL, null);
				return;
			}
			if (picMR.Enabled)
			{
				picMR_Click(picMR, null);
				return;
			}
			if (picUR.Enabled)
			{
				picUR_Click(picUR, null);
				return;
			}
			if (picML.Enabled)
			{
				picML_Click(picML, null);
				return;
			}
			if (picLM.Enabled)
			{
				picLM_Click(picLM, null);
				return;
			}

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
					gameInProgress = false;
				}
				else
				{
					MessageBox.Show("Player Two wins! Congratulations!");
					this.txtOut.Text = "Player Two wins!";
					gameInProgress = false;
				}
			}
			else if(CheckForDraw())
			{
				MessageBox.Show("It's a draw!");
				this.txtOut.Text = "Draw!";
				gameInProgress = false;
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
			MessageBox.Show("The game is Tic Tac Toe, the goal is three in a row.\nPlayer One - X\nPlayer Two - O\n" +
							"Players alternate placing X's and O's, and if somebody gets 3 in a row, they win.\n" +
							"If Start is greyed out, press Reset to be able to start a new game.");
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Created by Alex McCanna for CSCD 371 at EWU.");
		}
	}
	

}
