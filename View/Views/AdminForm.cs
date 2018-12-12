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
        private string name;
        private string surname;
        private string login;
        private string password;

        public AdminForm()
        {
            InitializeComponent();
        }

        private void buttonAddWorker_Click(object sender, EventArgs e)
        {
            name = textBoxAddWorkerName.Text;
            surname = textBoxAddWorkerSurname.Text;
            login = textBoxAddWorkerLogin.Text;
            password = textBoxAddWorkerPassword.Text;

            if (WorkerPresenter.addWorker(name, surname, login, password) == false)
            {
                MessageBox.Show("Worker is no created!");
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
}
