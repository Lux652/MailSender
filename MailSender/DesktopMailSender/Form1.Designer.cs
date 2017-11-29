namespace DesktopMailSender
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
            this.lblPrimatelj = new System.Windows.Forms.Label();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.lblTijelo = new System.Windows.Forms.Label();
            this.inptPrimatelj = new System.Windows.Forms.TextBox();
            this.inptNaslov = new System.Windows.Forms.TextBox();
            this.inptTijelo = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPrimatelj
            // 
            this.lblPrimatelj.AutoSize = true;
            this.lblPrimatelj.Location = new System.Drawing.Point(22, 9);
            this.lblPrimatelj.Name = "lblPrimatelj";
            this.lblPrimatelj.Size = new System.Drawing.Size(49, 13);
            this.lblPrimatelj.TabIndex = 0;
            this.lblPrimatelj.Text = "Primatelj:";
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Location = new System.Drawing.Point(22, 40);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(43, 13);
            this.lblNaslov.TabIndex = 1;
            this.lblNaslov.Text = "Naslov:";
            // 
            // lblTijelo
            // 
            this.lblTijelo.AutoSize = true;
            this.lblTijelo.Location = new System.Drawing.Point(22, 78);
            this.lblTijelo.Name = "lblTijelo";
            this.lblTijelo.Size = new System.Drawing.Size(71, 13);
            this.lblTijelo.TabIndex = 2;
            this.lblTijelo.Text = "Tijelo poruke:";
            // 
            // inptPrimatelj
            // 
            this.inptPrimatelj.Location = new System.Drawing.Point(73, 1);
            this.inptPrimatelj.Name = "inptPrimatelj";
            this.inptPrimatelj.Size = new System.Drawing.Size(100, 20);
            this.inptPrimatelj.TabIndex = 3;
            // 
            // inptNaslov
            // 
            this.inptNaslov.Location = new System.Drawing.Point(73, 32);
            this.inptNaslov.Name = "inptNaslov";
            this.inptNaslov.Size = new System.Drawing.Size(100, 20);
            this.inptNaslov.TabIndex = 4;
            // 
            // inptTijelo
            // 
            this.inptTijelo.Location = new System.Drawing.Point(25, 94);
            this.inptTijelo.Name = "inptTijelo";
            this.inptTijelo.Size = new System.Drawing.Size(192, 20);
            this.inptTijelo.TabIndex = 5;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(142, 130);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Pošalji";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 261);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.inptTijelo);
            this.Controls.Add(this.inptNaslov);
            this.Controls.Add(this.inptPrimatelj);
            this.Controls.Add(this.lblTijelo);
            this.Controls.Add(this.lblNaslov);
            this.Controls.Add(this.lblPrimatelj);
            this.Name = "Form1";
            this.Text = "Desktop Mail Sender v0.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrimatelj;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Label lblTijelo;
        private System.Windows.Forms.TextBox inptPrimatelj;
        private System.Windows.Forms.TextBox inptNaslov;
        private System.Windows.Forms.TextBox inptTijelo;
        private System.Windows.Forms.Button btnSend;
    }
}

