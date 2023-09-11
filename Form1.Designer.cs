namespace png_screens
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
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.startBtn = new System.Windows.Forms.Button();
            this.progressLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(444, 94);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(200, 23);
            this.startDate.TabIndex = 0;
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(444, 145);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(200, 23);
            this.endDate.TabIndex = 1;
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(522, 291);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 2;
            this.startBtn.Text = "GO!";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // progressLbl
            // 
            this.progressLbl.AutoSize = true;
            this.progressLbl.Location = new System.Drawing.Point(535, 217);
            this.progressLbl.Name = "progressLbl";
            this.progressLbl.Size = new System.Drawing.Size(0, 15);
            this.progressLbl.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressLbl);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.startDate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker startDate;
        private DateTimePicker endDate;
        private Button startBtn;
        private Label progressLbl;
    }
}