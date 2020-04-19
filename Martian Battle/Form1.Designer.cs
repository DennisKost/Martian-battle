namespace Martian_Battle
{
    partial class GameForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.StartGameButton = new System.Windows.Forms.Button();
            this.NumbersOfLives = new System.Windows.Forms.ProgressBar();
            this.RetryButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.GameOverLabel = new System.Windows.Forms.Label();
            this.Ship1 = new System.Windows.Forms.TextBox();
            this.Ship2 = new System.Windows.Forms.TextBox();
            this.Ship3 = new System.Windows.Forms.TextBox();
            this.Ship4 = new System.Windows.Forms.TextBox();
            this.Ship5 = new System.Windows.Forms.TextBox();
            this.Ship6 = new System.Windows.Forms.TextBox();
            this.TroopsPicture = new System.Windows.Forms.PictureBox();
            this.Platform = new System.Windows.Forms.TableLayoutPanel();
            this.PointsLabel = new System.Windows.Forms.Label();
            this.MartianBattleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TroopsPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // StartGameButton
            // 
            this.StartGameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StartGameButton.BackColor = System.Drawing.Color.Transparent;
            this.StartGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartGameButton.ForeColor = System.Drawing.Color.Red;
            this.StartGameButton.Location = new System.Drawing.Point(341, 244);
            this.StartGameButton.Name = "StartGameButton";
            this.StartGameButton.Size = new System.Drawing.Size(118, 62);
            this.StartGameButton.TabIndex = 1;
            this.StartGameButton.Text = "Start";
            this.StartGameButton.UseVisualStyleBackColor = false;
            this.StartGameButton.Click += new System.EventHandler(this.StartGameButtonHandler);
            // 
            // NumbersOfLives
            // 
            this.NumbersOfLives.Location = new System.Drawing.Point(353, 530);
            this.NumbersOfLives.Name = "NumbersOfLives";
            this.NumbersOfLives.Size = new System.Drawing.Size(100, 23);
            this.NumbersOfLives.TabIndex = 7;
            this.NumbersOfLives.Value = 100;
            // 
            // RetryButton
            // 
            this.RetryButton.BackColor = System.Drawing.Color.Transparent;
            this.RetryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RetryButton.ForeColor = System.Drawing.Color.Blue;
            this.RetryButton.Location = new System.Drawing.Point(277, 369);
            this.RetryButton.Name = "RetryButton";
            this.RetryButton.Size = new System.Drawing.Size(115, 48);
            this.RetryButton.TabIndex = 8;
            this.RetryButton.Text = "Retry";
            this.RetryButton.UseVisualStyleBackColor = false;
            this.RetryButton.Visible = false;
            this.RetryButton.Click += new System.EventHandler(this.RetryButtonHandler);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.ForeColor = System.Drawing.Color.Fuchsia;
            this.ExitButton.Location = new System.Drawing.Point(418, 369);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(115, 48);
            this.ExitButton.TabIndex = 9;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Visible = false;
            this.ExitButton.Click += new System.EventHandler(this.CloseButtonHandler);
            // 
            // GameOverLabel
            // 
            this.GameOverLabel.BackColor = System.Drawing.Color.Transparent;
            this.GameOverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 80.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GameOverLabel.ForeColor = System.Drawing.Color.Red;
            this.GameOverLabel.Location = new System.Drawing.Point(224, 121);
            this.GameOverLabel.Name = "GameOverLabel";
            this.GameOverLabel.Size = new System.Drawing.Size(400, 250);
            this.GameOverLabel.TabIndex = 10;
            this.GameOverLabel.Text = "GAME OVER";
            this.GameOverLabel.Visible = false;
            // 
            // Ship1
            // 
            this.Ship1.BackColor = System.Drawing.Color.Blue;
            this.Ship1.Location = new System.Drawing.Point(398, 532);
            this.Ship1.Name = "Ship1";
            this.Ship1.Size = new System.Drawing.Size(0, 20);
            this.Ship1.TabIndex = 11;
            // 
            // Ship2
            // 
            this.Ship2.BackColor = System.Drawing.Color.Blue;
            this.Ship2.Location = new System.Drawing.Point(398, 532);
            this.Ship2.Name = "Ship2";
            this.Ship2.Size = new System.Drawing.Size(0, 20);
            this.Ship2.TabIndex = 12;
            // 
            // Ship3
            // 
            this.Ship3.BackColor = System.Drawing.Color.Green;
            this.Ship3.Location = new System.Drawing.Point(398, 532);
            this.Ship3.Name = "Ship3";
            this.Ship3.Size = new System.Drawing.Size(0, 20);
            this.Ship3.TabIndex = 13;
            // 
            // Ship4
            // 
            this.Ship4.BackColor = System.Drawing.Color.Green;
            this.Ship4.Location = new System.Drawing.Point(398, 532);
            this.Ship4.Name = "Ship4";
            this.Ship4.Size = new System.Drawing.Size(0, 20);
            this.Ship4.TabIndex = 14;
            // 
            // Ship5
            // 
            this.Ship5.BackColor = System.Drawing.Color.Red;
            this.Ship5.Location = new System.Drawing.Point(398, 532);
            this.Ship5.Name = "Ship5";
            this.Ship5.Size = new System.Drawing.Size(0, 20);
            this.Ship5.TabIndex = 15;
            // 
            // Ship6
            // 
            this.Ship6.BackColor = System.Drawing.Color.Red;
            this.Ship6.Location = new System.Drawing.Point(398, 532);
            this.Ship6.Name = "Ship6";
            this.Ship6.Size = new System.Drawing.Size(0, 20);
            this.Ship6.TabIndex = 16;
            // 
            // TroopsPicture
            // 
            this.TroopsPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TroopsPicture.BackgroundImage")));
            this.TroopsPicture.ErrorImage = global::Martian_Battle.Properties.Resources.Безымянный;
            this.TroopsPicture.Location = new System.Drawing.Point(0, 520);
            this.TroopsPicture.Name = "TroopsPicture";
            this.TroopsPicture.Size = new System.Drawing.Size(784, 42);
            this.TroopsPicture.TabIndex = 6;
            this.TroopsPicture.TabStop = false;
            // 
            // Platform
            // 
            this.Platform.BackgroundImage = global::Martian_Battle.Properties.Resources.background2;
            this.Platform.ColumnCount = 1;
            this.Platform.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Platform.Location = new System.Drawing.Point(305, 500);
            this.Platform.Name = "Platform";
            this.Platform.RowCount = 1;
            this.Platform.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Platform.Size = new System.Drawing.Size(200, 14);
            this.Platform.TabIndex = 3;
            // 
            // PointsLabel
            // 
            this.PointsLabel.AutoSize = true;
            this.PointsLabel.BackColor = System.Drawing.Color.Transparent;
            this.PointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PointsLabel.Location = new System.Drawing.Point(254, 92);
            this.PointsLabel.Name = "PointsLabel";
            this.PointsLabel.Size = new System.Drawing.Size(116, 29);
            this.PointsLabel.TabIndex = 17;
            this.PointsLabel.Text = "POINTS: ";
            this.PointsLabel.Visible = false;
            // 
            // MartianBattleLabel
            // 
            this.MartianBattleLabel.AutoSize = true;
            this.MartianBattleLabel.CausesValidation = false;
            this.MartianBattleLabel.Font = new System.Drawing.Font("Algerian", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MartianBattleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.MartianBattleLabel.Location = new System.Drawing.Point(130, 21);
            this.MartianBattleLabel.Name = "MartianBattleLabel";
            this.MartianBattleLabel.Size = new System.Drawing.Size(563, 71);
            this.MartianBattleLabel.TabIndex = 18;
            this.MartianBattleLabel.Text = "MARTIAN BATTLE";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.MartianBattleLabel);
            this.Controls.Add(this.PointsLabel);
            this.Controls.Add(this.Ship1);
            this.Controls.Add(this.Ship2);
            this.Controls.Add(this.Ship3);
            this.Controls.Add(this.Ship4);
            this.Controls.Add(this.Ship5);
            this.Controls.Add(this.Ship6);
            this.Controls.Add(this.GameOverLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.RetryButton);
            this.Controls.Add(this.NumbersOfLives);
            this.Controls.Add(this.TroopsPicture);
            this.Controls.Add(this.Platform);
            this.Controls.Add(this.StartGameButton);
            this.ForeColor = System.Drawing.Color.Lime;
            this.Name = "GameForm";
            this.Text = "Matrian Battle";
            ((System.ComponentModel.ISupportInitialize)(this.TroopsPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button StartGameButton;
        private System.Windows.Forms.TableLayoutPanel Platform;
        private System.Windows.Forms.PictureBox TroopsPicture;
        private System.Windows.Forms.ProgressBar NumbersOfLives;
        private System.Windows.Forms.Button RetryButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label GameOverLabel;
        private System.Windows.Forms.TextBox Ship1;
        private System.Windows.Forms.TextBox Ship2;
        private System.Windows.Forms.TextBox Ship3;
        private System.Windows.Forms.TextBox Ship4;
        private System.Windows.Forms.TextBox Ship5;
        private System.Windows.Forms.TextBox Ship6;
        private System.Windows.Forms.Label PointsLabel;
        private System.Windows.Forms.Label MartianBattleLabel;
    }
}

