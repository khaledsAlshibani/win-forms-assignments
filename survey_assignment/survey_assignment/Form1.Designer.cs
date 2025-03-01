namespace survey_assignment
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
            this.Cource_Rate_Excellent = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Cource_Rate_Good = new System.Windows.Forms.RadioButton();
            this.Cource_Rate_Average = new System.Windows.Forms.RadioButton();
            this.CheckBox_Comments = new System.Windows.Forms.CheckBox();
            this.Comments = new System.Windows.Forms.TextBox();
            this.Submit_Survey = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Cource_Rate_Excellent
            // 
            this.Cource_Rate_Excellent.AutoSize = true;
            this.Cource_Rate_Excellent.Location = new System.Drawing.Point(103, 114);
            this.Cource_Rate_Excellent.Name = "Cource_Rate_Excellent";
            this.Cource_Rate_Excellent.Size = new System.Drawing.Size(68, 17);
            this.Cource_Rate_Excellent.TabIndex = 0;
            this.Cource_Rate_Excellent.TabStop = true;
            this.Cource_Rate_Excellent.Text = "Excellent";
            this.Cource_Rate_Excellent.UseVisualStyleBackColor = true;
            this.Cource_Rate_Excellent.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "How would you rate C# cource?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Cource_Rate_Good
            // 
            this.Cource_Rate_Good.AutoSize = true;
            this.Cource_Rate_Good.Location = new System.Drawing.Point(103, 137);
            this.Cource_Rate_Good.Name = "Cource_Rate_Good";
            this.Cource_Rate_Good.Size = new System.Drawing.Size(51, 17);
            this.Cource_Rate_Good.TabIndex = 2;
            this.Cource_Rate_Good.TabStop = true;
            this.Cource_Rate_Good.Text = "Good";
            this.Cource_Rate_Good.UseVisualStyleBackColor = true;
            // 
            // Cource_Rate_Average
            // 
            this.Cource_Rate_Average.AutoSize = true;
            this.Cource_Rate_Average.Location = new System.Drawing.Point(103, 160);
            this.Cource_Rate_Average.Name = "Cource_Rate_Average";
            this.Cource_Rate_Average.Size = new System.Drawing.Size(65, 17);
            this.Cource_Rate_Average.TabIndex = 3;
            this.Cource_Rate_Average.TabStop = true;
            this.Cource_Rate_Average.Text = "Average";
            this.Cource_Rate_Average.UseVisualStyleBackColor = true;
            // 
            // CheckBox_Comments
            // 
            this.CheckBox_Comments.AutoSize = true;
            this.CheckBox_Comments.Location = new System.Drawing.Point(103, 219);
            this.CheckBox_Comments.Name = "CheckBox_Comments";
            this.CheckBox_Comments.Size = new System.Drawing.Size(96, 17);
            this.CheckBox_Comments.TabIndex = 4;
            this.CheckBox_Comments.Text = "Add comments";
            this.CheckBox_Comments.UseVisualStyleBackColor = true;
            this.CheckBox_Comments.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Comments
            // 
            this.Comments.Location = new System.Drawing.Point(103, 242);
            this.Comments.Name = "Comments";
            this.Comments.Size = new System.Drawing.Size(157, 20);
            this.Comments.TabIndex = 5;
            // 
            // Submit_Survey
            // 
            this.Submit_Survey.Location = new System.Drawing.Point(103, 291);
            this.Submit_Survey.Name = "Submit_Survey";
            this.Submit_Survey.Size = new System.Drawing.Size(75, 23);
            this.Submit_Survey.TabIndex = 6;
            this.Submit_Survey.Text = "Submit";
            this.Submit_Survey.UseVisualStyleBackColor = true;
            this.Submit_Survey.Click += new System.EventHandler(this.Submit_Survey_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Submit_Survey);
            this.Controls.Add(this.Comments);
            this.Controls.Add(this.CheckBox_Comments);
            this.Controls.Add(this.Cource_Rate_Average);
            this.Controls.Add(this.Cource_Rate_Good);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cource_Rate_Excellent);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Cource_Rate_Excellent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton Cource_Rate_Good;
        private System.Windows.Forms.RadioButton Cource_Rate_Average;
        private System.Windows.Forms.CheckBox CheckBox_Comments;
        private System.Windows.Forms.TextBox Comments;
        private System.Windows.Forms.Button Submit_Survey;
    }
}

