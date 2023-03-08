
namespace MusicPlayerApp
{
    partial class SettingsPopup
    {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsPopup));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.addDirectoriesButton = new System.Windows.Forms.Button();
            this.languageLabel = new System.Windows.Forms.GroupBox();
            this.languageSelect = new System.Windows.Forms.ComboBox();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.PictureBox();
            this.darkModeCheck = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.languageLabel.SuspendLayout();
            this.titlePanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.addDirectoriesButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.languageLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.darkModeCheck, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 43);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(217, 202);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // addDirectoriesButton
            // 
            this.addDirectoriesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.addDirectoriesButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addDirectoriesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addDirectoriesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addDirectoriesButton.ForeColor = System.Drawing.Color.White;
            this.addDirectoriesButton.Location = new System.Drawing.Point(8, 8);
            this.addDirectoriesButton.Name = "addDirectoriesButton";
            this.addDirectoriesButton.Size = new System.Drawing.Size(201, 34);
            this.addDirectoriesButton.TabIndex = 1;
            this.addDirectoriesButton.Text = "Add Directories";
            this.addDirectoriesButton.UseVisualStyleBackColor = false;
            this.addDirectoriesButton.Click += new System.EventHandler(this.addDirectoriesButton_Click);
            // 
            // languageLabel
            // 
            this.languageLabel.Controls.Add(this.languageSelect);
            this.languageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.languageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.languageLabel.Location = new System.Drawing.Point(8, 48);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.languageLabel.Size = new System.Drawing.Size(201, 54);
            this.languageLabel.TabIndex = 0;
            this.languageLabel.TabStop = false;
            this.languageLabel.Text = "Language";
            // 
            // languageSelect
            // 
            this.languageSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.languageSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.languageSelect.FormattingEnabled = true;
            this.languageSelect.Location = new System.Drawing.Point(20, 20);
            this.languageSelect.Name = "languageSelect";
            this.languageSelect.Size = new System.Drawing.Size(161, 24);
            this.languageSelect.TabIndex = 0;
            this.languageSelect.DropDownClosed += new System.EventHandler(this.languageSelect_DropDownClosed);
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.titlePanel.Controls.Add(this.tableLayoutPanel2);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(217, 40);
            this.titlePanel.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.titleLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.exitButton, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(217, 40);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(3, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(171, 40);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "label1";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleLabel_MouseDown);
            this.titleLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titleLabel_MouseMove);
            // 
            // exitButton
            // 
            this.exitButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.Location = new System.Drawing.Point(177, 0);
            this.exitButton.Margin = new System.Windows.Forms.Padding(0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(40, 40);
            this.exitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exitButton.TabIndex = 1;
            this.exitButton.TabStop = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            this.exitButton.MouseEnter += new System.EventHandler(this.exitButton_MouseEnter);
            this.exitButton.MouseLeave += new System.EventHandler(this.exitButton_MouseLeave);
            // 
            // darkModeCheck
            // 
            this.darkModeCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.darkModeCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.darkModeCheck.Location = new System.Drawing.Point(25, 108);
            this.darkModeCheck.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.darkModeCheck.Name = "darkModeCheck";
            this.darkModeCheck.Size = new System.Drawing.Size(184, 34);
            this.darkModeCheck.TabIndex = 2;
            this.darkModeCheck.Text = "Dark Mode";
            this.darkModeCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.darkModeCheck.UseVisualStyleBackColor = true;
            this.darkModeCheck.CheckedChanged += new System.EventHandler(this.darkModeCheck_CheckedChanged);
            // 
            // SettingsPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.ClientSize = new System.Drawing.Size(217, 252);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingsPopup";
            this.Text = "Settings";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.languageLabel.ResumeLayout(false);
            this.titlePanel.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox languageLabel;
        private System.Windows.Forms.ComboBox languageSelect;
        private System.Windows.Forms.Button addDirectoriesButton;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox exitButton;
        private System.Windows.Forms.CheckBox darkModeCheck;
    }
}