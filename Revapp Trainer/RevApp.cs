using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        //string healthAddress = "ac_client.exe+0x109B74,F8";
        // multiple offsets bottom to top
        string healthAddress = "witcher3.exe+0x02AA4148,28,10,F0,18,150,150,0";
        public RevApp()
        {
            InitializeComponent();
        }

        private void RevApp_Load(object sender, EventArgs e)
        {
            mainPanel.BackgroundImage = SetImageOpacity(Properties.Resources.subheader_dark, 0.1F);
            int PID = memory.GetProcIdFromName("witcher3");
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



    }

}

