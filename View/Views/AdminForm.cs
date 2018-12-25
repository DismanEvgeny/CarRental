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
using Entities;
using CarRental;


namespace View
{
    public partial class AdminForm : Form
    {

        // private static int worker_counter = 2;
        private WorkerPresenter workerPresenter;
        private int workerCounter;
        //List<Category> categories;

        public AdminForm()
        {

            workerPresenter = new WorkerPresenter();

            InitializeComponent();

            workerCounter = int.Parse(workerPresenter.getAmountOfUsers());
            fillWorkerListBox(workerCounter);
           // MessageBox.Show(workerCounter.ToString());

            //listBox1.Items.Insert(0, name + "       " + surname + "       " + userID);
        }

        private void buttonAddWorker_Click(object sender, EventArgs e)
        {
            string name = textBoxAddWorkerName.Text;
            string surname = textBoxAddWorkerSurname.Text;
            string login = textBoxAddWorkerLogin.Text;
            string password = textBoxAddWorkerPassword.Text;
            int newID;
            bool isAdmin = checkBoxIsAdmin.Checked; // нужно добавить на форму штуку



            if (textBoxAddWorkerName.Text == "" || textBoxAddWorkerSurname.Text == "" || textBoxAddWorkerLogin.Text == "" 
                || textBoxAddWorkerPassword.Text == "")
            {
                MessageBox.Show("Fill all fields!");
            }
            else
            {
                if (workerPresenter.addWorker(name, surname, login, password, isAdmin) == false)
                {
                    MessageBox.Show("Worker is not created!");
                }
                else
                {
                    MessageBox.Show("Worker is created!");
                    workerCounter++;
                    newID = int.Parse(workerPresenter.getAmountOfUsers()) - 1;
                    listBox1.Items.Insert(workerCounter-1, newID + "      " + textBoxAddWorkerName.Text + 
                        "      " + textBoxAddWorkerSurname.Text);
                    textBoxAddWorkerName.Clear();
                    textBoxAddWorkerSurname.Clear();
                    textBoxAddWorkerLogin.Clear();
                    textBoxAddWorkerPassword.Clear();
                }
            }

            //listBox1.Items.Insert(0, name + " " + surname);
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
            MainForm.categories = CategoriesPresenter.getCategories();
            foreach (Category cat in MainForm.categories)
            {
                listBoxDeleteCategories.Items.Add(cat.name);
            }
            comboBoxAddCarcategory.SelectedIndex = 0;

            comboBoxAddCarFuelType.DataSource = Enum.GetNames(typeof(FuelType));
            comboBoxAddCarFuelType.SelectedItem = FuelType.Petrol;

            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {  }

        public void fillWorkerListBox(int workerCounter)
        {
            string[,] users = new string[workerCounter,3];

            users = workerPresenter.getAllWorkers(workerCounter);

            for (int i = 0; i < workerCounter; i++)
                listBox1.Items.Insert(i, users[i, 0] + "      " + users[i, 1] + "      " + users[i, 2]);
            
        }

        private void buttonRemoveWorker_Click(object sender, EventArgs e)
        {
            string itemSelected = listBox1.GetItemText(listBox1.SelectedItem);
           // int pos = listBox1.SelectedIndex;          
            string ID = itemSelected.Substring(0, 1);
            workerPresenter.deleteWorker(ID);
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);

            MessageBox.Show("Worker is deleted!");
        }

        /*private void label15_Click(object sender, EventArgs e)
        {

        }*/

        private void textBoxAddCategoryName_TextChanged(object sender, EventArgs e) {}

        private void textBoxAddCategoryTarif_TextChanged(object sender, EventArgs e) {}

        private void textBoxAddCategoryFine_TextChanged(object sender, EventArgs e) {}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {

        }

        /*private void label15_Click(object sender, EventArgs e)
        {

        }*/
    }
}
