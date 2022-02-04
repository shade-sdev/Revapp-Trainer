using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;


namespace Revapp_Trainer
{
    public partial class RevApp : Form
    {


        Mem memory = new Mem();
 
        public RevApp()
        {
            InitializeComponent();
        }

        private void RevApp_Load(object sender, EventArgs e)
        {
            mainPanel.BackgroundImage = SetImageOpacity(Properties.Resources.subheader_dark, 0.1F);
            int PID = memory.GetProcIdFromName("ac_client");
            if(PID > 0)
            {
                memory.OpenProcess(PID);
            
            }
        }

        public static Image SetImageOpacity(Image image, float opacity)
        {
            Bitmap bmp = new Bitmap(image.Width, image.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                ColorMatrix matrix = new ColorMatrix();
                matrix.Matrix33 = opacity;
                ImageAttributes attributes = new ImageAttributes();
                attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default,
                                                  ColorAdjustType.Bitmap);
                g.DrawImage(image, new Rectangle(0, 0, bmp.Width, bmp.Height),
                                   0, 0, image.Width, image.Height,
                                   GraphicsUnit.Pixel, attributes);
            }
            return bmp;
        }

        public static byte[] Jmp(ulong jmpto, ulong jmpfrom, bool nop)
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

            return hex;

        }

        static string ProcessString(string input)
        {
            StringBuilder buffer = new StringBuilder(input.Length * 3 / 2);
            for (int i = 0; i < input.Length; i++)
            {
                if ((i > 0) & (i % 2 == 0))
                    buffer.Append(" ");
                buffer.Append(input[i]);
            }
            return buffer.ToString();
        }



        private void checkAmmo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkAmmo.Checked)
            {


                byte[] freezebytesX = { 0xFF, 0x0E, 0x57, 0x8B, 0x7C, 0x24, 0x14 };
                UIntPtr codecavebase = memory.CreateCodeCave("base+637E9", freezebytesX, 7, 1000);
                UIntPtr codecaveAllocAddress = UIntPtr.Add(codecavebase, freezebytesX.Length);
                int newint = (int)codecaveAllocAddress - 7;
                Console.WriteLine("Read Allocated Memory: 0x" + newint.ToString("X") + "\r\n" + codecaveAllocAddress);

                byte[] ammo = { 0xC7, 0x06, 0x14, 0x00, 0x00, 0x00 };
                memory.WriteMemory(newint.ToString("X"), "bytes", "0xC7 0x06 0x14 0x00 0x00 0x00");
                memory.WriteMemory(newint.ToString("X").Remove(newint.ToString("X").Length - 1, 1) + "6", "bytes", "0x57");
                memory.WriteMemory(newint.ToString("X").Remove(newint.ToString("X").Length - 1, 1) + "7", "bytes", "0x8B 0x7C 0x24 0x14");

         

              
                ulong from = Convert.ToUInt32(newint.ToString("X").Remove(newint.ToString("X").Length - 1, 1) + "B", 16);
                ulong to = Convert.ToUInt32("0x004637F4", 16);
               memory.WriteMemory(newint.ToString("X").Remove(newint.ToString("X").Length - 1, 1) + "B", "bytes", ProcessString(BitConverter.ToString(Jmp(to, from, false)).Replace("-", string.Empty).ToUpper()));

      

            }
            else
                if (!checkAmmo.Checked)
            {
                memory.WriteMemory("base+637E9", "bytes", "FF 0E 57 8B 7C 24 14");
            }
        }
    }

}



