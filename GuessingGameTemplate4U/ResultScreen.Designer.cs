namespace GuessingGameTemplate4U
{
    partial class ResultScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ResultLabel = new System.Windows.Forms.Label();
            this.guessesOutput = new System.Windows.Forms.Label();
            this.listOutput = new System.Windows.Forms.Label();
            this.sortedListOutput = new System.Windows.Forms.Label();
            this.listLabel = new System.Windows.Forms.Label();
            this.sortedListLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLabel.ForeColor = System.Drawing.Color.White;
            this.ResultLabel.Location = new System.Drawing.Point(22, 25);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(153, 46);
            this.ResultLabel.TabIndex = 0;
            this.ResultLabel.Text = "Results";
            // 
            // guessesOutput
            // 
            this.guessesOutput.AutoSize = true;
            this.guessesOutput.ForeColor = System.Drawing.Color.White;
            this.guessesOutput.Location = new System.Drawing.Point(27, 99);
            this.guessesOutput.Name = "guessesOutput";
            this.guessesOutput.Size = new System.Drawing.Size(138, 17);
            this.guessesOutput.TabIndex = 1;
            this.guessesOutput.Text = "Number of Guesses:";
            // 
            // listOutput
            // 
            this.listOutput.AutoSize = true;
            this.listOutput.ForeColor = System.Drawing.Color.White;
            this.listOutput.Location = new System.Drawing.Point(27, 186);
            this.listOutput.Name = "listOutput";
            this.listOutput.Size = new System.Drawing.Size(25, 17);
            this.listOutput.TabIndex = 2;
            this.listOutput.Text = "list";
            // 
            // sortedListOutput
            // 
            this.sortedListOutput.AutoSize = true;
            this.sortedListOutput.ForeColor = System.Drawing.Color.White;
            this.sortedListOutput.Location = new System.Drawing.Point(27, 272);
            this.sortedListOutput.Name = "sortedListOutput";
            this.sortedListOutput.Size = new System.Drawing.Size(70, 17);
            this.sortedListOutput.TabIndex = 3;
            this.sortedListOutput.Text = "sortedList";
            // 
            // listLabel
            // 
            this.listLabel.AutoSize = true;
            this.listLabel.ForeColor = System.Drawing.Color.White;
            this.listLabel.Location = new System.Drawing.Point(27, 160);
            this.listLabel.Name = "listLabel";
            this.listLabel.Size = new System.Drawing.Size(100, 17);
            this.listLabel.TabIndex = 4;
            this.listLabel.Text = "Total Guesses";
            // 
            // sortedListLabel
            // 
            this.sortedListLabel.AutoSize = true;
            this.sortedListLabel.ForeColor = System.Drawing.Color.White;
            this.sortedListLabel.Location = new System.Drawing.Point(27, 245);
            this.sortedListLabel.Name = "sortedListLabel";
            this.sortedListLabel.Size = new System.Drawing.Size(110, 17);
            this.sortedListLabel.TabIndex = 5;
            this.sortedListLabel.Text = "Sorted Guesses";
            // 
            // ResultScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.sortedListLabel);
            this.Controls.Add(this.listLabel);
            this.Controls.Add(this.sortedListOutput);
            this.Controls.Add(this.listOutput);
            this.Controls.Add(this.guessesOutput);
            this.Controls.Add(this.ResultLabel);
            this.Name = "ResultScreen";
            this.Size = new System.Drawing.Size(354, 325);
            this.Load += new System.EventHandler(this.ResultScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Label guessesOutput;
        private System.Windows.Forms.Label listOutput;
        private System.Windows.Forms.Label sortedListOutput;
        private System.Windows.Forms.Label listLabel;
        private System.Windows.Forms.Label sortedListLabel;
    }
}
