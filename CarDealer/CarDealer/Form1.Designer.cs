namespace CarDealer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.titleLabel = new System.Windows.Forms.Label();
            this.carList = new System.Windows.Forms.ListBox();
            this.listLabel = new System.Windows.Forms.Label();
            this.selectButton = new System.Windows.Forms.Button();
            this.companyDesc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Lucida Sans", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.titleLabel.Location = new System.Drawing.Point(208, 39);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(342, 39);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Adam\'s Used Cars";
            this.titleLabel.Click += new System.EventHandler(this.titleLabel_Click);
            // 
            // carList
            // 
            this.carList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.carList.FormattingEnabled = true;
            this.carList.Items.AddRange(new object[] {
            "2004 Honda Civic",
            "2012 Ford Escape",
            "2018 Tesla Model 3"});
            this.carList.Location = new System.Drawing.Point(80, 148);
            this.carList.Name = "carList";
            this.carList.Size = new System.Drawing.Size(119, 93);
            this.carList.TabIndex = 1;
            this.carList.SelectedIndexChanged += new System.EventHandler(this.carList_SelectedIndexChanged);
            // 
            // listLabel
            // 
            this.listLabel.AutoSize = true;
            this.listLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listLabel.Location = new System.Drawing.Point(96, 123);
            this.listLabel.Name = "listLabel";
            this.listLabel.Size = new System.Drawing.Size(87, 13);
            this.listLabel.TabIndex = 2;
            this.listLabel.Text = "Choose a Car:";
            this.listLabel.Click += new System.EventHandler(this.listLabel_Click);
            // 
            // selectButton
            // 
            this.selectButton.BackColor = System.Drawing.SystemColors.Control;
            this.selectButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.selectButton.Location = new System.Drawing.Point(99, 247);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(75, 23);
            this.selectButton.TabIndex = 3;
            this.selectButton.Text = "Select";
            this.selectButton.UseVisualStyleBackColor = false;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // companyDesc
            // 
            this.companyDesc.AutoSize = true;
            this.companyDesc.Location = new System.Drawing.Point(361, 167);
            this.companyDesc.Name = "companyDesc";
            this.companyDesc.Size = new System.Drawing.Size(293, 65);
            this.companyDesc.TabIndex = 4;
            this.companyDesc.Text = resources.GetString("companyDesc.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.companyDesc);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.listLabel);
            this.Controls.Add(this.carList);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.ListBox carList;
        private System.Windows.Forms.Label listLabel;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Label companyDesc;
    }
}

