using System;
using System.Collections;
using System.Text;

namespace BinViewer.Utils
{
    internal class CustomEncoding
    {
        public static string ToBitString(byte[] inArray, int bytesByLine, int byteGroupSize)
        {
            var outString = new StringBuilder();
            int lineCount = 0;
            int groupCount = 0;
            int currentLine = 1;

            var bitFile = new BitArray(inArray);

            outString.Append(currentLine + "\t");
            for (int i = 0; i < bitFile.Length; i += 8)
            {
                for (int j = i + 7; j >= i; j--)
                {
                    outString.Append(bitFile[j] ? "1" : "0");
                }

                CheckByteGroupSize(ref groupCount, ref byteGroupSize, outString);
                CheckBytesByLine(ref lineCount, ref bytesByLine, ref currentLine, outString);
            }

            return outString.ToString();
        }

        public static string ToByteString(byte[] inArray, int bytesByLine, int byteGroupSize)
        {
            var outString = new StringBuilder();
            int lineCount = 0;
            int groupCount = 0;
            int currentLine = 1;

            outString.Append(currentLine + "\t");
            foreach (var b in inArray)
            {
                outString.Append(b.ToString().PadLeft(3, '0'));

                CheckByteGroupSize(ref groupCount, ref byteGroupSize, outString);
                CheckBytesByLine(ref lineCount, ref bytesByLine, ref currentLine, outString);
            }

            return outString.ToString();
        }

        public static string ToOctalString(byte[] inArray, int bytesByLine, int byteGroupSize)
        {
            var outString = new StringBuilder();
            int lineCount = 0;
            int groupCount = 0;
            int currentLine = 1;

            outString.Append(currentLine + "\t");
            foreach (var b in inArray)
            {
                string sb8 = Convert.ToString(b, 8);
                outString.Append(sb8.PadLeft(3, '0'));

                CheckByteGroupSize(ref groupCount, ref byteGroupSize, outString);
                CheckBytesByLine(ref lineCount, ref bytesByLine, ref currentLine, outString);
            }

            return outString.ToString();
        }

        public static string ToDecimalString(byte[] inArray, int bytesByLine, int byteGroupSize)
        {
            var outString = new StringBuilder();
            int lineCount = 0;
            int groupCount = 0;
            int currentLine = 1;

            outString.Append(currentLine + "\t");
            foreach (var b in inArray)
            {
                string sb10 = Convert.ToString(b, 10);
                outString.Append(sb10.PadLeft(3, '0'));

                CheckByteGroupSize(ref groupCount, ref byteGroupSize, outString);
                CheckBytesByLine(ref lineCount, ref bytesByLine, ref currentLine, outString);
            }

            return outString.ToString();
        }

        public static string ToHexadecimalString(byte[] inArray, int bytesByLine, int byteGroupSize)
        {
            var outString = new StringBuilder();
            int lineCount = 0;
            int groupCount = 0;
            int currentLine = 1;

            outString.Append(currentLine + "\t");
            foreach (var b in inArray)
            {
                string sb16 = Convert.ToString(b, 16);
                outString.Append(sb16.PadLeft(2, '0'));

                CheckByteGroupSize(ref groupCount, ref byteGroupSize, outString);
                CheckBytesByLine(ref lineCount, ref bytesByLine, ref currentLine, outString);
            }

            return outString.ToString();
        }

        private static void CheckByteGroupSize(ref int groupCount, ref int byteGroupSize, StringBuilder outString)
        {
            groupCount++;
            if (groupCount >= byteGroupSize)
            {
                outString.Append(" ");
                groupCount = 0;
            }
        }

        private static void CheckBytesByLine(ref int lineCount, ref int bytesByLine, ref int currentLine, StringBuilder outString)
        {
            lineCount++;
            if (lineCount >= bytesByLine)
            {
                currentLine++;
                outString.AppendLine();
                outString.Append(currentLine);
                outString.Append("\t");
                lineCount = 0;
            }
        }
    }
}
