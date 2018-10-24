#region Includes
using System.Text;
#endregion
namespace AtoZ.Convert
{
    /// <summary>
    /// Static class of register convert
    /// </summary>
    public static class RegisterConvert
    {
        /// <summary>
        /// Static metod of convert register
        /// </summary>
        /// <param name="strSrc">Source string</param>
        /// <returns>Converted string</returns>
        public static string Convert(string strSrc)
        {
            if (strSrc == null)
                return null;
            StringBuilder sb = new StringBuilder();
            int iSize = strSrc.Length;
            char ch = '\0';

            for (int i = 0; i < iSize; ++i)
            {
                ch = strSrc[i];

                sb.Append(char.IsLetter(ch) ?
                    char.IsUpper(ch) ? char.ToLower(ch) : char.ToUpper(ch) :
                    ch);
            }

            return sb.ToString();
        }
    }
}
