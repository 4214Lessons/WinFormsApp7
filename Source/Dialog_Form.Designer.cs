namespace Source
{
    partial class Dialog_Form
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_openFile = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_openImage = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.lbl_folderPath = new System.Windows.Forms.Label();
            this.btn_OpenFolder = new System.Windows.Forms.Button();
            this.btn_openColorDialog = new System.Windows.Forms.Button();
            this.lbl_color = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.btn_fontDialog = new System.Windows.Forms.Button();
            this.lbl_font = new System.Windows.Forms.Label();
            this.lbl_shortcut = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 33);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(289, 187);
            this.textBox1.TabIndex = 0;
            this.textBox1.TabStop = false;
            // 
            // btn_openFile
            // 
            this.btn_openFile.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_openFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_openFile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_openFile.Location = new System.Drawing.Point(11, 230);
            this.btn_openFile.Margin = new System.Windows.Forms.Padding(4);
            this.btn_openFile.Name = "btn_openFile";
            this.btn_openFile.Size = new System.Drawing.Size(144, 48);
            this.btn_openFile.TabIndex = 1;
            this.btn_openFile.TabStop = false;
            this.btn_openFile.Text = "Open";
            this.btn_openFile.UseVisualStyleBackColor = false;
            this.btn_openFile.Click += new System.EventHandler(this.btn_openFile_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_save.Location = new System.Drawing.Point(158, 230);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(144, 48);
            this.btn_save.TabIndex = 1;
            this.btn_save.TabStop = false;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(821, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 187);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btn_openImage
            // 
            this.btn_openImage.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_openImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_openImage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_openImage.Location = new System.Drawing.Point(821, 230);
            this.btn_openImage.Margin = new System.Windows.Forms.Padding(4);
            this.btn_openImage.Name = "btn_openImage";
            this.btn_openImage.Size = new System.Drawing.Size(183, 48);
            this.btn_openImage.TabIndex = 1;
            this.btn_openImage.TabStop = false;
            this.btn_openImage.Text = "Open Picture";
            this.btn_openImage.UseVisualStyleBackColor = false;
            this.btn_openImage.Click += new System.EventHandler(this.btn_openImage_Click);
            // 
            // lbl_folderPath
            // 
            this.lbl_folderPath.AutoSize = true;
            this.lbl_folderPath.Location = new System.Drawing.Point(486, 89);
            this.lbl_folderPath.Name = "lbl_folderPath";
            this.lbl_folderPath.Size = new System.Drawing.Size(89, 21);
            this.lbl_folderPath.TabIndex = 3;
            this.lbl_folderPath.Text = "FolderPath";
            // 
            // btn_OpenFolder
            // 
            this.btn_OpenFolder.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_OpenFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_OpenFolder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_OpenFolder.Location = new System.Drawing.Point(459, 131);
            this.btn_OpenFolder.Margin = new System.Windows.Forms.Padding(4);
            this.btn_OpenFolder.Name = "btn_OpenFolder";
            this.btn_OpenFolder.Size = new System.Drawing.Size(153, 48);
            this.btn_OpenFolder.TabIndex = 1;
            this.btn_OpenFolder.TabStop = false;
            this.btn_OpenFolder.Text = "Open Folder";
            this.btn_OpenFolder.UseVisualStyleBackColor = false;
            this.btn_OpenFolder.Click += new System.EventHandler(this.Btn_openFolder_Click);
            // 
            // btn_openColorDialog
            // 
            this.btn_openColorDialog.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_openColorDialog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_openColorDialog.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_openColorDialog.Location = new System.Drawing.Point(41, 454);
            this.btn_openColorDialog.Margin = new System.Windows.Forms.Padding(4);
            this.btn_openColorDialog.Name = "btn_openColorDialog";
            this.btn_openColorDialog.Size = new System.Drawing.Size(164, 48);
            this.btn_openColorDialog.TabIndex = 1;
            this.btn_openColorDialog.TabStop = false;
            this.btn_openColorDialog.Text = "Open Color Dialog";
            this.btn_openColorDialog.UseVisualStyleBackColor = false;
            this.btn_openColorDialog.Click += new System.EventHandler(this.btn_openColorDialog_Click);
            // 
            // lbl_color
            // 
            this.lbl_color.AutoSize = true;
            this.lbl_color.Location = new System.Drawing.Point(96, 417);
            this.lbl_color.Name = "lbl_color";
            this.lbl_color.Size = new System.Drawing.Size(50, 21);
            this.lbl_color.TabIndex = 3;
            this.lbl_color.Text = "Color";
            // 
            // btn_fontDialog
            // 
            this.btn_fontDialog.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_fontDialog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fontDialog.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_fontDialog.Location = new System.Drawing.Point(448, 454);
            this.btn_fontDialog.Margin = new System.Windows.Forms.Padding(4);
            this.btn_fontDialog.Name = "btn_fontDialog";
            this.btn_fontDialog.Size = new System.Drawing.Size(164, 48);
            this.btn_fontDialog.TabIndex = 1;
            this.btn_fontDialog.TabStop = false;
            this.btn_fontDialog.Text = "Open Font Dialog";
            this.btn_fontDialog.UseVisualStyleBackColor = false;
            this.btn_fontDialog.Click += new System.EventHandler(this.btn_fontDialog_Click);
            // 
            // lbl_font
            // 
            this.lbl_font.AutoSize = true;
            this.lbl_font.Location = new System.Drawing.Point(503, 417);
            this.lbl_font.Name = "lbl_font";
            this.lbl_font.Size = new System.Drawing.Size(43, 21);
            this.lbl_font.TabIndex = 3;
            this.lbl_font.Text = "Font";
            // 
            // lbl_shortcut
            // 
            this.lbl_shortcut.AutoSize = true;
            this.lbl_shortcut.Location = new System.Drawing.Point(880, 454);
            this.lbl_shortcut.Name = "lbl_shortcut";
            this.lbl_shortcut.Size = new System.Drawing.Size(73, 21);
            this.lbl_shortcut.TabIndex = 3;
            this.lbl_shortcut.Text = "Shortcut";
            // 
            // Dialog_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 630);
            this.Controls.Add(this.lbl_shortcut);
            this.Controls.Add(this.lbl_font);
            this.Controls.Add(this.lbl_color);
            this.Controls.Add(this.lbl_folderPath);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_fontDialog);
            this.Controls.Add(this.btn_openColorDialog);
            this.Controls.Add(this.btn_OpenFolder);
            this.Controls.Add(this.btn_openImage);
            this.Controls.Add(this.btn_openFile);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dialog_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dialog_Form";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Dialog_Form_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private TextBox textBox1;
        private Button btn_openFile;
        private Button btn_save;
        private PictureBox pictureBox1;
        private Button btn_openImage;
        private SaveFileDialog saveFileDialog1;
        private FolderBrowserDialog folderBrowserDialog1;
        private Label lbl_folderPath;
        private Button btn_OpenFolder;
        private Button btn_openColorDialog;
        private Label lbl_color;
        private ColorDialog colorDialog1;
        private FontDialog fontDialog1;
        private Button btn_fontDialog;
        private Label lbl_font;
        private Label lbl_shortcut;
    }
}