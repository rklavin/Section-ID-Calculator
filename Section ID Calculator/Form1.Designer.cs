namespace Section_ID_Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSectionID = new System.Windows.Forms.Label();
            this.buttonGetID = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(60, 12);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 23);
            this.textBoxName.TabIndex = 0;
            this.textBoxName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxName_KeyDown);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 15);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(42, 15);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name:";
            // 
            // labelSectionID
            // 
            this.labelSectionID.AutoSize = true;
            this.labelSectionID.Location = new System.Drawing.Point(60, 67);
            this.labelSectionID.Name = "labelSectionID";
            this.labelSectionID.Size = new System.Drawing.Size(76, 15);
            this.labelSectionID.TabIndex = 2;
            this.labelSectionID.Text = "Enter a name";
            // 
            // buttonGetID
            // 
            this.buttonGetID.Location = new System.Drawing.Point(60, 41);
            this.buttonGetID.Name = "buttonGetID";
            this.buttonGetID.Size = new System.Drawing.Size(75, 23);
            this.buttonGetID.TabIndex = 3;
            this.buttonGetID.Text = "Get ID";
            this.buttonGetID.UseVisualStyleBackColor = true;
            this.buttonGetID.Click += new System.EventHandler(this.buttonGetID_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(191, 141);
            this.Controls.Add(this.buttonGetID);
            this.Controls.Add(this.labelSectionID);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxName;
        private Label labelName;
        private Label labelSectionID;
        private Button buttonGetID;
    }
}