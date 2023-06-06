using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Змията_игра_1._0
{
    public partial class BadEndingForm : Form
    {
        public BadEndingForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Yes_Click(object sender, EventArgs e)
        {
            this.Hide();
                        
            if (    MainForm.mainFormInstanse.CheckBoxE == 1)
            {
                EasyDifficultyForm easyDifficulty = new EasyDifficultyForm();
                easyDifficulty.Show();
            }
            else if (MainForm.mainFormInstanse.CheckBoxE == 2)
            {
                HardDifficultyForm hardDifficulty = new HardDifficultyForm();
                hardDifficulty.Show();
            }
        }

        private void No_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = MainForm.mainFormInstanse;
            mainForm.Show();           
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
            
            //if easy - hard
            //easy -> 1
            //hard -> 2
            if (MainForm.mainFormInstanse.CheckBoxE == 1)
            {
              score.Text = EasyDifficultyForm.easyDifficultyFormInstance.lbl.Text;
                label5.Text = EasyDifficultyForm.easyDifficultyFormInstance.lblTime.Text;
            }
            else if (MainForm.mainFormInstanse.CheckBoxE == 2)
            {
              score.Text = HardDifficultyForm.hardDifficultyFormInstance.lbl.Text;
                label5.Text = HardDifficultyForm.hardDifficultyFormInstance.lblTime.Text;
            }
            
        }
    }
}
