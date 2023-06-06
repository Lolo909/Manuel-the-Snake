using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Змията_игра_1._0;

namespace Manuel_the_Snake
{
    public partial class PauseForm : Form
    {
        public PauseForm()
        {
            InitializeComponent();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_to_main_menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainFom = new MainForm();
            mainFom.ShowDialog();
        }

        private void button_settings_Click(object sender, EventArgs e)
        {
            //FUTURE TODO: pause game
            settings settings = new settings();
            settings.ShowDialog();
        }
    }
}
