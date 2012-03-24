namespace VisualUDK.Popups {
    partial class DeleteProjectChooser {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.DeleteReference = new System.Windows.Forms.Button();
            this.DeleteFromSystem = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ProjectText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteReference
            // 
            this.DeleteReference.Location = new System.Drawing.Point(99, 31);
            this.DeleteReference.Name = "DeleteReference";
            this.DeleteReference.Size = new System.Drawing.Size(153, 28);
            this.DeleteReference.TabIndex = 0;
            this.DeleteReference.Text = "Delete Reference Only";
            this.DeleteReference.UseVisualStyleBackColor = true;
            this.DeleteReference.Click += new System.EventHandler(this.DeleteReference_Click);
            // 
            // DeleteFromSystem
            // 
            this.DeleteFromSystem.Location = new System.Drawing.Point(99, 65);
            this.DeleteFromSystem.Name = "DeleteFromSystem";
            this.DeleteFromSystem.Size = new System.Drawing.Size(153, 28);
            this.DeleteFromSystem.TabIndex = 1;
            this.DeleteFromSystem.Text = "Delete From System";
            this.DeleteFromSystem.UseVisualStyleBackColor = true;
            this.DeleteFromSystem.Click += new System.EventHandler(this.DeleteFromSystem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VisualUDK.Properties.Resources.delete_project;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // ProjectText
            // 
            this.ProjectText.AutoSize = true;
            this.ProjectText.Location = new System.Drawing.Point(99, 12);
            this.ProjectText.Name = "ProjectText";
            this.ProjectText.Size = new System.Drawing.Size(35, 13);
            this.ProjectText.TabIndex = 3;
            this.ProjectText.Text = "label1";
            // 
            // DeleteProjectChooser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 103);
            this.Controls.Add(this.ProjectText);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DeleteFromSystem);
            this.Controls.Add(this.DeleteReference);
            this.Name = "DeleteProjectChooser";
            this.Text = "Delete Project?";
            this.Load += new System.EventHandler(this.DeleteProjectChooser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeleteReference;
        private System.Windows.Forms.Button DeleteFromSystem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ProjectText;
    }
}