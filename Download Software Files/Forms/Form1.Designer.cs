
namespace Download_Software_Files
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnDownload = new System.Windows.Forms.Button();
            this.nodeJs = new System.Windows.Forms.RadioButton();
            this.sublimeText = new System.Windows.Forms.RadioButton();
            this.vsCode = new System.Windows.Forms.RadioButton();
            this.git = new System.Windows.Forms.RadioButton();
            this.discord = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnDownload
            // 
            this.btnDownload.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDownload.Location = new System.Drawing.Point(247, 75);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(139, 46);
            this.btnDownload.TabIndex = 0;
            this.btnDownload.Text = "Download File(s)";
            this.btnDownload.UseVisualStyleBackColor = false;
            this.btnDownload.Click += new System.EventHandler(this.button1_Click);
            // 
            // nodeJs
            // 
            this.nodeJs.AutoSize = true;
            this.nodeJs.Location = new System.Drawing.Point(39, 58);
            this.nodeJs.Name = "nodeJs";
            this.nodeJs.Size = new System.Drawing.Size(61, 17);
            this.nodeJs.TabIndex = 1;
            this.nodeJs.TabStop = true;
            this.nodeJs.Text = "NodeJs";
            this.nodeJs.UseVisualStyleBackColor = true;
            // 
            // sublimeText
            // 
            this.sublimeText.AutoSize = true;
            this.sublimeText.Location = new System.Drawing.Point(39, 81);
            this.sublimeText.Name = "sublimeText";
            this.sublimeText.Size = new System.Drawing.Size(86, 17);
            this.sublimeText.TabIndex = 2;
            this.sublimeText.TabStop = true;
            this.sublimeText.Text = "Sublime Text";
            this.sublimeText.UseVisualStyleBackColor = true;
            // 
            // vsCode
            // 
            this.vsCode.AutoSize = true;
            this.vsCode.Location = new System.Drawing.Point(39, 104);
            this.vsCode.Name = "vsCode";
            this.vsCode.Size = new System.Drawing.Size(81, 17);
            this.vsCode.TabIndex = 3;
            this.vsCode.TabStop = true;
            this.vsCode.Text = "Visual Code";
            this.vsCode.UseVisualStyleBackColor = true;
            // 
            // git
            // 
            this.git.AutoSize = true;
            this.git.Location = new System.Drawing.Point(39, 127);
            this.git.Name = "git";
            this.git.Size = new System.Drawing.Size(58, 17);
            this.git.TabIndex = 4;
            this.git.TabStop = true;
            this.git.Text = "GitHub";
            this.git.UseVisualStyleBackColor = true;
            // 
            // discord
            // 
            this.discord.AutoSize = true;
            this.discord.Location = new System.Drawing.Point(39, 150);
            this.discord.Name = "discord";
            this.discord.Size = new System.Drawing.Size(61, 17);
            this.discord.TabIndex = 5;
            this.discord.TabStop = true;
            this.discord.Text = "Discord";
            this.discord.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(398, 222);
            this.Controls.Add(this.discord);
            this.Controls.Add(this.git);
            this.Controls.Add(this.vsCode);
            this.Controls.Add(this.sublimeText);
            this.Controls.Add(this.nodeJs);
            this.Controls.Add(this.btnDownload);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Software Downloader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.RadioButton nodeJs;
        private System.Windows.Forms.RadioButton sublimeText;
        private System.Windows.Forms.RadioButton vsCode;
        private System.Windows.Forms.RadioButton git;
        private System.Windows.Forms.RadioButton discord;
    }
}

