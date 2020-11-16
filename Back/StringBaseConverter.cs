using System;
using System.Collections;
using System.Globalization;

namespace BinViewer.Back
{
	public class StringBaseConverter
	{
		public static string HexToBit(string value)
		{
			var valByte = HexStringToByteArray(value);
			var valBitArr = new BitArray(valByte);
			var bitString = "";

			for (int i = 0; i < valBitArr.Length; i += 8)
			{
				for (int j = i + 7; j >= i; j--)
				{
					if (valBitArr[j])
					{
						bitString += "1";
					}
					else
					{
						bitString += "0";
					}
				}
			}

			return bitString.TrimStart('0').PadLeft(1, '0');
		}

		public static string HexToDec(string value)
		{
			return ulong.Parse(value, NumberStyles.HexNumber).ToString();
		}

		public static string HexToOct(string value)
		{
			return Convert.ToString(Convert.ToInt64(value, 16), 8);
		}

		public static string BinToHex(string value)
		{
			return Convert.ToUInt64(value, 2).ToString("X");
		}

		public static string BinToDec(string value)
		{
			return Convert.ToUInt64(value, 2).ToString();
		}

		public static string BinToOct(string value)
		{
			return Convert.ToString(Convert.ToInt64(value, 2), 8);
		}

		public static string DecToHex(string value)
		{
			return Convert.ToUInt64(value, 10).ToString("X");
		}

		public static string DecToBin(string value)
		{
			var valByte = BitConverter.GetBytes(Convert.ToUInt64(value));
			var valBitArr = new BitArray(valByte);
			var bitString = "";

			for (int i = valBitArr.Length - 1; i >= 0; i--)
			{
				if (valBitArr[i])
				{
					bitString += "1";
				}
				else
				{
					bitString += "0";
				}
			}

			return bitString.TrimStart('0').PadLeft(1, '0');
		}

		public static string DecToOct(string value)
		{
			return Convert.ToString((long)Convert.ToUInt64(value, 10), 8);
		}

		public static string OctToHex(string value)
		{
			return Convert.ToUInt64(value, 8).ToString("X");
		}

		public static string OctToBin(string value)
		{
			var valByte = BitConverter.GetBytes(Convert.ToUInt64(value, 8));
			var valBitArr = new BitArray(valByte);
			var bitString = "";

			for (int i = valBitArr.Length - 1; i >= 0; i--)
			{
				if (valBitArr[i])
				{
					bitString += "1";
				}
				else
				{
					bitString += "0";
				}
			}

			return bitString.TrimStart('0').PadLeft(1, '0');
		}

		public static string OctToDec(string value)
		{
			return Convert.ToUInt64(value, 8).ToString();
		}

		private static byte[] HexStringToByteArray(string value)
		{
			byte[] data;
			int pad = 0;

			if (value.Length == 1)
			{
				data = new byte[1];
				data[0] = byte.Parse(value, NumberStyles.HexNumber, CultureInfo.InvariantCulture);
				return data;
			}

			if (value.Length % 2 != 0)
			{
				data = new byte[value.Length / 2 + 1];
				data[0] = byte.Parse(value[0].ToString(), NumberStyles.HexNumber, CultureInfo.InvariantCulture);
				value = value.Substring(1, value.Length - 1);
				pad = 1;
			}
			else
			{
				data = new byte[value.Length / 2];
			}

			for (int index = 0; index < data.Length - pad; index++)
			{
				string byteValue = value.Substring(index * 2, 2);
				data[index + pad] = byte.Parse(byteValue, NumberStyles.HexNumber, CultureInfo.InvariantCulture);
			}

			return data;
		}
	}
}
