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

        public MainForm()
        {
            InitializeComponent();
        }

       /* private void button1_Click(object sender, EventArgs e)
        {
            //string text = textBox1.Text;
            MessageBox.Show($"{text} category is added");
            //listBoxDeleteCategories.Items.Add(text);
            listBoxCategories.Items.Add(text);



        }*/

        private void MainForm_Load(object sender, EventArgs e)
        {
            /*Worker test1 = new Worker("A", "B", "C", "D");
            Worker test2 = new Worker("A", "B", "C", "D");
            toolStripLabelName.Text = $"1: {test1.ID}   2: {test2.ID}";*/                   //лишь проверка
        }

        private void toolStripButtonLogin_Click(object sender, EventArgs e)
        {
            string login = toolStripTextBoxLogin.Text;
            string password = toolStripTextBoxPassword.Text;
            //MessageBox.Show(login + password);
            if (!AuthPresenter.authenticate(login, password))
                MessageBox.Show("Login or password is invalid!");
            else
                adminAccess();
        }

        private static void adminAccess()
        {
            Form adminForm = new AdminForm();
        }

        /* private void buttonDeleteCategory_Click(object sender, EventArgs e)
         {
             string categoryToDelete = listBoxDeleteCategories.SelectedItem.ToString();
             listBoxCategories.Items.Remove(categoryToDelete);
             listBoxDeleteCategories.Items.Remove(categoryToDelete);
             MessageBox.Show($"{categoryToDelete} category is deleted");
         }*/

        private void button1_Click_1(object sender, EventArgs e)
        {
            toolStripLabelName.Text = "Administrator";
            Form adminForm = new AdminForm();
            adminForm.StartPosition = FormStartPosition.CenterScreen;
            //adminForm.Enabled = adminForm.Visible = true;
            adminForm.Show();
        }

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

        private void button4_Click(object sender, EventArgs e)
        {
            toolStripLabelName.Text = "Worker";
           // panelAdmin.Enabled = panelAdmin.Visible = false;
            Form workerForm = new WorkerForm();
            workerForm.StartPosition = FormStartPosition.CenterScreen;

            workerForm.Visible = true;
            workerForm.Enabled = true;
            //  panelWorker.Enabled = panelWorker.Visible = true;

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
