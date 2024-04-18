namespace NotificationApi.Security
{
    public class Encryption
    {
        static byte EncodeII(byte p_ucOne, byte p_ucTwo, byte p_ucThree)
        {
            return (byte)(p_ucTwo ^ (p_ucOne | ~p_ucThree));
        }

        static byte EncodeFF(byte p_ucOne, byte p_ucTwo, byte p_ucThree)
        {
            return (byte)((p_ucOne & p_ucThree) | (p_ucTwo & ~p_ucThree));
        }

        static byte EncodeGG(byte p_ucOne, byte p_ucTwo, byte p_ucThree)
        {
            return (byte)((p_ucOne & p_ucThree) | (p_ucTwo & ~p_ucThree));
        }

        public static string Encrypt(string p_szBuffer, int p_iPasswordLength)
        {
            byte[] l_szBufferSpace = new byte[p_iPasswordLength];
            byte[] l_szBufferFinal = new byte[p_iPasswordLength];
            string l_cBufferPtr = p_szBuffer;
            string m_szBufferKey = null;

            int l_iLength = l_cBufferPtr.Length;

            for (int l_iCount = 0; l_iCount < p_iPasswordLength; l_iCount++)
            {
                if (l_iCount < l_iLength)
                {
                    char[] passChar = l_cBufferPtr.ToCharArray();
                    l_szBufferSpace[l_iCount] = Convert.ToByte(passChar[l_iCount]);
                }
                else
                {
                    l_szBufferSpace[l_iCount] = Convert.ToByte(' ');
                }
            }

            int l_iLoop = 0;
            if (p_iPasswordLength >= 3)
            {
                for (l_iLoop = p_iPasswordLength - 1; l_iLoop >= 2; l_iLoop--)
                {
                    byte l_ucResult1 = EncodeGG(l_szBufferSpace[l_iLoop], l_szBufferSpace[l_iLoop - 1], l_szBufferSpace[l_iLoop - 2]);
                    byte l_ucResult2 = EncodeII(l_szBufferSpace[l_iLoop], l_szBufferSpace[l_iLoop - 1], l_szBufferSpace[l_iLoop - 2]);
                    l_szBufferSpace[l_iLoop] = (byte)((l_ucResult2 << 2) | l_ucResult1);
                }

                for (l_iLoop = 0; l_iLoop < p_iPasswordLength - 3; l_iLoop++)
                {
                    byte l_ucResult1 = EncodeFF(l_szBufferSpace[l_iLoop], l_szBufferSpace[l_iLoop + 1], l_szBufferSpace[l_iLoop + 2]);
                    l_szBufferSpace[l_iLoop] = l_ucResult1;
                }
            }

            byte l_ucResultP0 = 0;
            for (l_iLoop = 0; l_iLoop < p_iPasswordLength; l_iLoop++)
            {
                l_szBufferFinal[l_iLoop] = l_szBufferSpace[l_iLoop];
            }

            long l_lShift = 0;
            if (l_ucResultP0 < 0)
            {
                l_lShift = 256 + l_ucResultP0;
            }
            else
            {
                l_lShift = l_ucResultP0;
            }

            byte l_byteA = Convert.ToByte('A');
            byte l_byteZ = Convert.ToByte('Z');

            for (l_iLoop = 0; l_iLoop < p_iPasswordLength; l_iLoop++)
            {
                long l_charBF = 0;
                if (l_szBufferFinal[l_iLoop] < 0)
                {
                    l_charBF = (256 + l_szBufferFinal[l_iLoop]);
                }
                else
                {
                    l_charBF = l_szBufferFinal[l_iLoop];
                }

                if (l_charBF < l_byteA)
                {
                    long l_lDiff = (l_lShift + (l_byteA - l_charBF)) % 26;
                    l_charBF = l_byteA + l_lDiff;
                    l_lShift = l_lDiff;
                }

                if (l_charBF > l_byteZ)
                {
                    long l_lDiff = (l_lShift + (l_charBF - l_byteZ)) % 26;
                    l_charBF = l_byteZ - l_lDiff;
                    l_lShift = l_lDiff;
                }
                l_szBufferFinal[l_iLoop] = (byte)l_charBF;
            }

            System.Text.ASCIIEncoding AE = new System.Text.ASCIIEncoding();
            byte[] ByteArray = l_szBufferFinal;
            char[] CharArray = AE.GetChars(ByteArray);
            m_szBufferKey = new string(CharArray);

            return m_szBufferKey;
        }
    }
}
