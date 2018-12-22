using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using View;
using Entities;
using Presenrers.Presenters;


namespace CarRental
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        List<string> categoriesNames = new List<string>();
        List<Image> images = new List<Image>();
        ushort cars_in_use = 0;
        Form extraForm;
        static Form adminForm = null;
        static Form workerForm = null;
        public AbstractUser activeUser = null;

        public MainForm()
        {
            InitializeComponent();
        }

     
        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void toolStripButtonLogin_Click(object sender, EventArgs e) //аутентификация
        {
           
            string login = toolStripTextBoxLogin.Text;
            string password = toolStripTextBoxPassword.Text;
            //MessageBox.Show(login + password);
            activeUser = AuthPresenter.authenticate(activeUser, login, password);
            if (activeUser == null)
            {
                MessageBox.Show("Login or password is invalid!");
                return;
            }
            
            if(activeUser.login == "admin")
            {
                adminAccess();
            }
            else
            {
                workerAccess();
            }
        }

        private static void adminAccess() //создание формы администратора
        {
            if (workerForm != null)
            {
                workerForm.Close();
                workerForm = null;
            }
            adminForm = new AdminForm();
            adminForm.Show();
        }
        private static void workerAccess() //создание формы работника
        {
            if (adminForm != null)
            {
                adminForm.Close();
                adminForm = null;
            }
            workerForm = new WorkerForm();
            workerForm.Show();
        }

        /* private void buttonDeleteCategory_Click(object sender, EventArgs e)
         {
             string categoryToDelete = listBoxDeleteCategories.SelectedItem.ToString();
             listBoxCategories.Items.Remove(categoryToDelete);
             listBoxDeleteCategories.Items.Remove(categoryToDelete);
             MessageBox.Show($"{categoryToDelete} category is deleted");
         }*/


        private void buttonGoToCategory_Click(object sender, EventArgs e)
        {
            if (listBoxCategories.SelectedItem != null)
            {
                panelCategories.Visible = panelCategories.Enabled = true;

            } else
            {
                MessageBox.Show("Nothing is selected");
            }

        }


        private void button5_Click(object sender, EventArgs e)
        {
          //  buttonReturn.Enabled = true;
        }

        private void buttonLease_Click(object sender, EventArgs e)
        {
            cars_in_use++;
            toolStripStatusLabelCarsInUse.Text = cars_in_use.ToString();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            if (cars_in_use != 0)
            {
                cars_in_use--;
                toolStripStatusLabelCarsInUse.Text = cars_in_use.ToString();

            }
        }

        private void buttonViewClient_Click(object sender, EventArgs e)
        {
            extraForm = new Form();
            extraForm.StartPosition = FormStartPosition.CenterScreen;
            extraForm.Show();
        }

        private void toolStripButtonContacts_Click(object sender, EventArgs e)
        {
            extraForm = new Form();

            extraForm.StartPosition = FormStartPosition.CenterScreen;
            extraForm.Show();
        }

        private void toolStripButtonHelp_Click(object sender, EventArgs e)
        {
            extraForm = new Form();
            extraForm.StartPosition = FormStartPosition.CenterScreen;
            extraForm.Show();
        }
    }
}
