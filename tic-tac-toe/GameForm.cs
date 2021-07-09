using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tic_tac_toe.Properties;

namespace tic_tac_toe
{
    public partial class GameForm : Form
    {
        private int gameSize { get; set; }
        private object gameMode { get; set; }

        private bool whoIsFirst { get; set; }

        public GameForm()
        {
            InitializeComponent();
        }

        public void SetStartParams(int gameSize, int gameMode)
        {
            Random gen = new Random();
            this.gameSize = gameSize;
            this.gameMode = gameMode;
            goGameButton.Visible = false;
            this.BackgroundImage = Resources.background;
            bool whoIsFirst = gen.Next(100) < 50 ? true : false;
            LetsGo();
        }

        private void goGameButton_Click(object sender, EventArgs e)
        {
            GameParamsForm gameParamsForm = new GameParamsForm();
            gameParamsForm.Show();
            this.Hide();
        }

        private void LetsGo()
        {
            switch (gameMode)
            {
                case 0: //"Копьютер против игрока"
                    break;

                case 1: // "Два игрока"
                    break;

                case 2: // "Компьютер против компьютера"
                    break;
            }
        }

        private void Click(Button button)
        {
            //if() 
        }

        #region Обработка нажатий 
        private void button1_Click(object sender, EventArgs e)
        {
            Click(sender as Button);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Click(sender as Button);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Click(sender as Button);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Click(sender as Button);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Click(sender as Button);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Click(sender as Button);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Click(sender as Button);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Click(sender as Button);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Click(sender as Button);
        }
        #endregion
    }
}
