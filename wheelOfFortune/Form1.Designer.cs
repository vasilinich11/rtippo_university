namespace wheelOfFortune
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
            this.buttonStartTurn = new System.Windows.Forms.Button();
            this.labelWinningSector = new System.Windows.Forms.Label();
            this.buttonBetX1 = new System.Windows.Forms.Button();
            this.buttonBetX2 = new System.Windows.Forms.Button();
            this.buttonBetX5 = new System.Windows.Forms.Button();
            this.buttonBetX10 = new System.Windows.Forms.Button();
            this.buttonBetX20 = new System.Windows.Forms.Button();
            this.buttonBetX40 = new System.Windows.Forms.Button();
            this.labelBetX1 = new System.Windows.Forms.Label();
            this.textBoxBet = new System.Windows.Forms.TextBox();
            this.labelBetX2 = new System.Windows.Forms.Label();
            this.labelBetX5 = new System.Windows.Forms.Label();
            this.labelBetX10 = new System.Windows.Forms.Label();
            this.labelBetX20 = new System.Windows.Forms.Label();
            this.labelBetX40 = new System.Windows.Forms.Label();
            this.labelBalance = new System.Windows.Forms.Label();
            this.buttonStartGame = new System.Windows.Forms.Button();
            this.buttonPassTheTurn = new System.Windows.Forms.Button();
            this.labelBalances = new System.Windows.Forms.Label();
            this.labelPrizes = new System.Windows.Forms.Label();
            this.labelNotEnoughBalance = new System.Windows.Forms.Label();
            this.labelTurns = new System.Windows.Forms.Label();
            this.textBoxTurns = new System.Windows.Forms.TextBox();
            this.labelWinner = new System.Windows.Forms.Label();
            this.buttonStartNewGame = new System.Windows.Forms.Button();
            this.labelBet = new System.Windows.Forms.Label();
            this.pictureBoxArrow = new System.Windows.Forms.PictureBox();
            this.pictureBoxWheel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWheel)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStartTurn
            // 
            this.buttonStartTurn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(80)))), ((int)(((byte)(32)))));
            this.buttonStartTurn.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStartTurn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonStartTurn.Location = new System.Drawing.Point(576, 708);
            this.buttonStartTurn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonStartTurn.Name = "buttonStartTurn";
            this.buttonStartTurn.Size = new System.Drawing.Size(286, 129);
            this.buttonStartTurn.TabIndex = 2;
            this.buttonStartTurn.Text = "Крутить барабан!";
            this.buttonStartTurn.UseVisualStyleBackColor = false;
            this.buttonStartTurn.Visible = false;
            this.buttonStartTurn.Click += new System.EventHandler(this.StartTurningClick);
            // 
            // labelWinningSector
            // 
            this.labelWinningSector.AutoSize = true;
            this.labelWinningSector.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWinningSector.ForeColor = System.Drawing.SystemColors.Control;
            this.labelWinningSector.Location = new System.Drawing.Point(1084, 205);
            this.labelWinningSector.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWinningSector.MaximumSize = new System.Drawing.Size(240, 0);
            this.labelWinningSector.Name = "labelWinningSector";
            this.labelWinningSector.Size = new System.Drawing.Size(204, 100);
            this.labelWinningSector.TabIndex = 3;
            this.labelWinningSector.Text = "Выиграл сектор ";
            this.labelWinningSector.Visible = false;
            // 
            // buttonBetX1
            // 
            this.buttonBetX1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(80)))), ((int)(((byte)(32)))));
            this.buttonBetX1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBetX1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonBetX1.Location = new System.Drawing.Point(441, 708);
            this.buttonBetX1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonBetX1.Name = "buttonBetX1";
            this.buttonBetX1.Size = new System.Drawing.Size(140, 49);
            this.buttonBetX1.TabIndex = 4;
            this.buttonBetX1.Text = "1";
            this.buttonBetX1.UseVisualStyleBackColor = false;
            this.buttonBetX1.Visible = false;
            this.buttonBetX1.Click += new System.EventHandler(this.MakeBetX1Click);
            // 
            // buttonBetX2
            // 
            this.buttonBetX2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(80)))), ((int)(((byte)(32)))));
            this.buttonBetX2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBetX2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonBetX2.Location = new System.Drawing.Point(658, 708);
            this.buttonBetX2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonBetX2.Name = "buttonBetX2";
            this.buttonBetX2.Size = new System.Drawing.Size(140, 49);
            this.buttonBetX2.TabIndex = 5;
            this.buttonBetX2.Text = "2";
            this.buttonBetX2.UseVisualStyleBackColor = false;
            this.buttonBetX2.Visible = false;
            this.buttonBetX2.Click += new System.EventHandler(this.MakeBetX2Click);
            // 
            // buttonBetX5
            // 
            this.buttonBetX5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(80)))), ((int)(((byte)(32)))));
            this.buttonBetX5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBetX5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonBetX5.Location = new System.Drawing.Point(855, 708);
            this.buttonBetX5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonBetX5.Name = "buttonBetX5";
            this.buttonBetX5.Size = new System.Drawing.Size(140, 49);
            this.buttonBetX5.TabIndex = 6;
            this.buttonBetX5.Text = "5";
            this.buttonBetX5.UseVisualStyleBackColor = false;
            this.buttonBetX5.Visible = false;
            this.buttonBetX5.Click += new System.EventHandler(this.MakeBetX5Click);
            // 
            // buttonBetX10
            // 
            this.buttonBetX10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(80)))), ((int)(((byte)(32)))));
            this.buttonBetX10.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBetX10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonBetX10.Location = new System.Drawing.Point(441, 788);
            this.buttonBetX10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonBetX10.Name = "buttonBetX10";
            this.buttonBetX10.Size = new System.Drawing.Size(140, 49);
            this.buttonBetX10.TabIndex = 7;
            this.buttonBetX10.Text = "10";
            this.buttonBetX10.UseVisualStyleBackColor = false;
            this.buttonBetX10.Visible = false;
            this.buttonBetX10.Click += new System.EventHandler(this.MakeBetX10Click);
            // 
            // buttonBetX20
            // 
            this.buttonBetX20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(80)))), ((int)(((byte)(32)))));
            this.buttonBetX20.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBetX20.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonBetX20.Location = new System.Drawing.Point(658, 788);
            this.buttonBetX20.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonBetX20.Name = "buttonBetX20";
            this.buttonBetX20.Size = new System.Drawing.Size(140, 49);
            this.buttonBetX20.TabIndex = 8;
            this.buttonBetX20.Text = "20";
            this.buttonBetX20.UseVisualStyleBackColor = false;
            this.buttonBetX20.Visible = false;
            this.buttonBetX20.Click += new System.EventHandler(this.MakeBetX20Click);
            // 
            // buttonBetX40
            // 
            this.buttonBetX40.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(80)))), ((int)(((byte)(32)))));
            this.buttonBetX40.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBetX40.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonBetX40.Location = new System.Drawing.Point(855, 788);
            this.buttonBetX40.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonBetX40.Name = "buttonBetX40";
            this.buttonBetX40.Size = new System.Drawing.Size(140, 49);
            this.buttonBetX40.TabIndex = 9;
            this.buttonBetX40.Text = "Д";
            this.buttonBetX40.UseVisualStyleBackColor = false;
            this.buttonBetX40.Visible = false;
            this.buttonBetX40.Click += new System.EventHandler(this.MakeBetX40Click);
            // 
            // labelBetX1
            // 
            this.labelBetX1.AutoSize = true;
            this.labelBetX1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBetX1.ForeColor = System.Drawing.SystemColors.Control;
            this.labelBetX1.Location = new System.Drawing.Point(69, 98);
            this.labelBetX1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBetX1.Name = "labelBetX1";
            this.labelBetX1.Size = new System.Drawing.Size(225, 39);
            this.labelBetX1.TabIndex = 10;
            this.labelBetX1.Text = "Ставка на 1: ";
            this.labelBetX1.Visible = false;
            // 
            // textBoxBet
            // 
            this.textBoxBet.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxBet.Location = new System.Drawing.Point(652, 872);
            this.textBoxBet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxBet.Name = "textBoxBet";
            this.textBoxBet.Size = new System.Drawing.Size(148, 42);
            this.textBoxBet.TabIndex = 11;
            this.textBoxBet.Visible = false;
            this.textBoxBet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AllowOnlyDigits);
            // 
            // labelBetX2
            // 
            this.labelBetX2.AutoSize = true;
            this.labelBetX2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBetX2.ForeColor = System.Drawing.SystemColors.Control;
            this.labelBetX2.Location = new System.Drawing.Point(69, 168);
            this.labelBetX2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBetX2.Name = "labelBetX2";
            this.labelBetX2.Size = new System.Drawing.Size(225, 39);
            this.labelBetX2.TabIndex = 12;
            this.labelBetX2.Text = "Ставка на 2: ";
            this.labelBetX2.Visible = false;
            // 
            // labelBetX5
            // 
            this.labelBetX5.AutoSize = true;
            this.labelBetX5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBetX5.ForeColor = System.Drawing.SystemColors.Control;
            this.labelBetX5.Location = new System.Drawing.Point(69, 237);
            this.labelBetX5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBetX5.Name = "labelBetX5";
            this.labelBetX5.Size = new System.Drawing.Size(225, 39);
            this.labelBetX5.TabIndex = 13;
            this.labelBetX5.Text = "Ставка на 5: ";
            this.labelBetX5.Visible = false;
            // 
            // labelBetX10
            // 
            this.labelBetX10.AutoSize = true;
            this.labelBetX10.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBetX10.ForeColor = System.Drawing.SystemColors.Control;
            this.labelBetX10.Location = new System.Drawing.Point(69, 306);
            this.labelBetX10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBetX10.Name = "labelBetX10";
            this.labelBetX10.Size = new System.Drawing.Size(243, 39);
            this.labelBetX10.TabIndex = 14;
            this.labelBetX10.Text = "Ставка на 10: ";
            this.labelBetX10.Visible = false;
            // 
            // labelBetX20
            // 
            this.labelBetX20.AutoSize = true;
            this.labelBetX20.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBetX20.ForeColor = System.Drawing.SystemColors.Control;
            this.labelBetX20.Location = new System.Drawing.Point(69, 375);
            this.labelBetX20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBetX20.Name = "labelBetX20";
            this.labelBetX20.Size = new System.Drawing.Size(243, 39);
            this.labelBetX20.TabIndex = 15;
            this.labelBetX20.Text = "Ставка на 20: ";
            this.labelBetX20.Visible = false;
            // 
            // labelBetX40
            // 
            this.labelBetX40.AutoSize = true;
            this.labelBetX40.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBetX40.ForeColor = System.Drawing.SystemColors.Control;
            this.labelBetX40.Location = new System.Drawing.Point(69, 445);
            this.labelBetX40.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBetX40.Name = "labelBetX40";
            this.labelBetX40.Size = new System.Drawing.Size(231, 39);
            this.labelBetX40.TabIndex = 16;
            this.labelBetX40.Text = "Ставка на Д: ";
            this.labelBetX40.Visible = false;
            this.labelBetX40.Click += new System.EventHandler(this.labelBetX40_Click);
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBalance.ForeColor = System.Drawing.SystemColors.Control;
            this.labelBalance.Location = new System.Drawing.Point(69, 514);
            this.labelBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBalance.MaximumSize = new System.Drawing.Size(300, 0);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(142, 38);
            this.labelBalance.TabIndex = 17;
            this.labelBalance.Text = "Баланс:";
            this.labelBalance.Visible = false;
            // 
            // buttonStartGame
            // 
            this.buttonStartGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(80)))), ((int)(((byte)(32)))));
            this.buttonStartGame.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStartGame.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonStartGame.Location = new System.Drawing.Point(492, 525);
            this.buttonStartGame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonStartGame.Name = "buttonStartGame";
            this.buttonStartGame.Size = new System.Drawing.Size(417, 122);
            this.buttonStartGame.TabIndex = 20;
            this.buttonStartGame.Text = "Начать игру";
            this.buttonStartGame.UseVisualStyleBackColor = false;
            this.buttonStartGame.Click += new System.EventHandler(this.StartGameClick);
            // 
            // buttonPassTheTurn
            // 
            this.buttonPassTheTurn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(80)))), ((int)(((byte)(32)))));
            this.buttonPassTheTurn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPassTheTurn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonPassTheTurn.Location = new System.Drawing.Point(1084, 531);
            this.buttonPassTheTurn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonPassTheTurn.Name = "buttonPassTheTurn";
            this.buttonPassTheTurn.Size = new System.Drawing.Size(252, 92);
            this.buttonPassTheTurn.TabIndex = 21;
            this.buttonPassTheTurn.Text = "Перейти к колесу";
            this.buttonPassTheTurn.UseVisualStyleBackColor = false;
            this.buttonPassTheTurn.Visible = false;
            this.buttonPassTheTurn.Click += new System.EventHandler(this.PassTheTurnClick);
            // 
            // labelBalances
            // 
            this.labelBalances.AutoSize = true;
            this.labelBalances.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBalances.ForeColor = System.Drawing.SystemColors.Control;
            this.labelBalances.Location = new System.Drawing.Point(486, 708);
            this.labelBalances.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBalances.Name = "labelBalances";
            this.labelBalances.Size = new System.Drawing.Size(236, 39);
            this.labelBalances.TabIndex = 22;
            this.labelBalances.Text = "labelBalances";
            this.labelBalances.Visible = false;
            // 
            // labelPrizes
            // 
            this.labelPrizes.AutoSize = true;
            this.labelPrizes.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrizes.ForeColor = System.Drawing.SystemColors.Control;
            this.labelPrizes.Location = new System.Drawing.Point(1084, 708);
            this.labelPrizes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrizes.Name = "labelPrizes";
            this.labelPrizes.Size = new System.Drawing.Size(161, 36);
            this.labelPrizes.TabIndex = 23;
            this.labelPrizes.Text = "labelPrizes";
            this.labelPrizes.Visible = false;
            this.labelPrizes.Click += new System.EventHandler(this.labelPrizes_Click);
            // 
            // labelNotEnoughBalance
            // 
            this.labelNotEnoughBalance.AutoSize = true;
            this.labelNotEnoughBalance.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNotEnoughBalance.ForeColor = System.Drawing.SystemColors.Control;
            this.labelNotEnoughBalance.Location = new System.Drawing.Point(836, 868);
            this.labelNotEnoughBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNotEnoughBalance.MaximumSize = new System.Drawing.Size(225, 0);
            this.labelNotEnoughBalance.Name = "labelNotEnoughBalance";
            this.labelNotEnoughBalance.Size = new System.Drawing.Size(224, 52);
            this.labelNotEnoughBalance.TabIndex = 24;
            this.labelNotEnoughBalance.Text = "Недостаточно денег на балансе";
            this.labelNotEnoughBalance.Visible = false;
            // 
            // labelTurns
            // 
            this.labelTurns.AutoSize = true;
            this.labelTurns.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTurns.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTurns.Location = new System.Drawing.Point(414, 398);
            this.labelTurns.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTurns.Name = "labelTurns";
            this.labelTurns.Size = new System.Drawing.Size(385, 50);
            this.labelTurns.TabIndex = 25;
            this.labelTurns.Text = "Количество ходов";
            // 
            // textBoxTurns
            // 
            this.textBoxTurns.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTurns.Location = new System.Drawing.Point(836, 402);
            this.textBoxTurns.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxTurns.Name = "textBoxTurns";
            this.textBoxTurns.Size = new System.Drawing.Size(148, 42);
            this.textBoxTurns.TabIndex = 26;
            this.textBoxTurns.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AllowOnlyDigits);
            // 
            // labelWinner
            // 
            this.labelWinner.AutoSize = true;
            this.labelWinner.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWinner.ForeColor = System.Drawing.SystemColors.Control;
            this.labelWinner.Location = new System.Drawing.Point(486, 331);
            this.labelWinner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWinner.Name = "labelWinner";
            this.labelWinner.Size = new System.Drawing.Size(202, 39);
            this.labelWinner.TabIndex = 27;
            this.labelWinner.Text = "labelWinner";
            this.labelWinner.Visible = false;
            // 
            // buttonStartNewGame
            // 
            this.buttonStartNewGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(80)))), ((int)(((byte)(32)))));
            this.buttonStartNewGame.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStartNewGame.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonStartNewGame.Location = new System.Drawing.Point(493, 514);
            this.buttonStartNewGame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonStartNewGame.Name = "buttonStartNewGame";
            this.buttonStartNewGame.Size = new System.Drawing.Size(417, 142);
            this.buttonStartNewGame.TabIndex = 28;
            this.buttonStartNewGame.Text = "Начать новую игру";
            this.buttonStartNewGame.UseVisualStyleBackColor = false;
            this.buttonStartNewGame.Visible = false;
            this.buttonStartNewGame.Click += new System.EventHandler(this.StartNewGameClick);
            // 
            // labelBet
            // 
            this.labelBet.AutoSize = true;
            this.labelBet.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBet.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelBet.Location = new System.Drawing.Point(486, 877);
            this.labelBet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBet.Name = "labelBet";
            this.labelBet.Size = new System.Drawing.Size(139, 39);
            this.labelBet.TabIndex = 29;
            this.labelBet.Text = "Ставка:";
            this.labelBet.Visible = false;
            // 
            // pictureBoxArrow
            // 
            this.pictureBoxArrow.Image = global::wheelOfFortune.Properties.Resources.White_Arrow_PNG_Image_HD;
            this.pictureBoxArrow.Location = new System.Drawing.Point(666, 3);
            this.pictureBoxArrow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxArrow.Name = "pictureBoxArrow";
            this.pictureBoxArrow.Size = new System.Drawing.Size(124, 86);
            this.pictureBoxArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxArrow.TabIndex = 1;
            this.pictureBoxArrow.TabStop = false;
            this.pictureBoxArrow.Visible = false;
            // 
            // pictureBoxWheel
            // 
            this.pictureBoxWheel.Image = global::wheelOfFortune.Properties.Resources.wheel1;
            this.pictureBoxWheel.Location = new System.Drawing.Point(541, 88);
            this.pictureBoxWheel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxWheel.Name = "pictureBoxWheel";
            this.pictureBoxWheel.Size = new System.Drawing.Size(369, 369);
            this.pictureBoxWheel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxWheel.TabIndex = 0;
            this.pictureBoxWheel.TabStop = false;
            this.pictureBoxWheel.Visible = false;
            this.pictureBoxWheel.Click += new System.EventHandler(this.pictureBoxWheel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1457, 1107);
            this.Controls.Add(this.labelBet);
            this.Controls.Add(this.buttonStartNewGame);
            this.Controls.Add(this.labelWinner);
            this.Controls.Add(this.textBoxTurns);
            this.Controls.Add(this.labelTurns);
            this.Controls.Add(this.labelNotEnoughBalance);
            this.Controls.Add(this.labelPrizes);
            this.Controls.Add(this.labelBalances);
            this.Controls.Add(this.buttonPassTheTurn);
            this.Controls.Add(this.buttonStartGame);
            this.Controls.Add(this.labelBalance);
            this.Controls.Add(this.labelBetX40);
            this.Controls.Add(this.labelBetX20);
            this.Controls.Add(this.labelBetX10);
            this.Controls.Add(this.labelBetX5);
            this.Controls.Add(this.labelBetX2);
            this.Controls.Add(this.textBoxBet);
            this.Controls.Add(this.labelBetX1);
            this.Controls.Add(this.buttonBetX40);
            this.Controls.Add(this.buttonBetX20);
            this.Controls.Add(this.buttonBetX10);
            this.Controls.Add(this.buttonBetX5);
            this.Controls.Add(this.buttonBetX2);
            this.Controls.Add(this.buttonBetX1);
            this.Controls.Add(this.labelWinningSector);
            this.Controls.Add(this.buttonStartTurn);
            this.Controls.Add(this.pictureBoxArrow);
            this.Controls.Add(this.pictureBoxWheel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWheel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBoxWheel;
        public System.Windows.Forms.PictureBox pictureBoxArrow;
        public System.Windows.Forms.Button buttonStartTurn;
        public System.Windows.Forms.Label labelWinningSector;
        public System.Windows.Forms.Button buttonBetX1;
        public System.Windows.Forms.Button buttonBetX2;
        public System.Windows.Forms.Button buttonBetX5;
        public System.Windows.Forms.Button buttonBetX10;
        public System.Windows.Forms.Button buttonBetX20;
        public System.Windows.Forms.Button buttonBetX40;
        public System.Windows.Forms.Label labelBetX1;
        public System.Windows.Forms.TextBox textBoxBet;
        public System.Windows.Forms.Label labelBetX2;
        public System.Windows.Forms.Label labelBetX5;
        public System.Windows.Forms.Label labelBetX10;
        public System.Windows.Forms.Label labelBetX20;
        public System.Windows.Forms.Label labelBetX40;
        public System.Windows.Forms.Label labelBalance;
        public System.Windows.Forms.Button buttonStartGame;
        public System.Windows.Forms.Button buttonPassTheTurn;
        public System.Windows.Forms.Label labelBalances;
        public System.Windows.Forms.Label labelPrizes;
        public System.Windows.Forms.Label labelNotEnoughBalance;
        public System.Windows.Forms.Label labelTurns;
        public System.Windows.Forms.TextBox textBoxTurns;
        public System.Windows.Forms.Label labelWinner;
        public System.Windows.Forms.Button buttonStartNewGame;
        public System.Windows.Forms.Label labelBet;
    }
}

