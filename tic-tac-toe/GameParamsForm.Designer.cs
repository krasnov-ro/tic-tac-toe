
namespace tic_tac_toe
{
    partial class GameParamsForm
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
            this.goGameButton = new System.Windows.Forms.Button();
            this.radioButton3vs3 = new System.Windows.Forms.RadioButton();
            this.radioButton5vs5 = new System.Windows.Forms.RadioButton();
            this.gameModeComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // goGameButton
            // 
            this.goGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goGameButton.Location = new System.Drawing.Point(117, 411);
            this.goGameButton.Name = "goGameButton";
            this.goGameButton.Size = new System.Drawing.Size(75, 27);
            this.goGameButton.TabIndex = 0;
            this.goGameButton.Text = "Начать";
            this.goGameButton.UseVisualStyleBackColor = true;
            this.goGameButton.Click += new System.EventHandler(this.goGameButton_Click);
            // 
            // radioButton3vs3
            // 
            this.radioButton3vs3.AutoSize = true;
            this.radioButton3vs3.Location = new System.Drawing.Point(29, 39);
            this.radioButton3vs3.Name = "radioButton3vs3";
            this.radioButton3vs3.Size = new System.Drawing.Size(80, 19);
            this.radioButton3vs3.TabIndex = 2;
            this.radioButton3vs3.TabStop = true;
            this.radioButton3vs3.Text = " игра 3 х 3";
            this.radioButton3vs3.UseVisualStyleBackColor = true;
            // 
            // radioButton5vs5
            // 
            this.radioButton5vs5.AutoSize = true;
            this.radioButton5vs5.Location = new System.Drawing.Point(186, 39);
            this.radioButton5vs5.Name = "radioButton5vs5";
            this.radioButton5vs5.Size = new System.Drawing.Size(77, 19);
            this.radioButton5vs5.TabIndex = 3;
            this.radioButton5vs5.TabStop = true;
            this.radioButton5vs5.Text = "игра 5 х 5";
            this.radioButton5vs5.UseVisualStyleBackColor = true;
            // 
            // gameModeComboBox
            // 
            this.gameModeComboBox.FormattingEnabled = true;
            this.gameModeComboBox.Items.AddRange(new object[] {
            "Копьютер против игрока",
            "Два игрока",
            "Компьютер против компьютера"});
            this.gameModeComboBox.Location = new System.Drawing.Point(29, 74);
            this.gameModeComboBox.Name = "gameModeComboBox";
            this.gameModeComboBox.Size = new System.Drawing.Size(234, 23);
            this.gameModeComboBox.TabIndex = 4;
            // 
            // GameParamsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(307, 450);
            this.Controls.Add(this.gameModeComboBox);
            this.Controls.Add(this.radioButton5vs5);
            this.Controls.Add(this.radioButton3vs3);
            this.Controls.Add(this.goGameButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GameParamsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameParams";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goGameButton;
        private System.Windows.Forms.RadioButton radioButton3vs3;
        private System.Windows.Forms.RadioButton radioButton5vs5;
        private System.Windows.Forms.ComboBox gameModeComboBox;
    }
}