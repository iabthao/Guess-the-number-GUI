namespace Chapter14Program8
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
            this.components = new System.ComponentModel.Container();
            this.buttonGuess = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPlayAgain = new System.Windows.Forms.Button();
            this.inputText = new System.Windows.Forms.TextBox();
            this.displayGuessText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // buttonGuess
            // 
            this.buttonGuess.Location = new System.Drawing.Point(194, 76);
            this.buttonGuess.Name = "buttonGuess";
            this.buttonGuess.Size = new System.Drawing.Size(75, 23);
            this.buttonGuess.TabIndex = 0;
            this.buttonGuess.Text = "Guess";
            this.toolTip1.SetToolTip(this.buttonGuess, "Click on the button to check");
            this.buttonGuess.UseVisualStyleBackColor = true;
            this.buttonGuess.Click += new System.EventHandler(this.buttonGuess_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(473, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "I have a number between 1 and 1000--Can you guess my number?\r\nPlease enter your f" +
    "irst guess?";
            // 
            // buttonPlayAgain
            // 
            this.buttonPlayAgain.Location = new System.Drawing.Point(291, 76);
            this.buttonPlayAgain.Name = "buttonPlayAgain";
            this.buttonPlayAgain.Size = new System.Drawing.Size(75, 23);
            this.buttonPlayAgain.TabIndex = 2;
            this.buttonPlayAgain.Text = "Play Again";
            this.toolTip1.SetToolTip(this.buttonPlayAgain, "Reset and play again");
            this.buttonPlayAgain.UseVisualStyleBackColor = true;
            this.buttonPlayAgain.Click += new System.EventHandler(this.buttonPlayAgain_Click);
            // 
            // inputText
            // 
            this.inputText.Location = new System.Drawing.Point(30, 76);
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(134, 20);
            this.inputText.TabIndex = 3;
            this.toolTip1.SetToolTip(this.inputText, "Enter your guess here");
            this.inputText.TextChanged += new System.EventHandler(this.inputText_TextChanged);
            // 
            // displayGuessText
            // 
            this.displayGuessText.Location = new System.Drawing.Point(30, 168);
            this.displayGuessText.Multiline = true;
            this.displayGuessText.Name = "displayGuessText";
            this.displayGuessText.ReadOnly = true;
            this.displayGuessText.Size = new System.Drawing.Size(469, 191);
            this.displayGuessText.TabIndex = 4;
            this.toolTip1.SetToolTip(this.displayGuessText, "All guesses will be displayed here");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "All my guesses";
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.Location = new System.Drawing.Point(36, 109);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(0, 21);
            this.infoLabel.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 391);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.displayGuessText);
            this.Controls.Add(this.inputText);
            this.Controls.Add(this.buttonPlayAgain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonGuess);
            this.Name = "Form1";
            this.Text = "Guess the Number";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGuess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPlayAgain;
        private System.Windows.Forms.TextBox inputText;
        private System.Windows.Forms.TextBox displayGuessText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

