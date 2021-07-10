using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tic_tac_toe.Code.Enums;
using tic_tac_toe.Properties;

namespace tic_tac_toe
{
    public partial class GameForm : Form
    {
        private Button[,] ThreeVsThreeWinIf;

        private Button[,] FiveVsFiveWinIf;
        private int GameSize { get; set; }
        private object GameMode { get; set; }
        private int PlayerNumber { get; set; }
        private bool WhoIsFirst { get; set; }

        public GameForm()
        {
            InitializeComponent();
            HideOrShowButtons(ShowOrHide.Hide);
        }

        public void SetStartParams(int gameSize, int gameMode)
        {
            Random gen = new Random();
            ThreeVsThreeWinIf = new Button[8, 3] {
                    { button1, button2, button3 },  { button1, button4, button7 }, { button1, button5, button9 },
                    { button4, button5, button6 },  { button2, button5, button8 }, { button7, button5, button3 },
                    { button7, button8, button9 },  { button3, button6, button9 }
            };
            FiveVsFiveWinIf = new Button[12, 5]{
                { button1,  button2,  button3,  button4,  button5 },  { button1, button6, button11, button16, button21}, {button1, button7, button13, button19, button25},
                { button6,  button7,  button8,  button9,  button10 }, { button2, button7, button12, button17, button22}, {button21, button17, button13, button9, button5},
                { button11, button12, button13, button14, button15 }, { button3, button8, button13, button18, button23},
                { button16, button17, button18, button19, button20 }, { button4, button9, button14, button19, button24},
                { button21, button22, button23, button24, button25 }, { button5, button10, button15, button20, button25}
            };
            this.GameSize = gameSize;
            this.GameMode = gameMode;
            goGameButton.Visible = false;
            PlayerNumber = gen.Next(100) < 50 ? 1 : 2;
            LetsGo();
            RefreshBattlefield(null);
        }

        private void goGameButton_Click(object sender, EventArgs e)
        {
            GameParamsForm gameParamsForm = new GameParamsForm();
            gameParamsForm.Show();
            this.Hide();
        }

        private void startOverButton_Click(object sender, EventArgs e)
        {
            HideOrShowButtons(ShowOrHide.Hide);
            GameParamsForm gameParamsForm = new GameParamsForm();
            gameParamsForm.Show();
            this.Hide();
        }

        private void LetsGo()
        {
            HideOrShowButtons(ShowOrHide.Show);

            if (GameSize == 3)
            {
                this.BackgroundImage = Resources.background;
                this.BackgroundImageLayout = ImageLayout.Center;
                SetButtonPositions();
            }
            else
            {
                this.BackgroundImage = Resources.background5x51;
                this.BackgroundImageLayout = ImageLayout.Center;
                SetButtonPositions();
            }

            if (WhoIsFirst)
            {
                BotStep();
            }
        }

        private void BotStep()
        {
            switch (GameMode)
            {
                case 0: //"Копьютер против игрока"
                    if (WhoIsFirst)
                    {
                        Random rnd = new Random();
                        var botStepNumber = rnd.Next(1, GameSize * GameSize);
                        var buttons = this.Controls;
                        buttons[botStepNumber].BackgroundImage = Resources.zero;
                    }
                    else
                    {
                        gameStatusLabel.Text = "Ходит игрок";
                    }
                    break;

                case 1: // "Два игрока"
                    break;

                case 2: // "Компьютер против компьютера"
                    break;
            }
        }

