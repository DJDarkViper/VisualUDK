namespace VisualUDK.Popups
{
    partial class Options
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.But_Submit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.But_EngineBrowse = new System.Windows.Forms.Button();
            this.txt_EnginePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.browseForEngine = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.But_Submit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 28);
            this.panel1.TabIndex = 0;
            // 
            // But_Submit
            // 
            this.But_Submit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.But_Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.But_Submit.Location = new System.Drawing.Point(464, 2);
            this.But_Submit.Name = "But_Submit";
            this.But_Submit.Size = new System.Drawing.Size(140, 23);
            this.But_Submit.TabIndex = 0;
            this.But_Submit.Text = "Submit Changes";
            this.But_Submit.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(608, 170);
            this.panel2.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(608, 170);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.But_EngineBrowse);
            this.tabPage1.Controls.Add(this.txt_EnginePath);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(600, 144);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Engine";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // But_EngineBrowse
            // 
            this.But_EngineBrowse.Location = new System.Drawing.Point(359, 12);
            this.But_EngineBrowse.Name = "But_EngineBrowse";
            this.But_EngineBrowse.Size = new System.Drawing.Size(75, 23);
            this.But_EngineBrowse.TabIndex = 2;
            this.But_EngineBrowse.Text = "Browse";
            this.But_EngineBrowse.UseVisualStyleBackColor = true;
            this.But_EngineBrowse.Click += new System.EventHandler(this.But_EngineBrowse_Click);
            // 
            // txt_EnginePath
            // 
            this.txt_EnginePath.Location = new System.Drawing.Point(82, 14);
            this.txt_EnginePath.Name = "txt_EnginePath";
            this.txt_EnginePath.Size = new System.Drawing.Size(271, 20);
            this.txt_EnginePath.TabIndex = 1;
            this.txt_EnginePath.TextChanged += new System.EventHandler(this.txt_EnginePath_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Engine Path:";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(600, 144);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Editor";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 198);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Options";
            this.Text = "Options & Settings";
            this.Load += new System.EventHandler(this.Options_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button But_Submit;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txt_EnginePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button But_EngineBrowse;
        private System.Windows.Forms.FolderBrowserDialog browseForEngine;

    }
}