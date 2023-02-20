using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary2Decimal
{
	public static class Converters
	{
		//Converts binary expression to decimal.
		public static int ConvertToDecimal(string binary)
		{
			int result = 0;
			if (isBinary(binary))
			{
				try
				{

					for (int i = binary.Length - 1; i >= 0; i--)
					{
						result += (binary[i] - '0') * (int)Math.Pow(2, binary.Length - (i + 1));
					}
					return result;
				}
				catch (Exception)
				{

					throw;
				}
			}
			else
			{
				Console.WriteLine("Not a binary number.");
				return 0;
			}

		}

		//Converts decimal number to binary.
		public static string ConvertToBinary(string dec)
		{

			try
			{
				int i = Convert.ToInt32(dec);
				StringBuilder result = new StringBuilder();
				while (i != 1)
				{
					result.Insert(0, (i % 2).ToString());
					i -= i % 2;
					i /= 2;
				}
				result.Insert(0, "1");
				return result.ToString();
			}
			catch (Exception)
			{

				Console.WriteLine("Not a valid decimal number");
				return "";
			}
		}

		//Check if input if a valid binary number.
		public static bool isBinary(string binary)
		{
			foreach (char c in binary)
			{
				if (c != '0' && c != '1')
				{
					return false;
				}
			}
			return true;
		}
	}
}