        /// <summary>
        /// Обновление или замарозка поля
        /// </summary>
        /// <param name="win"></param>
        private void RefreshBattlefield(bool? win)
        {
            if (win != null)
            {
                foreach (var contol in this.Controls)
                {
                    if ((contol is Button))
                    {
                        var button = contol as Button;
                        if (button != goGameButton && button != startOverButton)
                        {
                            button.Enabled = false;
                        }
                    }
                }
            }

            else
            {
                foreach (var contol in this.Controls)
                {
                    if ((contol is Button))
                    {
                        var button = contol as Button;
                        if (button != goGameButton && button != startOverButton)
                        {
                            button.BackgroundImage = null;
                            button.Enabled = true;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Правильная перестановка кнопок по полю
        /// </summary>
        private void SetButtonPositions()
        {
            if (GameSize == 3)
            {
                button5.Location = new Point((this.Width / 2) - button5.Width + 33, (this.Height / 2) - button5.Height + 14);
                button4.Location = new Point(button5.Location.X - button4.Width - 30, button5.Location.Y);
                button6.Location = new Point(button5.Location.X + button6.Width + 30, button5.Location.Y);
                button8.Location = new Point(button5.Location.X, button5.Location.Y + button8.Height + 30);
                button7.Location = new Point(button4.Location.X, button8.Location.Y);
                button9.Location = new Point(button6.Location.X, button8.Location.Y);
                button2.Location = new Point(button5.Location.X, button5.Location.Y - button2.Height - 30);
                button3.Location = new Point(button6.Location.X, button2.Location.Y);
                button1.Location = new Point(button4.Location.X, button2.Location.Y);
            }
            if (GameSize == 5)
            {
                button5.Location = new Point(button10.Location.X, button10.Location.Y - button5.Height - 30);
                button1.Location = new Point(button11.Location.X, button5.Location.Y);
                button2.Location = new Point(button12.Location.X, button5.Location.Y);
                button3.Location = new Point(button13.Location.X, button5.Location.Y);
                button4.Location = new Point(button14.Location.X, button5.Location.Y);
                button9.Location = new Point(button14.Location.X, button10.Location.Y);
                button6.Location = new Point(button11.Location.X, button10.Location.Y);
                button7.Location = new Point(button12.Location.X, button10.Location.Y);
                button8.Location = new Point(button13.Location.X, button10.Location.Y);
            }
        }

        /// <summary>
        /// Скрываем или показываем кнопки
        /// </summary>
        /// <param name="showOrHide"></param>
        private void HideOrShowButtons(ShowOrHide showOrHide)
        {
            if (showOrHide == ShowOrHide.Hide)
            {
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                button7.Visible = false;
                button8.Visible = false;
                button9.Visible = false;
                button10.Visible = false;
                button11.Visible = false;
                button12.Visible = false;
                button13.Visible = false;
                button14.Visible = false;
                button15.Visible = false;
                button16.Visible = false;
                button17.Visible = false;
                button18.Visible = false;
                button19.Visible = false;
                button20.Visible = false;
                button21.Visible = false;
                button22.Visible = false;
                button23.Visible = false;
                button24.Visible = false;
                button25.Visible = false;
            }
            else if (showOrHide == ShowOrHide.Show)
            {
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = true;
                button7.Visible = true;
                button8.Visible = true;
                button9.Visible = true;
                if (GameSize == 5)
                {
                    button10.Visible = true;
                    button11.Visible = true;
                    button12.Visible = true;
                    button13.Visible = true;
                    button14.Visible = true;
                    button15.Visible = true;
                    button16.Visible = true;
                    button17.Visible = true;
                    button18.Visible = true;
                    button19.Visible = true;
                    button20.Visible = true;
                    button21.Visible = true;
                    button22.Visible = true;
                    button23.Visible = true;
                    button24.Visible = true;
                    button25.Visible = true;
                }
            }
        }
        private void Click(object sender, EventArgs e)
        {
            switch (GameMode)
            {
                case 0: //"Копьютер против игрока"
                    break;

                case 1: // "Два игрока"
                    if (PlayerNumber == 1)
                    {
                        sender.GetType().GetProperty("BackgroundImage").SetValue(sender, Resources.zero);
                        PlayerNumber = 2;
                    }
                    else if (PlayerNumber == 2)
                    {
                        sender.GetType().GetProperty("BackgroundImage").SetValue(sender, Resources.cross);
                        PlayerNumber = 1;
                    }
                    sender.GetType().GetProperty("Enabled").SetValue(sender, false);
                    var winOrNo = CheckWinner();
                    if (winOrNo)
                    {
                        MessageBox.Show($"Выиграл игрок №{PlayerNumber}");
                        RefreshBattlefield(winOrNo);
                    }
                    break;

                case 2: // "Компьютер против компьютера"
                    break;
            }
        }

        /// <summary>
        /// Проверка выигрыша
        /// </summary>
        /// <returns></returns>
        private bool CheckWinner()
        {
            var buttonsIdArr = GameSize == 3 ? ThreeVsThreeWinIf : FiveVsFiveWinIf;
            bool result = false;
            int iterations = GameSize == 3 ? 8 : 12;
            for (int i = 0; i < iterations; ++i)
            {
                result = true;
                for (int j = 0; j < GameSize; ++j)
                {
                    if (buttonsIdArr[i,j].BackgroundImage?.Width != Resources.cross.Width)
                    {
                        result = false;
                        break;
                    }
                }
                if (result)
                    return result;

                result = true;
                for (int j = 0; j < GameSize; ++j)
                {
                    if (buttonsIdArr[i, j].BackgroundImage?.Width != Resources.zero.Width)
                    {
                        result = false;
                        break;
                    }
                }
                if (result)
                    return result;
            }
            return result;
        }
    }
}
