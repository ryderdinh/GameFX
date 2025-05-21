using System.Security.Cryptography;

namespace ConfigurationLibrary
{
	public sealed class CryptoString
	{
		private static byte[] savedKey;

		private static byte[] savedIV;

		public static byte[] Key
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static byte[] IV
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private CryptoString()
		{
		}

		private static void RdGenerateSecretKey(RijndaelManaged rdProvider)
		{
		}

		private static void RdGenerateSecretInitVector(RijndaelManaged rdProvider)
		{
		}

		public static string Encrypt(string originalStr)
		{
			return null;
		}

		public static string Decrypt(string encryptedStr)
		{
			return null;
		}
	}
}
