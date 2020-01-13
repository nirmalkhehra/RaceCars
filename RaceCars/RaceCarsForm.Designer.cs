namespace RaceCars
{
    partial class RaceCarsForm
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
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnBets = new System.Windows.Forms.Button();
            this.lblWinner = new System.Windows.Forms.Label();
            this.lblBettorName = new System.Windows.Forms.Label();
            this.rbMatt = new System.Windows.Forms.RadioButton();
            this.rbZoe = new System.Windows.Forms.RadioButton();
            this.rbClark = new System.Windows.Forms.RadioButton();
            this.udBet = new System.Windows.Forms.NumericUpDown();
            this.txtMatt = new System.Windows.Forms.TextBox();
            this.txtClark = new System.Windows.Forms.TextBox();
            this.txtZoe = new System.Windows.Forms.TextBox();
            this.cbxCar = new System.Windows.Forms.ComboBox();
            this.lblCar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udBet)).BeginInit();
            this.SuspendLayout();
            // 
            // pb1
            // 
            this.pb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb1.Location = new System.Drawing.Point(35, 38);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(244, 117);
            this.pb1.TabIndex = 0;
            this.pb1.TabStop = false;
            // 
            // pb2
            // 
            this.pb2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb2.Location = new System.Drawing.Point(35, 179);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(244, 110);
            this.pb2.TabIndex = 1;
            this.pb2.TabStop = false;
            // 
            // pb3
            // 
            this.pb3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb3.Location = new System.Drawing.Point(35, 308);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(244, 110);
            this.pb3.TabIndex = 3;
            this.pb3.TabStop = false;
            // 
            // pb4
            // 
            this.pb4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb4.Location = new System.Drawing.Point(35, 441);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(244, 110);
            this.pb4.TabIndex = 4;
            this.pb4.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(80, 604);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(102, 37);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(220, 604);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(89, 37);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnBets
            // 
            this.btnBets.Location = new System.Drawing.Point(355, 604);
            this.btnBets.Name = "btnBets";
            this.btnBets.Size = new System.Drawing.Size(88, 37);
            this.btnBets.TabIndex = 7;
            this.btnBets.Text = "Place Bet";
            this.btnBets.UseVisualStyleBackColor = true;
            this.btnBets.Click += new System.EventHandler(this.btnBets_Click);
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Location = new System.Drawing.Point(89, 683);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(53, 17);
            this.lblWinner.TabIndex = 8;
            this.lblWinner.Text = "Winner";
            // 
            // lblBettorName
            // 
            this.lblBettorName.AutoSize = true;
            this.lblBettorName.Location = new System.Drawing.Point(494, 534);
            this.lblBettorName.Name = "lblBettorName";
            this.lblBettorName.Size = new System.Drawing.Size(87, 17);
            this.lblBettorName.TabIndex = 9;
            this.lblBettorName.Text = "Bettor Name";
            this.lblBettorName.Click += new System.EventHandler(this.lblBettorName_Click);
            // 
            // rbMatt
            // 
            this.rbMatt.AutoSize = true;
            this.rbMatt.Location = new System.Drawing.Point(497, 576);
            this.rbMatt.Name = "rbMatt";
            this.rbMatt.Size = new System.Drawing.Size(56, 21);
            this.rbMatt.TabIndex = 10;
            this.rbMatt.TabStop = true;
            this.rbMatt.Text = "Matt";
            this.rbMatt.UseVisualStyleBackColor = true;
            this.rbMatt.CheckedChanged += new System.EventHandler(this.Allrb_CheckedChanged);
            // 
            // rbZoe
            // 
            this.rbZoe.AutoSize = true;
            this.rbZoe.Location = new System.Drawing.Point(497, 631);
            this.rbZoe.Name = "rbZoe";
            this.rbZoe.Size = new System.Drawing.Size(54, 21);
            this.rbZoe.TabIndex = 11;
            this.rbZoe.TabStop = true;
            this.rbZoe.Text = "Zoe";
            this.rbZoe.UseVisualStyleBackColor = true;
            this.rbZoe.CheckedChanged += new System.EventHandler(this.Allrb_CheckedChanged);
            // 
            // rbClark
            // 
            this.rbClark.AutoSize = true;
            this.rbClark.Location = new System.Drawing.Point(497, 604);
            this.rbClark.Name = "rbClark";
            this.rbClark.Size = new System.Drawing.Size(61, 21);
            this.rbClark.TabIndex = 12;
            this.rbClark.TabStop = true;
            this.rbClark.Text = "Clark";
            this.rbClark.UseVisualStyleBackColor = true;
            this.rbClark.CheckedChanged += new System.EventHandler(this.Allrb_CheckedChanged);
            // 
            // udBet
            // 
            this.udBet.Location = new System.Drawing.Point(593, 576);
            this.udBet.Name = "udBet";
            this.udBet.Size = new System.Drawing.Size(120, 22);
            this.udBet.TabIndex = 13;
            this.udBet.ValueChanged += new System.EventHandler(this.udBet_ValueChanged_1);
            // 
            // txtMatt
            // 
            this.txtMatt.Location = new System.Drawing.Point(765, 575);
            this.txtMatt.Name = "txtMatt";
            this.txtMatt.Size = new System.Drawing.Size(537, 22);
            this.txtMatt.TabIndex = 14;
            this.txtMatt.Text = "Matt\'s Bet";
            this.txtMatt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtClark
            // 
            this.txtClark.Location = new System.Drawing.Point(765, 619);
            this.txtClark.Name = "txtClark";
            this.txtClark.Size = new System.Drawing.Size(537, 22);
            this.txtClark.TabIndex = 15;
            this.txtClark.Text = "Clark\'s Bet";
            // 
            // txtZoe
            // 
            this.txtZoe.Location = new System.Drawing.Point(765, 668);
            this.txtZoe.Name = "txtZoe";
            this.txtZoe.Size = new System.Drawing.Size(537, 22);
            this.txtZoe.TabIndex = 16;
            this.txtZoe.Text = "Zoe\'s Bet";
            // 
            // cbxCar
            // 
            this.cbxCar.FormattingEnabled = true;
            this.cbxCar.Items.AddRange(new object[] {
            "Alfa Romeo",
            "Ferrari",
            "Infiniti",
            "Mclaren"});
            this.cbxCar.Location = new System.Drawing.Point(593, 620);
            this.cbxCar.Name = "cbxCar";
            this.cbxCar.Size = new System.Drawing.Size(121, 24);
            this.cbxCar.TabIndex = 17;
            this.cbxCar.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblCar
            // 
            this.lblCar.AutoSize = true;
            this.lblCar.Location = new System.Drawing.Point(89, 732);
            this.lblCar.Name = "lblCar";
            this.lblCar.Size = new System.Drawing.Size(100, 17);
            this.lblCar.TabIndex = 18;
            this.lblCar.Text = "First Place Car";
            this.lblCar.Click += new System.EventHandler(this.label1_Click);
            // 
            // RaceCarsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1381, 831);
            this.Controls.Add(this.lblCar);
            this.Controls.Add(this.cbxCar);
            this.Controls.Add(this.txtZoe);
            this.Controls.Add(this.txtClark);
            this.Controls.Add(this.txtMatt);
            this.Controls.Add(this.udBet);
            this.Controls.Add(this.rbClark);
            this.Controls.Add(this.rbZoe);
            this.Controls.Add(this.rbMatt);
            this.Controls.Add(this.lblBettorName);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.btnBets);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pb4);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb1);
            this.Name = "RaceCarsForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udBet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnBets;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Label lblBettorName;
        private System.Windows.Forms.RadioButton rbMatt;
        private System.Windows.Forms.RadioButton rbZoe;
        private System.Windows.Forms.RadioButton rbClark;
        private System.Windows.Forms.NumericUpDown udBet;
        private System.Windows.Forms.TextBox txtMatt;
        private System.Windows.Forms.TextBox txtClark;
        private System.Windows.Forms.TextBox txtZoe;
        private System.Windows.Forms.ComboBox cbxCar;
        private System.Windows.Forms.Label lblCar;
    }
}

