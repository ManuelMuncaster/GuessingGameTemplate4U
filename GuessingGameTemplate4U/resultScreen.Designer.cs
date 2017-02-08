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
            this.orderLabel = new System.Windows.Forms.Label();
            this.sortedLabel = new System.Windows.Forms.Label();
            this.guessmadeLabel = new System.Windows.Forms.Label();
            this.originalLabel = new System.Windows.Forms.Label();
            this.sortedresultsLabel = new System.Windows.Forms.Label();
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
            // guessmadeLabel
            // 
            this.guessmadeLabel.AutoSize = true;
            this.guessmadeLabel.ForeColor = System.Drawing.Color.White;
            this.guessmadeLabel.Location = new System.Drawing.Point(138, 87);
            this.guessmadeLabel.Name = "guessmadeLabel";
            this.guessmadeLabel.Size = new System.Drawing.Size(35, 13);
            this.guessmadeLabel.TabIndex = 5;
            this.guessmadeLabel.Text = "label1";
            // 
            // originalLabel
            // 
            this.originalLabel.AutoSize = true;
            this.originalLabel.ForeColor = System.Drawing.Color.White;
            this.originalLabel.Location = new System.Drawing.Point(51, 150);
            this.originalLabel.Name = "originalLabel";
            this.originalLabel.Size = new System.Drawing.Size(35, 13);
            this.originalLabel.TabIndex = 6;
            this.originalLabel.Text = "label1";
            // 
            // sortedresultsLabel
            // 
            this.sortedresultsLabel.AutoSize = true;
            this.sortedresultsLabel.ForeColor = System.Drawing.Color.White;
            this.sortedresultsLabel.Location = new System.Drawing.Point(51, 212);
            this.sortedresultsLabel.Name = "sortedresultsLabel";
            this.sortedresultsLabel.Size = new System.Drawing.Size(35, 13);
            this.sortedresultsLabel.TabIndex = 7;
            this.sortedresultsLabel.Text = "label1";
            // 
            // resultScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.sortedresultsLabel);
            this.Controls.Add(this.originalLabel);
            this.Controls.Add(this.guessmadeLabel);
            this.Controls.Add(this.sortedLabel);
            this.Controls.Add(this.orderLabel);
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
        private System.Windows.Forms.Label orderLabel;
        private System.Windows.Forms.Label sortedLabel;
        private System.Windows.Forms.Label guessmadeLabel;
        private System.Windows.Forms.Label originalLabel;
        private System.Windows.Forms.Label sortedresultsLabel;
    }
}
