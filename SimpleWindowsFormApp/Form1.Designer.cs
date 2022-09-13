
namespace SimpleWindowsFormApp
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
            this.btn_hello = new System.Windows.Forms.Button();
            this.lbl_hellomsg = new System.Windows.Forms.Label();
            this.btn_color = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_hello
            // 
            this.btn_hello.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_hello.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_hello.Location = new System.Drawing.Point(333, 188);
            this.btn_hello.Name = "btn_hello";
            this.btn_hello.Size = new System.Drawing.Size(91, 50);
            this.btn_hello.TabIndex = 0;
            this.btn_hello.Text = "Hello, Click Me!";
            this.btn_hello.UseVisualStyleBackColor = false;
            this.btn_hello.Click += new System.EventHandler(this.btn_hello_Click);
            // 
            // lbl_hellomsg
            // 
            this.lbl_hellomsg.AutoSize = true;
            this.lbl_hellomsg.Location = new System.Drawing.Point(361, 172);
            this.lbl_hellomsg.Name = "lbl_hellomsg";
            this.lbl_hellomsg.Size = new System.Drawing.Size(0, 13);
            this.lbl_hellomsg.TabIndex = 1;
            // 
            // btn_color
            // 
            this.btn_color.Location = new System.Drawing.Point(441, 188);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(92, 50);
            this.btn_color.TabIndex = 2;
            this.btn_color.Text = "Change Color!";
            this.btn_color.UseVisualStyleBackColor = true;
            this.btn_color.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_color);
            this.Controls.Add(this.lbl_hellomsg);
            this.Controls.Add(this.btn_hello);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_hello;
        private System.Windows.Forms.Label lbl_hellomsg;
        private System.Windows.Forms.Button btn_color;
    }
}

