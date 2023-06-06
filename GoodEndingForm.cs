using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Змията_игра_1._0
{
    public partial class GoodEndingForm : Form
    {
        public GoodEndingForm()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = MainForm.mainFormInstanse;
            mainForm.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            if (MainForm.mainFormInstanse.CheckBoxE == 1)
            {
               
                label5.Text = EasyDifficultyForm.easyDifficultyFormInstance.lblTime.Text;
            }
            else if (MainForm.mainFormInstanse.CheckBoxE == 2)
            {
               
                label5.Text = HardDifficultyForm.hardDifficultyFormInstance.lblTime.Text;
            }
        }
    }
}
