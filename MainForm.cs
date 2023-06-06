using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Text;
using System.Windows.Forms;
using WMPLib;
using static System.Windows.Forms.AxHost;

namespace Змията_игра_1._0
{
    public partial class MainForm : Form
    {
        public static MainForm mainFormInstanse;
        public int CheckBoxE;

       public  WindowsMediaPlayer Player = new WindowsMediaPlayer();
              

        public static settings settings = new settings();

       
        public MainForm()
        {
            settings = settings.settingsInstance;
            InitializeComponent();
            
        }

        
        private void Start_Button_Click(object sender, EventArgs e)
        {
            this.Hide();

            if (checkBox_easy.Checked)
            {
                CheckBoxE = 1;             
                EasyDifficultyForm easyDifficulty = new EasyDifficultyForm();
                easyDifficulty.ShowDialog();
                
            }
            else
            {
                CheckBoxE = 2;                
                HardDifficultyForm hardDifficulty = new HardDifficultyForm();
                hardDifficulty.ShowDialog();
            }
            
        }

        private void ControlsAndRulesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ControlsAndRules controlsAndRules = new ControlsAndRules();
            controlsAndRules.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {

            
            if (settings.isItChanged)
            {               
                axWindowsMediaPlayer1.Visible = false;
            }
            else
            {
                mainFormInstanse = this;
                
                axWindowsMediaPlayer1.Visible = false;
                axWindowsMediaPlayer1.URL = Application.StartupPath + "\\SoundsFiles\\MexicanMP3.wav";
                axWindowsMediaPlayer1.settings.volume = settings.scale;
                axWindowsMediaPlayer1.settings.setMode("loop", true);
                
            }
                     
            
               
        }

        private bool changed = false;
        private void timerForCheckBox_Tick(object sender, EventArgs e)
        {
            if(!checkBox_easy.Checked && !checkBox_hard.Checked)
            {
                if (lastCheked == 1 && dont)
                {
                     checkBox_hard.Checked = true;
                }
                else
                {
                    checkBox_easy.Checked = true;
                }
            }
           
        }
        int lastCheked = 1;
        bool dont = false;
        private void checkBox_easy_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (!changed)
                {
                    if (checkBox_hard.Checked)
                    {
                        changed = true;
                        checkBox_hard.Checked = false;
                    }
                }
                else
                {
                    lastCheked = 1;
                    dont = true;
                    changed = false;
                }
            }
        }

        private void checkBox_hard_CheckedChanged(object sender, EventArgs e)
        {
            if (!changed)
            {
                if (checkBox_easy.Checked)
                {
                    changed = true;
                    checkBox_easy.Checked = false;
                }
            }
            else
            {
                lastCheked = 2;
                changed = false;
            }
        }

        private void SeetingButton_Click(object sender, EventArgs e)
        {
            this.Hide();
             settings settings = new settings();
            settings.ShowDialog();
        }
    }
}
