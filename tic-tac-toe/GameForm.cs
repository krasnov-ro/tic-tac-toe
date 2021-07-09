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

        public void SetStartParams(int gameSize, object gameMode)
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
                case "Копьютер против игрока":
                    break;

                case "Два игрока":
                    break;

                case "Компьютер против компьютера":
                    break;
            }
        }
    }
}
