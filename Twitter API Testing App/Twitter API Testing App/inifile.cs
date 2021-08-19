using System.Runtime.InteropServices;
using System.Text;
/// <summary>
/// INI�t�@�C���̓ǂݏ����N���X
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
        /// INI�t�@�C������l���擾����
        /// </summary>
        /// <param name="lpSection">�Z�b�V��������</param>
        /// <param name="lpKeyName">�L�[����</param>
        /// <param name="lpFileName">INI�t�@�C����</param>
        /// <returns></returns>
        public static string GetIniString(string lpSection, string lpKeyName, string lpFileName)
        {
            System.Text.StringBuilder strValue = new System.Text.StringBuilder(1024);

            uint sLen = GetPrivateProfileString(lpSection, lpKeyName, "", strValue, 1024, lpFileName);

            return strValue.ToString();
        }

        /// <summary>
        /// INI�t�@�C���ɒl����������
        /// </summary>
        /// <param name="lpSection">�Z�b�V��������</param>
        /// <param name="lpKeyName">�L�[����</param>
        /// <param name="lpValue">�Z�b�g����l</param>
        /// <param name="lpFileName">INI�t�@�C����</param>
        /// <returns></returns>
        public static bool PutIniString(string lpSection, string lpKeyName, string lpValue, string lpFileName)
        {
            long result = WritePrivateProfileString(lpSection, lpKeyName, lpValue, lpFileName);
            return result != 0;
        }
    }
}