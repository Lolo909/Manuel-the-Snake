using AxWMPLib;
using Microsoft.PowerBI.Api.Models;
using System;
using System.Media;
using System.Reflection.Emit;
using System.Windows.Forms;
using WMPLib;
using static System.Windows.Forms.AxHost;


namespace Змията_игра_1._0
{
    public partial class settings : Form 
    {
              
        public static settings settingsInstance;
        public static int scale = 50;

        public settings()
        {            
            settingsInstance = this;                     
            InitializeComponent();          
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainFom = new MainForm();
            mainFom.ShowDialog();
        }

        public Boolean isItChanged = false;
        MainForm mainForm = MainForm.mainFormInstanse;
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            
            PercentageMusic.Text = scale + "%";
          

             scale = this.trackBar1.Value;
            
            
            mainForm.axWindowsMediaPlayer1.settings.volume = scale;
            isItChanged = true;
            mainForm.axWindowsMediaPlayer1.Ctlcontrols.stop();

            
            mainForm.axWindowsMediaPlayer1.URL = Application.StartupPath + "\\SoundsFiles\\MexicanMP3.wav";
            mainForm.axWindowsMediaPlayer1.settings.setMode("loop", true);
            mainForm.axWindowsMediaPlayer1.Visible = false;
            
            mainForm.axWindowsMediaPlayer1.settings.volume = settings.scale;

            mainForm.axWindowsMediaPlayer1.Ctlcontrols.play();
         


        }

        private void settings_Load(object sender, EventArgs e)
        {
            
            isItChanged = true;
            settingsInstance.trackBar1.Value = scale;
                    
            PercentageMusic.Text = scale + "%";
        }


        //TODO: make volume line for better visual and hearing expiriance in game.
        //https://www.youtube.com/@rahul345ful
    }
}
