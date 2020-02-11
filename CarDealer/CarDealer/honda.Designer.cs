namespace CarDealer
{
    partial class honda
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
            this.hondaLabel = new System.Windows.Forms.Label();
            this.makeLabel = new System.Windows.Forms.Label();
            this.modelLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.mileLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hondaLabel
            // 
            this.hondaLabel.AutoSize = true;
            this.hondaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hondaLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.hondaLabel.Location = new System.Drawing.Point(116, 78);
            this.hondaLabel.Name = "hondaLabel";
            this.hondaLabel.Size = new System.Drawing.Size(305, 39);
            this.hondaLabel.TabIndex = 0;
            this.hondaLabel.Text = "2004 Honda Civic";
            this.hondaLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // makeLabel
            // 
            this.makeLabel.AutoSize = true;
            this.makeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeLabel.Location = new System.Drawing.Point(216, 152);
            this.makeLabel.Name = "makeLabel";
            this.makeLabel.Size = new System.Drawing.Size(100, 16);
            this.makeLabel.TabIndex = 1;
            this.makeLabel.Text = "Make: Honda";
            this.makeLabel.Click += new System.EventHandler(this.makeLabel_Click);
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelLabel.Location = new System.Drawing.Point(216, 182);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(93, 16);
            this.modelLabel.TabIndex = 2;
            this.modelLabel.Text = "Model: Civic";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearLabel.Location = new System.Drawing.Point(216, 213);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(81, 16);
            this.yearLabel.TabIndex = 3;
            this.yearLabel.Text = "Year: 2004";
            this.yearLabel.Click += new System.EventHandler(this.yearLabel_Click);
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costLabel.ForeColor = System.Drawing.Color.Green;
            this.costLabel.Location = new System.Drawing.Point(223, 318);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(99, 20);
            this.costLabel.TabIndex = 4;
            this.costLabel.Text = "Price: 9799";
            // 
            // mileLabel
            // 
            this.mileLabel.AutoSize = true;
            this.mileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mileLabel.Location = new System.Drawing.Point(216, 241);
            this.mileLabel.Name = "mileLabel";
            this.mileLabel.Size = new System.Drawing.Size(116, 16);
            this.mileLabel.TabIndex = 5;
            this.mileLabel.Text = "Mileage: 87,987";
            this.mileLabel.Click += new System.EventHandler(this.mileLabel_Click);
            // 
            // honda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 450);
            this.Controls.Add(this.mileLabel);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.modelLabel);
            this.Controls.Add(this.makeLabel);
            this.Controls.Add(this.hondaLabel);
            this.Name = "honda";
            this.Text = "honda";
            this.Load += new System.EventHandler(this.honda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hondaLabel;
        private System.Windows.Forms.Label makeLabel;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label mileLabel;
    }
}