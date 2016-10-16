namespace Animal_shelter
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_walkdog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(117, 85);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // btn_walkdog
            // 
            this.btn_walkdog.Location = new System.Drawing.Point(176, 131);
            this.btn_walkdog.Name = "btn_walkdog";
            this.btn_walkdog.Size = new System.Drawing.Size(75, 23);
            this.btn_walkdog.TabIndex = 1;
            this.btn_walkdog.Text = "Walk dog";
            this.btn_walkdog.UseVisualStyleBackColor = true;
            this.btn_walkdog.Click += new System.EventHandler(this.btn_walkdog_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 317);
            this.Controls.Add(this.btn_walkdog);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Form1";
            this.Text = "Dieren asiel app";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_walkdog;
    }
}

