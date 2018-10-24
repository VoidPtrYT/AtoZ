namespace AtoZ.Core
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MsMain = new System.Windows.Forms.MenuStrip();
            this.btnChangeLang = new System.Windows.Forms.ToolStripMenuItem();
            this.btnChangeRegister = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClear = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tbText = new System.Windows.Forms.TextBox();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.MsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // MsMain
            // 
            this.MsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnChangeLang,
            this.btnChangeRegister,
            this.btnClear,
            this.btnExit});
            this.MsMain.Location = new System.Drawing.Point(0, 0);
            this.MsMain.Name = "MsMain";
            this.MsMain.Size = new System.Drawing.Size(484, 24);
            this.MsMain.TabIndex = 0;
            this.MsMain.Text = "menuStrip1";
            // 
            // btnChangeLang
            // 
            this.btnChangeLang.Name = "btnChangeLang";
            this.btnChangeLang.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.btnChangeLang.Size = new System.Drawing.Size(90, 20);
            this.btnChangeLang.Text = "&Смена языка";
            this.btnChangeLang.Click += new System.EventHandler(this.btnChangeLang_Click);
            // 
            // btnChangeRegister
            // 
            this.btnChangeRegister.Name = "btnChangeRegister";
            this.btnChangeRegister.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.btnChangeRegister.Size = new System.Drawing.Size(107, 20);
            this.btnChangeRegister.Text = "&Смена регистра";
            this.btnChangeRegister.Click += new System.EventHandler(this.btnChangeRegister_Click);
            // 
            // btnClear
            // 
            this.btnClear.Name = "btnClear";
            this.btnClear.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.btnClear.Size = new System.Drawing.Size(65, 20);
            this.btnClear.Text = "О&чистка";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Name = "btnExit";
            this.btnExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.btnExit.Size = new System.Drawing.Size(53, 20);
            this.btnExit.Text = "&Выход";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tbText
            // 
            this.tbText.AcceptsReturn = true;
            this.tbText.AcceptsTab = true;
            this.tbText.AllowDrop = true;
            this.tbText.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbText.Location = new System.Drawing.Point(0, 30);
            this.tbText.MaxLength = 65535;
            this.tbText.Multiline = true;
            this.tbText.Name = "tbText";
            this.tbText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbText.Size = new System.Drawing.Size(235, 235);
            this.tbText.TabIndex = 1;
            this.tbText.TextChanged += new System.EventHandler(this.tbText_TextChanged);
            this.tbText.DoubleClick += new System.EventHandler(this.tbText_DoubleClick);
            // 
            // tbResult
            // 
            this.tbResult.AcceptsReturn = true;
            this.tbResult.AcceptsTab = true;
            this.tbResult.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbResult.Location = new System.Drawing.Point(245, 30);
            this.tbResult.MaxLength = 65535;
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbResult.Size = new System.Drawing.Size(235, 235);
            this.tbResult.TabIndex = 2;
            this.tbResult.DoubleClick += new System.EventHandler(this.tbResult_DoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 262);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.MsMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MsMain;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AtoZ";
            this.MsMain.ResumeLayout(false);
            this.MsMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MsMain;
        private System.Windows.Forms.ToolStripMenuItem btnChangeLang;
        private System.Windows.Forms.ToolStripMenuItem btnChangeRegister;
        private System.Windows.Forms.ToolStripMenuItem btnClear;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.ToolStripMenuItem btnExit;
    }
}

