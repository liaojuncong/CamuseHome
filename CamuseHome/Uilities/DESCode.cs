using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CamuseHome
{
    /// <summary>
    /// 加解密
    /// </summary>
    public static class DESCode
    {
        // KEY 8位
        private const string CodeKey = "congcong";
        private static readonly byte[] Keys = { 0xEF, 0xAB, 0x56, 0x78, 0x90, 0x34, 0xCD, 0x12 };

        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="encryptString"></param>
        /// <returns></returns>
        public static string EncryptDES(string encryptString)
        {
            return EncryptDES(encryptString, CodeKey);
        }

        /// <summary>
        /// 解密
        /// </summary>
        /// <param name="decryptString"></param>
        /// <returns></returns>
        public static string DecryptDES(string decryptString)
        {
            return DecryptDES(decryptString, CodeKey);
        }

        private static string EncryptDES(string encryptString, string codeKey)
        {
            MemoryStream mStream = null;
            CryptoStream cStream = null;
            try
            {
                var rgbKey = Encoding.UTF8.GetBytes(codeKey);
                var rgbIV = Keys;
                var inputByteArray = Encoding.UTF8.GetBytes(encryptString);
                var dcsp = new DESCryptoServiceProvider();
                mStream = new MemoryStream();
                cStream = new CryptoStream(mStream, dcsp.CreateEncryptor(rgbKey, rgbIV), CryptoStreamMode.Write);
                cStream.Write(inputByteArray, 0, inputByteArray.Length);
                cStream.FlushFinalBlock();
                var str = Convert.ToBase64String(mStream.ToArray());
                return str;
            }
            catch (Exception)
            {
                return encryptString;
            }
            finally
            {
                if (mStream != null)
                {
                    mStream.Close();
                    mStream.Dispose();
                }
                if (cStream != null)
                {
                    cStream.Close();
                    cStream.Dispose();
                }
            }
        }

        private static string DecryptDES(string decryptString, string codeKey)
        {
            MemoryStream mStream = null;
            CryptoStream cStream = null;
            try
            {
                var rgbKey = Encoding.UTF8.GetBytes(codeKey);
                var rgbIV = Keys;
                var inputByteArray = Convert.FromBase64String(decryptString);
                var dcsp = new DESCryptoServiceProvider();
                mStream = new MemoryStream();
                cStream = new CryptoStream(mStream, dcsp.CreateDecryptor(rgbKey, rgbIV), CryptoStreamMode.Write);
                cStream.Write(inputByteArray, 0, inputByteArray.Length);
                cStream.FlushFinalBlock();
                var str = Encoding.UTF8.GetString(mStream.ToArray());
                return str;
            }
            catch (Exception)
            {
                return decryptString;
            }
            finally
            {
                if (mStream != null)
                {
                    mStream.Close();
                    mStream.Dispose();
                }
                if (cStream != null)
                {
                    cStream.Close();
                    cStream.Dispose();
                }
            }
        }
    }
}
