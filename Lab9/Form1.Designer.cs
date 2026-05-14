namespace Lab9
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
            progressBar1 = new ProgressBar();
            progressBar2 = new ProgressBar();
            progressBar3 = new ProgressBar();
            listBox1 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(44, 22);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(1302, 34);
            progressBar1.TabIndex = 0;
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(44, 72);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(1302, 34);
            progressBar2.TabIndex = 1;
            // 
            // progressBar3
            // 
            progressBar3.Location = new Point(44, 126);
            progressBar3.Name = "progressBar3";
            progressBar3.Size = new Size(1302, 34);
            progressBar3.TabIndex = 2;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(44, 191);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(374, 304);
            listBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(508, 191);
            button1.Name = "button1";
            button1.Size = new Size(404, 53);
            button1.TabIndex = 4;
            button1.Text = "Başlat";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(942, 191);
            button2.Name = "button2";
            button2.Size = new Size(404, 53);
            button2.TabIndex = 5;
            button2.Text = "Sıfırla";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(508, 266);
            button3.Name = "button3";
            button3.Size = new Size(404, 53);
            button3.TabIndex = 6;
            button3.Text = " Senkron Interlock";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(942, 266);
            button4.Name = "button4";
            button4.Size = new Size(404, 57);
            button4.TabIndex = 7;
            button4.Text = "Senkron Mutex";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(508, 349);
            button5.Name = "button5";
            button5.Size = new Size(404, 57);
            button5.TabIndex = 8;
            button5.Text = "Senkron Lock";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(942, 349);
            button6.Name = "button6";
            button6.Size = new Size(404, 57);
            button6.TabIndex = 9;
            button6.Text = "Senkron Semaphore";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(508, 438);
            button7.Name = "button7";
            button7.Size = new Size(404, 57);
            button7.TabIndex = 10;
            button7.Text = "Senkron Monitor";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1383, 529);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(progressBar3);
            Controls.Add(progressBar2);
            Controls.Add(progressBar1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ProgressBar progressBar1;
        private ProgressBar progressBar2;
        private ProgressBar progressBar3;
        private ListBox listBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
    }
}
