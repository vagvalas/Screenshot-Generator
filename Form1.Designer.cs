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
            this.startHour = new System.Windows.Forms.NumericUpDown();
            this.startMinute = new System.Windows.Forms.NumericUpDown();
            this.endHour = new System.Windows.Forms.NumericUpDown();
            this.endMinute = new System.Windows.Forms.NumericUpDown();
            this.outDirectory = new System.Windows.Forms.Button();
            this.btnSource = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.startHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endMinute)).BeginInit();
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
            // startHour
            // 
            this.startHour.Location = new System.Drawing.Point(661, 94);
            this.startHour.Name = "startHour";
            this.startHour.Size = new System.Drawing.Size(47, 23);
            this.startHour.TabIndex = 3;
            // 
            // startMinute
            // 
            this.startMinute.Location = new System.Drawing.Point(714, 94);
            this.startMinute.Name = "startMinute";
            this.startMinute.Size = new System.Drawing.Size(51, 23);
            this.startMinute.TabIndex = 4;
            // 
            // endHour
            // 
            this.endHour.Location = new System.Drawing.Point(661, 145);
            this.endHour.Name = "endHour";
            this.endHour.Size = new System.Drawing.Size(47, 23);
            this.endHour.TabIndex = 5;
            // 
            // endMinute
            // 
            this.endMinute.Location = new System.Drawing.Point(714, 145);
            this.endMinute.Name = "endMinute";
            this.endMinute.Size = new System.Drawing.Size(51, 23);
            this.endMinute.TabIndex = 6;
            // 
            // outDirectory
            // 
            this.outDirectory.Location = new System.Drawing.Point(538, 214);
            this.outDirectory.Name = "outDirectory";
            this.outDirectory.Size = new System.Drawing.Size(160, 23);
            this.outDirectory.TabIndex = 7;
            this.outDirectory.Text = "POU THA BGOYN";
            this.outDirectory.UseVisualStyleBackColor = true;
            this.outDirectory.Click += new System.EventHandler(this.outDirectory_Click);
            // 
            // btnSource
            // 
            this.btnSource.Location = new System.Drawing.Point(286, 157);
            this.btnSource.Name = "btnSource";
            this.btnSource.Size = new System.Drawing.Size(94, 44);
            this.btnSource.TabIndex = 8;
            this.btnSource.Text = "SOURCE POY PAIRNW";
            this.btnSource.UseVisualStyleBackColor = true;
            this.btnSource.Click += new System.EventHandler(this.btnSource_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSource);
            this.Controls.Add(this.outDirectory);
            this.Controls.Add(this.endMinute);
            this.Controls.Add(this.endHour);
            this.Controls.Add(this.startMinute);
            this.Controls.Add(this.startHour);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.startDate);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.startHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endMinute)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DateTimePicker startDate;
        private DateTimePicker endDate;
        private Button startBtn;
        private NumericUpDown startHour;
        private NumericUpDown startMinute;
        private NumericUpDown endHour;
        private NumericUpDown endMinute;
        private Button outDirectory;
        private Button btnSource;
    }
}