using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presenrers.Presenters;


namespace View
{
    public partial class AdminForm : Form
    {

        public AdminForm()
        {
            InitializeComponent();
        }

        private void buttonAddWorker_Click(object sender, EventArgs e)
        {
            string name = textBoxAddWorkerName.Text;
            string surname = textBoxAddWorkerSurname.Text;
            string login = textBoxAddWorkerLogin.Text;
            string password = textBoxAddWorkerPassword.Text;
            bool isAdmin = checkBoxIsAdmin.Checked; // нужно добавить на форму штуку

            if (textBoxAddWorkerName.Text == "" || textBoxAddWorkerSurname.Text == "" || textBoxAddWorkerLogin.Text == "" 
                || textBoxAddWorkerPassword.Text == "")
            {
                MessageBox.Show("Fill all fields!");
            }
            else
            {
                if (WorkerPresenter.addWorker(name, surname, login, password, isAdmin) == false)
                {
                    MessageBox.Show("Worker is not created!");
                }
                else
                {
                    MessageBox.Show("Worker is created!");
                    textBoxAddWorkerName.Clear();
                    textBoxAddWorkerSurname.Clear();
                    textBoxAddWorkerLogin.Clear();
                    textBoxAddWorkerPassword.Clear();
                }
            }
 
               

        }

        private void radioButtonAddCarAuthmaticTransmition_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonAddCarManualTransmition_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            toolStripLabelAdminName.Text = $"Welcome, {AuthPresenter.activeUser.name} {AuthPresenter.activeUser.surname}";
        }

       /* private void checkBoxIsAdmin_CheckedChanged(object sender, EventArgs e)
        {

        }*/
    }
}
