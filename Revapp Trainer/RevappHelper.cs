using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revapp_Trainer
{
    class RevappHelper
    {

      

        public string jumpAddress(ulong jmpto, ulong jmpfrom, bool nop)
        {
            var test = jmpto - jmpfrom;
            var test2 = test - 5;
            var dump = test2.ToString("x"); //Get original bytes

            if (dump.Length == 7) //Make sure we have 4 bytes
                dump = "0" + dump;

            dump += "E9"; //Add JMP
            if (nop)
                dump = "90" + dump; //Add NOP if needed

            var hex = new byte[dump.Length / 2];
            for (var i = 0; i < hex.Length; i++)
                hex[i] = Convert.ToByte(dump.Substring(i * 2, 2), 16); //Set each byte to 2 chars

            Array.Reverse(hex); //Reverse byte array for use with Write()

            string hexstring = BitConverter.ToString(hex).Replace("-", string.Empty).ToUpper();

            StringBuilder buffer = new StringBuilder(hexstring.Length * 3 / 2);
            for (int i = 0; i < hexstring.Length; i++)
            {
                if ((i > 0) & (i % 2 == 0))
                    buffer.Append(" ");
                buffer.Append(hexstring[i]);
            }
            return buffer.ToString();

        }


        public ulong stringToUlong(string input, string lastChar = null)
        {
            if (lastChar == null)
            {
                return Convert.ToUInt32(input, 16);
            }
            else
            if (lastChar != null)
         
            {
                return Convert.ToUInt32(input.Remove(input.Length - 1, 1) + lastChar, 16);
            }

            return Convert.ToUInt32(input, 16);

        }

        public string sanitizeAddressLastChar(string address, string lastChar)
        {
            return address.Remove(address.Length - 1, 1) + lastChar;
        }


    }
}
