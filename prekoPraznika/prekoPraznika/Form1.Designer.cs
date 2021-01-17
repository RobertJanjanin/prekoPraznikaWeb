
namespace prekoPraznika
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
            this.buttonNatrag = new System.Windows.Forms.Button();
            this.buttonNaprijed = new System.Windows.Forms.Button();
            this.buttonWebmail = new System.Windows.Forms.Button();
            this.buttonGmail = new System.Windows.Forms.Button();
            this.buttonIspis = new System.Windows.Forms.Button();
            this.buttonIdi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // buttonNatrag
            // 
            this.buttonNatrag.Location = new System.Drawing.Point(12, 12);
            this.buttonNatrag.Name = "buttonNatrag";
            this.buttonNatrag.Size = new System.Drawing.Size(75, 23);
            this.buttonNatrag.TabIndex = 0;
            this.buttonNatrag.Text = "Natrag";
            this.buttonNatrag.UseVisualStyleBackColor = true;
            this.buttonNatrag.Click += new System.EventHandler(this.buttonNatrag_Click);
            // 
            // buttonNaprijed
            // 
            this.buttonNaprijed.Location = new System.Drawing.Point(93, 12);
            this.buttonNaprijed.Name = "buttonNaprijed";
            this.buttonNaprijed.Size = new System.Drawing.Size(75, 23);
            this.buttonNaprijed.TabIndex = 1;
            this.buttonNaprijed.Text = "Naprijed";
            this.buttonNaprijed.UseVisualStyleBackColor = true;
            this.buttonNaprijed.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonWebmail
            // 
            this.buttonWebmail.Location = new System.Drawing.Point(609, 11);
            this.buttonWebmail.Name = "buttonWebmail";
            this.buttonWebmail.Size = new System.Drawing.Size(55, 25);
            this.buttonWebmail.TabIndex = 2;
            this.buttonWebmail.Text = "Webmail";
            this.buttonWebmail.UseVisualStyleBackColor = true;
            this.buttonWebmail.Click += new System.EventHandler(this.buttonWebmail_Click);
            // 
            // buttonGmail
            // 
            this.buttonGmail.Location = new System.Drawing.Point(524, 11);
            this.buttonGmail.Name = "buttonGmail";
            this.buttonGmail.Size = new System.Drawing.Size(58, 24);
            this.buttonGmail.TabIndex = 3;
            this.buttonGmail.Text = "G-mail";
            this.buttonGmail.UseVisualStyleBackColor = true;
            this.buttonGmail.Click += new System.EventHandler(this.buttonGmail_Click);
            // 
            // buttonIspis
            // 
            this.buttonIspis.Location = new System.Drawing.Point(700, 12);
            this.buttonIspis.Name = "buttonIspis";
            this.buttonIspis.Size = new System.Drawing.Size(58, 23);
            this.buttonIspis.TabIndex = 4;
            this.buttonIspis.Text = "Ispis";
            this.buttonIspis.UseVisualStyleBackColor = true;
            this.buttonIspis.Click += new System.EventHandler(this.buttonIspis_Click);
            // 
            // buttonIdi
            // 
            this.buttonIdi.Location = new System.Drawing.Point(435, 11);
            this.buttonIdi.Name = "buttonIdi";
            this.buttonIdi.Size = new System.Drawing.Size(59, 24);
            this.buttonIdi.TabIndex = 5;
            this.buttonIdi.Text = "Idi";
            this.buttonIdi.UseVisualStyleBackColor = true;
            this.buttonIdi.Click += new System.EventHandler(this.buttonIdi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Adresa";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(220, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 20);
            this.textBox1.TabIndex = 7;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 41);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(746, 397);
            this.webBrowser1.TabIndex = 8;
            this.webBrowser1.Url = new System.Uri("http://web2.ss-zcrnje-rovinj.skole.hr/", System.UriKind.Absolute);
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonIdi);
            this.Controls.Add(this.buttonIspis);
            this.Controls.Add(this.buttonGmail);
            this.Controls.Add(this.buttonWebmail);
            this.Controls.Add(this.buttonNaprijed);
            this.Controls.Add(this.buttonNatrag);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNatrag;
        private System.Windows.Forms.Button buttonNaprijed;
        private System.Windows.Forms.Button buttonWebmail;
        private System.Windows.Forms.Button buttonGmail;
        private System.Windows.Forms.Button buttonIspis;
        private System.Windows.Forms.Button buttonIdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

