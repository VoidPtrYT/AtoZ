#region Includes
using System;
using System.Windows.Forms;
using AtoZ.Convert;
#endregion

namespace AtoZ.Core
{
    /// <summary>
    /// Defines what type of change needs
    /// </summary>
    public enum ETypeChange : byte
    {
        /// <summary>
        /// If need edit language
        /// </summary>
        Language,
        /// <summary>
        /// If need edit register
        /// </summary>
        Register
    }

    /// <summary>
    /// Class of main form
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Type of change
        /// </summary>
        public static ETypeChange type;

        /// <summary>
        /// Constructor
        /// </summary>
        public MainForm()
        {
            this.InitializeComponent();
            MainForm.type = ETypeChange.Language;
        }

        #region Methods
        /// <summary>
        /// Change language
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void btnChangeLang_Click(object sender, EventArgs e)
        {
            MainForm.type = ETypeChange.Language;
            this.tbText_TextChanged(sender, e);
        }
        #endregion
        /// <summary>
        /// Change register
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void btnChangeRegister_Click(object sender, EventArgs e)
        {
            MainForm.type = ETypeChange.Register;
            this.tbText_TextChanged(sender, e);
        }
        /// <summary>
        /// Clerars fields
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.tbText.Text = "";
            this.tbResult.Text = "";
        }
        /// <summary>
        /// Exit application
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// If changed main field of text
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void tbText_TextChanged(object sender, EventArgs e)
        {
            switch (MainForm.type)
            {
                case ETypeChange.Language:
                    this.tbResult.Text = LanguageConvert.Convert(this.tbText.Text);
                    break;
                case ETypeChange.Register:
                    this.tbResult.Text = RegisterConvert.Convert(this.tbText.Text);
                    break;
            }
        }

        private void tbResult_DoubleClick(object sender, EventArgs e)
        {
            this.tbResult.Focus();
            this.tbResult.SelectAll();
            this.tbResult.Copy();
        }

        private void tbText_DoubleClick(object sender, EventArgs e)
        {
            this.tbText.Focus();
            this.tbText.SelectAll();
        }
    }
}
