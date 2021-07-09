using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tic_tac_toe
{
    public partial class GameParamsForm : Form
    {

        public GameParamsForm()
        {
            InitializeComponent();
            radioButton3vs3.Checked = true;
            gameModeComboBox.SelectedIndex = 0;
        }

        private void goGameButton_Click(object sender, EventArgs e)
        {
            var gameSize = radioButton3vs3.Checked ? 3 : 5;
            var gameMode = gameModeComboBox.SelectedItem;

            Form gameForm = Application.OpenForms[0];
            gameForm.Show();
            if (gameForm is GameForm)
            {
                var gameFormWithParams = gameForm as GameForm;
                gameFormWithParams.SetStartParams(gameSize, gameMode);
            }
            this.Close();
        }
    }
}
