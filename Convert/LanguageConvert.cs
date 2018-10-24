#region Includes
using AtoZ.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
#endregion

namespace AtoZ.Convert
{
    /// <summary>
    /// static class of language convert
    /// </summary>
    public static class LanguageConvert
    { 
        private static Dictionary<char, char> dctTranslate = null;
        private const string FILE_PATH = "lang.dat";
        private static readonly char[] SEPARATOR = new char[] { ' ' };
        private const int SPLIT_STRINGS = 2;

        /// <summary>
        /// Main constructor of static class
        /// </summary>
        static LanguageConvert()
        {
            if (!File.Exists(LanguageConvert.FILE_PATH))
            {
                MessageBox.Show("Not found file with translate! Only convert register...",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                MainForm.type = ETypeChange.Register;
                return;
            }

            string[] sTmp = File.ReadAllLines(LanguageConvert.FILE_PATH);
            int iSize = sTmp.Length;
            LanguageConvert.dctTranslate = new Dictionary<char, char>();

            for (int i = 0; i < iSize; ++i)
            {
                string[] sSplit = sTmp[i].Split(LanguageConvert.SEPARATOR);
                if (sSplit.Length != LanguageConvert.SPLIT_STRINGS ||
                    LanguageConvert.dctTranslate.ContainsKey(sSplit[0][0]))
                    continue;
                LanguageConvert.dctTranslate.Add(sSplit[0][0], sSplit[1][0]);
            }
        }

        /// <summary>
        /// Static metod of convert language
        /// </summary>
        /// <param name="strSrc">Source string</param>
        /// <returns>Converted string</returns>
        public static string Convert(string strSrc)
        {
            if (strSrc == null)
                return null;
            if (LanguageConvert.dctTranslate == null)
            {
                MessageBox.Show("Not found file with translate! Only convert register...",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                MainForm.type = ETypeChange.Register;
                return null;
            }

            StringBuilder sb = new StringBuilder();
            int iSize = strSrc.Length;

            for (int i = 0; i < iSize; ++i)
            {
                if (LanguageConvert.dctTranslate.ContainsKey(strSrc[i]))
                    sb.Append(LanguageConvert.dctTranslate[strSrc[i]]);
                else
                    sb.Append(strSrc[i]);
            }

            return sb.ToString();
        }
    }
}