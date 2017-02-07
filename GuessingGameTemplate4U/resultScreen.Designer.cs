namespace GuessingGameTemplate4U
{
    partial class resultScreen
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleLabel2 = new System.Windows.Forms.Label();
            this.guessLabel = new System.Windows.Forms.Label();
            this.orderLabel = new System.Windows.Forms.Label();
            this.sortedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(122, 54);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(42, 13);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Results";
            // 
            // titleLabel2
            // 
            this.titleLabel2.AutoSize = true;
            this.titleLabel2.ForeColor = System.Drawing.Color.White;
            this.titleLabel2.Location = new System.Drawing.Point(51, 87);
            this.titleLabel2.Name = "titleLabel2";
            this.titleLabel2.Size = new System.Drawing.Size(81, 13);
            this.titleLabel2.TabIndex = 1;
            this.titleLabel2.Text = "Guesses Made:";
            // 
            // guessLabel
            // 
            this.guessLabel.AutoSize = true;
            this.guessLabel.BackColor = System.Drawing.Color.Black;
            this.guessLabel.ForeColor = System.Drawing.Color.White;
            this.guessLabel.Location = new System.Drawing.Point(138, 87);
            this.guessLabel.Name = "guessLabel";
            this.guessLabel.Size = new System.Drawing.Size(35, 13);
            this.guessLabel.TabIndex = 2;
            this.guessLabel.Text = "label1";
            // 
            // orderLabel
            // 
            this.orderLabel.AutoSize = true;
            this.orderLabel.BackColor = System.Drawing.Color.Black;
            this.orderLabel.ForeColor = System.Drawing.Color.White;
            this.orderLabel.Location = new System.Drawing.Point(51, 126);
            this.orderLabel.Name = "orderLabel";
            this.orderLabel.Size = new System.Drawing.Size(72, 13);
            this.orderLabel.TabIndex = 3;
            this.orderLabel.Text = "Orginal Order:";
            // 
            // sortedLabel
            // 
            this.sortedLabel.AutoSize = true;
            this.sortedLabel.ForeColor = System.Drawing.Color.White;
            this.sortedLabel.Location = new System.Drawing.Point(51, 182);
            this.sortedLabel.Name = "sortedLabel";
            this.sortedLabel.Size = new System.Drawing.Size(70, 13);
            this.sortedLabel.TabIndex = 4;
            this.sortedLabel.Text = "Sorted Order:";
            // 
            // resultScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.sortedLabel);
            this.Controls.Add(this.orderLabel);
            this.Controls.Add(this.guessLabel);
            this.Controls.Add(this.titleLabel2);
            this.Controls.Add(this.titleLabel);
            this.Name = "resultScreen";
            this.Size = new System.Drawing.Size(300, 300);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label titleLabel2;
        private System.Windows.Forms.Label guessLabel;
        private System.Windows.Forms.Label orderLabel;
        private System.Windows.Forms.Label sortedLabel;
    }
}
