using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Revapp_Trainer
{
    public partial class RevApp : Form
    {


        Cheats cheats = new Cheats();
        KeyboardHook kh = new KeyboardHook();
        ResourceHelper rh = new ResourceHelper();
        UI ui = new UI();

       
 
        public RevApp()
        {
            InitializeComponent();
        }

        private void RevApp_Shown(object sender, EventArgs e)
        {
            // Setting trainer BG
            mainPanel.BackgroundImage = ui.SetImageOpacity(Properties.Resources.subheader_dark, 0.1F);

            // Running bgworker
            slaveWorker.RunWorkerAsync();

            // Adding keys to be hooked
            kh.HookedKeys.Add(Keys.NumPad1);

            // Creating keyhook event
            kh.KeyDown += new KeyEventHandler(kh_KeyDown);
        }

      

        private void kh_KeyDown(object sender, KeyEventArgs e)
        {

            // Switch case to detect which key is being pressed
            switch (e.KeyCode)
            {
                // If NumPad1 key is pressed, check/uncheck the switch for ammo
                case Keys.NumPad1:
                    checkAmmo.Checked = !checkAmmo.Checked;
                break;
            }
        }

        private void checkAmmo_CheckedChanged(object sender, EventArgs e)
        {
            // If ammo switch is checked do the following
            if (checkAmmo.Checked)
            {
                cheats.enableInfiniteAmmo();
            }
            else
            // If ammo switch is unchecked, do the following
                if (!checkAmmo.Checked)
            {
                cheats.disableInfinteAmmo();
            }
        }

        private void slaveWorker_DoWork(object sender, DoWorkEventArgs e)
        {
           
            // If game process is running
                if (cheats.isProcessAlive())
                {
              
                // Freeze value
                }
                else
                {
               
                }

        }

        private void slaveWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            slaveWorker.RunWorkerAsync();
        }
    }

}



