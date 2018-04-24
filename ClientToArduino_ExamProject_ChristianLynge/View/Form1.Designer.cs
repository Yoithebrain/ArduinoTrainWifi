namespace ClientToArduino_ExamProject_ChristianLynge
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
            this.textboxInput = new System.Windows.Forms.TextBox();
            this.sendbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textboxInput
            // 
            this.textboxInput.Location = new System.Drawing.Point(64, 127);
            this.textboxInput.Name = "textboxInput";
            this.textboxInput.Size = new System.Drawing.Size(669, 22);
            this.textboxInput.TabIndex = 0;
            this.textboxInput.TextChanged += new System.EventHandler(this.textboxInput_TextChanged);
            // 
            // sendbtn
            // 
            this.sendbtn.Location = new System.Drawing.Point(334, 204);
            this.sendbtn.Name = "sendbtn";
            this.sendbtn.Size = new System.Drawing.Size(75, 23);
            this.sendbtn.TabIndex = 1;
            this.sendbtn.Text = "send";
            this.sendbtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sendbtn);
            this.Controls.Add(this.textboxInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textboxInput;
        private System.Windows.Forms.Button sendbtn;
    }
}