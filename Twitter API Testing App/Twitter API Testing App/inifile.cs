using System.Runtime.InteropServices;
using System.Text;
/// <summary>
/// INIファイルの読み書きクラス
/// </summary>
namespace IniParser
{
    class IniFiles
    {
        [DllImport("KERNEL32.DLL")]
        private static extern uint GetPrivateProfileString(
            string lpAppName,
            string lpKeyName,
            string lpDefault,
            StringBuilder lpReturnedString,
            uint nSize,
            string lpFileName);

        [DllImport("KERNEL32.DLL")]
        private static extern uint GetPrivateProfileInt(
            string lpAppName,
            string lpKeyName,
            int nDefault,
            string lpFileName);

        [DllImport("KERNEL32.DLL")]
        private static extern uint WritePrivateProfileString(
            string lpAppName,
            string lpKeyName,
            string lpString,
            string lpFileName);


        /// <summary>
        /// INIファイルから値を取得する
        /// </summary>
        /// <param name="lpSection">セッション名称</param>
        /// <param name="lpKeyName">キー名称</param>
        /// <param name="lpFileName">INIファイル名</param>
        /// <returns></returns>
        public static string GetIniString(string lpSection, string lpKeyName, string lpFileName)
        {
            System.Text.StringBuilder strValue = new System.Text.StringBuilder(1024);

            uint sLen = GetPrivateProfileString(lpSection, lpKeyName, "", strValue, 1024, lpFileName);

            return strValue.ToString();
        }

        /// <summary>
        /// INIファイルに値を書き込む
        /// </summary>
        /// <param name="lpSection">セッション名称</param>
        /// <param name="lpKeyName">キー名称</param>
        /// <param name="lpValue">セットする値</param>
        /// <param name="lpFileName">INIファイル名</param>
        /// <returns></returns>
        public static bool PutIniString(string lpSection, string lpKeyName, string lpValue, string lpFileName)
        {
            long result = WritePrivateProfileString(lpSection, lpKeyName, lpValue, lpFileName);
            return result != 0;
        }
    }
}