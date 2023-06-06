using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Змията_игра_1._0
{
    public partial class ControlsAndRules : Form
    {
        public static settings settings = new settings();
        public ControlsAndRules()
        {
            settings = settings.settingsInstance;
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
        }

        private void ControlsAndRules_Load(object sender, EventArgs e)
        {
            settings.isItChanged = true;
        }
    }
}
