using System;
using System.Collections;

namespace BinViewer.Utils
{
    internal class CustomEncoding
    {
        public static string ToBitString(byte[] inArray, int bytesByLine, int byteGroupSize)
        {
            string outString = "";
            int lineCount = 0;
            int groupCount = 0;
            int currentLine = 1;

            var bitFile = new BitArray(inArray);

            outString += currentLine + "\t";
            for (int i = 0; i < bitFile.Length; i += 8)
            {
                for (int j = i + 7; j >= i; j--)
                {
                    outString += bitFile[j] ? "1" : "0";
                }

                CheckByteGroupSize(ref groupCount, ref byteGroupSize, ref outString);
                CheckBytesByLine(ref lineCount, ref bytesByLine, ref currentLine, ref outString);
            }

            return outString;
        }

        public static string ToByteString(byte[] inArray, int bytesByLine, int byteGroupSize)
        {
            string outString = "";
            int lineCount = 0;
            int groupCount = 0;
            int currentLine = 1;

            outString += currentLine + "\t";
            foreach (var b in inArray)
            {
                outString += b.ToString().PadLeft(3, '0');

                CheckByteGroupSize(ref groupCount, ref byteGroupSize, ref outString);
                CheckBytesByLine(ref lineCount, ref bytesByLine, ref currentLine, ref outString);
            }

            return outString;
        }

        public static string ToOctalString(byte[] inArray, int bytesByLine, int byteGroupSize)
        {
            string outString = "";
            int lineCount = 0;
            int groupCount = 0;
            int currentLine = 1;

            outString += currentLine + "\t";
            foreach (var b in inArray)
            {
                string sb8 = Convert.ToString(b, 8);
                outString += sb8.PadLeft(3, '0');

                CheckByteGroupSize(ref groupCount, ref byteGroupSize, ref outString);
                CheckBytesByLine(ref lineCount, ref bytesByLine, ref currentLine, ref outString);
            }

            return outString;
        }

        public static string ToDecimalString(byte[] inArray, int bytesByLine, int byteGroupSize)
        {
            string outString = "";
            int lineCount = 0;
            int groupCount = 0;
            int currentLine = 1;

            outString += currentLine + "\t";
            foreach (var b in inArray)
            {
                string sb10 = Convert.ToString(b, 10);
                outString += sb10.PadLeft(3, '0');

                CheckByteGroupSize(ref groupCount, ref byteGroupSize, ref outString);
                CheckBytesByLine(ref lineCount, ref bytesByLine, ref currentLine, ref outString);
            }

            return outString;
        }

        public static string ToHexadecimalString(byte[] inArray, int bytesByLine, int byteGroupSize)
        {
            string outString = "";
            int lineCount = 0;
            int groupCount = 0;
            int currentLine = 1;

            outString += currentLine + "\t";
            foreach (var b in inArray)
            {
                string sb16 = Convert.ToString(b, 16);
                outString += sb16.PadLeft(2, '0');

                CheckByteGroupSize(ref groupCount, ref byteGroupSize, ref outString);
                CheckBytesByLine(ref lineCount, ref bytesByLine, ref currentLine, ref outString);
            }

            return outString;
        }

        private static void CheckByteGroupSize(ref int groupCount, ref int byteGroupSize, ref string outString)
        {
            groupCount++;
            if (groupCount >= byteGroupSize)
            {
                outString += " ";
                groupCount = 0;
            }
        }

        private static void CheckBytesByLine(ref int lineCount, ref int bytesByLine, ref int currentLine, ref string outString)
        {
            lineCount++;
            if (lineCount >= bytesByLine)
            {
                currentLine++;
                outString += "\n" + currentLine + "\t";
                lineCount = 0;
            }
        }
    }
}
