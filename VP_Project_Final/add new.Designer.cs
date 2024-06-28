namespace VP_Project_Final
{
    partial class add_new
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_NAME = new System.Windows.Forms.TextBox();
            this.textBox_MODEL = new System.Windows.Forms.TextBox();
            this.textBox_VARIENT = new System.Windows.Forms.TextBox();
            this.textBox_MAKE = new System.Windows.Forms.TextBox();
            this.textBox_CHASISNUM = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(106, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "MODEL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "VARIENT";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "MAKE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "CHASIS NUMBER";
            // 
            // textBox_NAME
            // 
            this.textBox_NAME.Location = new System.Drawing.Point(154, 38);
            this.textBox_NAME.Name = "textBox_NAME";
            this.textBox_NAME.Size = new System.Drawing.Size(100, 20);
            this.textBox_NAME.TabIndex = 6;
            // 
            // textBox_MODEL
            // 
            this.textBox_MODEL.Location = new System.Drawing.Point(154, 89);
            this.textBox_MODEL.Name = "textBox_MODEL";
            this.textBox_MODEL.Size = new System.Drawing.Size(100, 20);
            this.textBox_MODEL.TabIndex = 7;
            // 
            // textBox_VARIENT
            // 
            this.textBox_VARIENT.Location = new System.Drawing.Point(154, 143);
            this.textBox_VARIENT.Name = "textBox_VARIENT";
            this.textBox_VARIENT.Size = new System.Drawing.Size(100, 20);
            this.textBox_VARIENT.TabIndex = 8;
            // 
            // textBox_MAKE
            // 
            this.textBox_MAKE.Location = new System.Drawing.Point(154, 194);
            this.textBox_MAKE.Name = "textBox_MAKE";
            this.textBox_MAKE.Size = new System.Drawing.Size(100, 20);
            this.textBox_MAKE.TabIndex = 9;
            // 
            // textBox_CHASISNUM
            // 
            this.textBox_CHASISNUM.Location = new System.Drawing.Point(154, 243);
            this.textBox_CHASISNUM.Name = "textBox_CHASISNUM";
            this.textBox_CHASISNUM.Size = new System.Drawing.Size(100, 20);
            this.textBox_CHASISNUM.TabIndex = 10;
            // 
            // add_new
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 338);
            this.Controls.Add(this.textBox_CHASISNUM);
            this.Controls.Add(this.textBox_MAKE);
            this.Controls.Add(this.textBox_VARIENT);
            this.Controls.Add(this.textBox_MODEL);
            this.Controls.Add(this.textBox_NAME);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "add_new";
            this.Text = "add_new";
            this.Load += new System.EventHandler(this.add_new_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_NAME;
        private System.Windows.Forms.TextBox textBox_MODEL;
        private System.Windows.Forms.TextBox textBox_VARIENT;
        private System.Windows.Forms.TextBox textBox_MAKE;
        private System.Windows.Forms.TextBox textBox_CHASISNUM;
    }
}