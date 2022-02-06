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
        RevappHelper revappHelper = new RevappHelper();
        KeyboardHook kh = new KeyboardHook();
 
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

            kh.HookedKeys.Add(Keys.NumPad1);
            kh.KeyDown += new KeyEventHandler(kh_KeyDown);
        }

        private void kh_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad1:
                    checkAmmo.Checked = !checkAmmo.Checked;
                break;
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

     



        private void checkAmmo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkAmmo.Checked)
            {


                byte[] freezebytesX = { 0xFF, 0x0E, 0x57, 0x8B, 0x7C, 0x24, 0x14 };
                UIntPtr codecavebase = memory.CreateCodeCave("base+637E9", freezebytesX, 7, 1000);
                UIntPtr codecaveAllocAddress = UIntPtr.Add(codecavebase, freezebytesX.Length);
                int newint = (int)codecaveAllocAddress - 7;
                //Console.WriteLine("Read Allocated Memory: 0x" + newint.ToString("X") + "\r\n" + codecaveAllocAddress);

                byte[] ammo = { 0xC7, 0x06, 0x14, 0x00, 0x00, 0x00 };
                memory.WriteMemory(newint.ToString("X"), "bytes", "0xC7 0x06 0x14 0x00 0x00 0x00");
                memory.WriteMemory(revappHelper.sanitizeAddressLastChar(newint.ToString("X"), "6"), "bytes", "0x57");
                memory.WriteMemory(revappHelper.sanitizeAddressLastChar(newint.ToString("X"), "7"), "bytes", "0x8B 0x7C 0x24 0x14");

         

              
                ulong from = revappHelper.stringToUlong(revappHelper.sanitizeAddressLastChar(newint.ToString("X"), "B"));
                ulong to = revappHelper.stringToUlong("0x004637F4");
               memory.WriteMemory(revappHelper.sanitizeAddressLastChar(newint.ToString("X"), "B"), "bytes", revappHelper.jumpAddress(to, from, false));
           
      

            }
            else
                if (!checkAmmo.Checked)
            {
                memory.WriteMemory("base+637E9", "bytes", "FF 0E 57 8B 7C 24 14");
            }
        }
    }

}



