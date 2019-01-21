namespace ClientForm
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
            this.sendMessageBtm = new System.Windows.Forms.Button();
            this.MessageBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // sendMessageBtm
            // 
            this.sendMessageBtm.Location = new System.Drawing.Point(102, 124);
            this.sendMessageBtm.Name = "sendMessageBtm";
            this.sendMessageBtm.Size = new System.Drawing.Size(75, 23);
            this.sendMessageBtm.TabIndex = 0;
            this.sendMessageBtm.Text = "Send";
            this.sendMessageBtm.UseVisualStyleBackColor = true;
            this.sendMessageBtm.Click += new System.EventHandler(this.sendMessageBtm_Click);
            // 
            // MessageBox
            // 
            this.MessageBox.Location = new System.Drawing.Point(74, 58);
            this.MessageBox.Name = "MessageBox";
            this.MessageBox.Size = new System.Drawing.Size(138, 22);
            this.MessageBox.TabIndex = 1;
            this.MessageBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.MessageBox);
            this.Controls.Add(this.sendMessageBtm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendMessageBtm;
        private System.Windows.Forms.TextBox MessageBox;
    }
}

