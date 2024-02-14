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
            this.button1 = new System.Windows.Forms.Button();
            this.numericIrritations = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.startHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericIrritations)).BeginInit();
            this.SuspendLayout();
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(440, 48);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(200, 23);
            this.startDate.TabIndex = 0;
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(440, 99);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(200, 23);
            this.endDate.TabIndex = 1;
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(648, 325);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 2;
            this.startBtn.Text = "GO!";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // startHour
            // 
            this.startHour.Location = new System.Drawing.Point(494, 181);
            this.startHour.Name = "startHour";
            this.startHour.Size = new System.Drawing.Size(47, 23);
            this.startHour.TabIndex = 3;
            // 
            // startMinute
            // 
            this.startMinute.Location = new System.Drawing.Point(547, 181);
            this.startMinute.Name = "startMinute";
            this.startMinute.Size = new System.Drawing.Size(51, 23);
            this.startMinute.TabIndex = 4;
            // 
            // endHour
            // 
            this.endHour.Location = new System.Drawing.Point(494, 219);
            this.endHour.Name = "endHour";
            this.endHour.Size = new System.Drawing.Size(47, 23);
            this.endHour.TabIndex = 5;
            // 
            // endMinute
            // 
            this.endMinute.Location = new System.Drawing.Point(547, 219);
            this.endMinute.Name = "endMinute";
            this.endMinute.Size = new System.Drawing.Size(51, 23);
            this.endMinute.TabIndex = 6;
            // 
            // outDirectory
            // 
            this.outDirectory.Location = new System.Drawing.Point(172, 158);
            this.outDirectory.Name = "outDirectory";
            this.outDirectory.Size = new System.Drawing.Size(75, 50);
            this.outDirectory.TabIndex = 7;
            this.outDirectory.Text = "EXPORT PATH";
            this.outDirectory.UseVisualStyleBackColor = true;
            this.outDirectory.Click += new System.EventHandler(this.outDirectory_Click);
            // 
            // btnSource
            // 
            this.btnSource.Location = new System.Drawing.Point(172, 99);
            this.btnSource.Name = "btnSource";
            this.btnSource.Size = new System.Drawing.Size(75, 53);
            this.btnSource.TabIndex = 8;
            this.btnSource.Text = "Source of Base Images";
            this.btnSource.UseVisualStyleBackColor = true;
            this.btnSource.Click += new System.EventHandler(this.btnSource_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(172, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 39);
            this.button1.TabIndex = 9;
            this.button1.Text = "SELECT PNG ONLY";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericIrritations
            // 
            this.numericIrritations.Location = new System.Drawing.Point(494, 265);
            this.numericIrritations.Name = "numericIrritations";
            this.numericIrritations.Size = new System.Drawing.Size(75, 23);
            this.numericIrritations.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(368, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 30);
            this.label1.TabIndex = 14;
            this.label1.Text = "Irritations/per day \r\n(screenshots per day)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 30);
            this.label2.TabIndex = 15;
            this.label2.Text = "1. Pick a \"middle\" image \r\nalong irritations";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(363, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Starting Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(363, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Ending Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(369, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 21);
            this.label5.TabIndex = 18;
            this.label5.Text = "/PER DAY details:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(368, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "First HHour MMinute";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(369, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "Last HHour MMinute";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 60);
            this.label8.TabIndex = 21;
            this.label8.Text = "2. Select source path \r\nfor image (pngs) \r\nwhich will be \r\nirritating along all d" +
    "ates";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(575, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 45);
            this.label9.TabIndex = 22;
            this.label9.Text = "Careful! this will calculate the\r\ninterval needed for each \r\nscreenshot per day";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericIrritations);
            this.Controls.Add(this.button1);
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
            ((System.ComponentModel.ISupportInitialize)(this.numericIrritations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Button button1;
        private NumericUpDown numericIrritations;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}