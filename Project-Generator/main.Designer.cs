namespace Project_Generator
{
    partial class Main_Form
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.Create_button = new System.Windows.Forms.Button();
            this.Project_label = new System.Windows.Forms.Label();
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.Folder_label = new System.Windows.Forms.Label();
            this.Folder_textBox = new System.Windows.Forms.TextBox();
            this.folder_button = new System.Windows.Forms.Button();
            this.folder_openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_subfolder = new System.Windows.Forms.TextBox();
            this.button_reset_subfolder = new System.Windows.Forms.Button();
            this.pictureBox_qiheyehk = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_qiheyehk)).BeginInit();
            this.SuspendLayout();
            // 
            // Create_button
            // 
            this.Create_button.Location = new System.Drawing.Point(415, 332);
            this.Create_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Create_button.Name = "Create_button";
            this.Create_button.Size = new System.Drawing.Size(100, 28);
            this.Create_button.TabIndex = 0;
            this.Create_button.Text = "Create";
            this.Create_button.UseVisualStyleBackColor = true;
            this.Create_button.Click += new System.EventHandler(this.Create_button_Click);
            // 
            // Project_label
            // 
            this.Project_label.AutoSize = true;
            this.Project_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Project_label.Location = new System.Drawing.Point(13, 58);
            this.Project_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Project_label.Name = "Project_label";
            this.Project_label.Size = new System.Drawing.Size(110, 17);
            this.Project_label.TabIndex = 1;
            this.Project_label.Text = "Project Name:";
            // 
            // Name_textBox
            // 
            this.Name_textBox.Location = new System.Drawing.Point(135, 55);
            this.Name_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(186, 22);
            this.Name_textBox.TabIndex = 2;
            // 
            // Folder_label
            // 
            this.Folder_label.AutoSize = true;
            this.Folder_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Folder_label.Location = new System.Drawing.Point(13, 23);
            this.Folder_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Folder_label.Name = "Folder_label";
            this.Folder_label.Size = new System.Drawing.Size(115, 17);
            this.Folder_label.TabIndex = 3;
            this.Folder_label.Text = "Project Folder:";
            // 
            // Folder_textBox
            // 
            this.Folder_textBox.Location = new System.Drawing.Point(135, 23);
            this.Folder_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Folder_textBox.Name = "Folder_textBox";
            this.Folder_textBox.ReadOnly = true;
            this.Folder_textBox.Size = new System.Drawing.Size(379, 22);
            this.Folder_textBox.TabIndex = 4;
            // 
            // folder_button
            // 
            this.folder_button.Location = new System.Drawing.Point(390, 53);
            this.folder_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.folder_button.Name = "folder_button";
            this.folder_button.Size = new System.Drawing.Size(124, 28);
            this.folder_button.TabIndex = 5;
            this.folder_button.Text = "Select Folder";
            this.folder_button.UseVisualStyleBackColor = true;
            this.folder_button.Click += new System.EventHandler(this.folder_button_Click);
            // 
            // folder_openFileDialog
            // 
            this.folder_openFileDialog.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(13, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sub folder(Default List, Can be updated):";
            // 
            // textBox_subfolder
            // 
            this.textBox_subfolder.Location = new System.Drawing.Point(135, 112);
            this.textBox_subfolder.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_subfolder.Multiline = true;
            this.textBox_subfolder.Name = "textBox_subfolder";
            this.textBox_subfolder.Size = new System.Drawing.Size(186, 212);
            this.textBox_subfolder.TabIndex = 7;
            this.textBox_subfolder.Text = "1.Project-Info\r\n2.LLD-HOT-Config\r\n3.TOL-Report\r\n4.Activities\r\n5.Login-Info\r\n6.Log" +
    "s\r\n7.Trace\r\n8.Software\r\n9.Issues\r\n10.Travel\r\n11.Others";
            // 
            // button_reset_subfolder
            // 
            this.button_reset_subfolder.Location = new System.Drawing.Point(135, 332);
            this.button_reset_subfolder.Margin = new System.Windows.Forms.Padding(4);
            this.button_reset_subfolder.Name = "button_reset_subfolder";
            this.button_reset_subfolder.Size = new System.Drawing.Size(157, 28);
            this.button_reset_subfolder.TabIndex = 8;
            this.button_reset_subfolder.Text = "Reset Sub Folder";
            this.button_reset_subfolder.UseVisualStyleBackColor = true;
            this.button_reset_subfolder.Click += new System.EventHandler(this.button_reset_subfolder_Click);
            // 
            // pictureBox_qiheyehk
            // 
            this.pictureBox_qiheyehk.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_qiheyehk.Image")));
            this.pictureBox_qiheyehk.Location = new System.Drawing.Point(16, 257);
            this.pictureBox_qiheyehk.Name = "pictureBox_qiheyehk";
            this.pictureBox_qiheyehk.Size = new System.Drawing.Size(107, 104);
            this.pictureBox_qiheyehk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_qiheyehk.TabIndex = 9;
            this.pictureBox_qiheyehk.TabStop = false;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 373);
            this.Controls.Add(this.pictureBox_qiheyehk);
            this.Controls.Add(this.button_reset_subfolder);
            this.Controls.Add(this.textBox_subfolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.folder_button);
            this.Controls.Add(this.Folder_textBox);
            this.Controls.Add(this.Folder_label);
            this.Controls.Add(this.Name_textBox);
            this.Controls.Add(this.Project_label);
            this.Controls.Add(this.Create_button);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Main_Form";
            this.Text = "Project-Generator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_qiheyehk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Create_button;
        private System.Windows.Forms.Label Project_label;
        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.Label Folder_label;
        private System.Windows.Forms.TextBox Folder_textBox;
        private System.Windows.Forms.Button folder_button;
        private System.Windows.Forms.OpenFileDialog folder_openFileDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_subfolder;
        private System.Windows.Forms.Button button_reset_subfolder;
        private System.Windows.Forms.PictureBox pictureBox_qiheyehk;
    }
}

