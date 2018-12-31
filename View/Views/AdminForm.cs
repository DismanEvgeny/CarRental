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
using Services;


namespace View
{
    public partial class AdminForm : Form
    {

        // private static int worker_counter = 2;
        private WorkerPresenter workerPresenter;
        private CategoriesPresenter categoryPresenter;
        private int workerCounter;
        private CarsPresenter carsPresenter;
        //List<Category> categories;

        public AdminForm()
        {

            workerPresenter = new WorkerPresenter();
            categoryPresenter = new CategoriesPresenter();
            carsPresenter = new CarsPresenter();
            
            InitializeComponent();

            workerCounter = int.Parse(workerPresenter.getAmountOfUsers());
            fillWorkerListBox(workerCounter);
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

        /*public void showCategoriesToDelete()
        {
            foreach (Category cat in MainForm.categories)
            {
                listBoxDeleteCategories.Items.Add(cat.getName());
            }
        }*/

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "carRentalDBDataSet.Cars". При необходимости она может быть перемещена или удалена.
            toolStripLabelAdminName.Text = $"Welcome, {AuthPresenter.activeUser.name} {AuthPresenter.activeUser.surname}";
            MainForm.categories = categoryPresenter.getCategories();
            //showCategoriesToDelete();
            foreach (Category cat in MainForm.categories)
            {
                listBoxDeleteCategories.Items.Add(cat.getName());
                comboBoxAddCarcategory.Items.Add(cat.getName());
            }
            comboBoxAddCarcategory.SelectedIndex = 0;

            MainForm.cars = carsPresenter.getCars();
            foreach(Car car in MainForm.cars)
            {
               comboBoxDeleteCar.Items.Add($"{car.ID} {car.brand} {car.model} {car.yearOfProduction}");
            }
            comboBoxDeleteCar.SelectedIndex = 0;

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
            string ID = itemSelected.Substring(0, 1);
            workerPresenter.deleteWorker(ID);
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);

            MessageBox.Show("Worker is deleted!");
        }

        private void textBoxAddCategoryName_TextChanged(object sender, EventArgs e) {}

        private void textBoxAddCategoryTarif_TextChanged(object sender, EventArgs e) {}

        private void textBoxAddCategoryFine_TextChanged(object sender, EventArgs e) {}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            string name = textBoxAddCategoryName.Text;
            string tarif = textBoxAddCategoryTarif.Text;
            string fine = textBoxAddCategoryFine.Text;
            string ID = textBox1.Text;

            if (textBoxAddCategoryName.Text == "" || textBoxAddCategoryTarif.Text == "" || textBoxAddCategoryFine.Text == ""
                || textBox1.Text == "")
            {
                MessageBox.Show("Fill all fields!");
            }
            else
            {
                if (categoryPresenter.addCategory(name, tarif, fine, ID) == false)
                {
                    MessageBox.Show("Category is not created! Invalid input format!");
                }
                else
                {
                    MessageBox.Show("Category is created!");
                    listBoxDeleteCategories.Items.Add(name);
                    textBoxAddCategoryName.Clear();
                    textBoxAddCategoryTarif.Clear();
                    textBoxAddCategoryFine.Clear();
                    textBox1.Clear();
                }
            }
        }

        private void buttonAddCarLoadImage_Click(object sender, EventArgs e)
        {
            if(openFileDialogAddCarLoadImage.ShowDialog() == DialogResult.Cancel)
                return;
            textBoxAddCarImage.Text = openFileDialogAddCarLoadImage.FileName;

        }

        private void buttonAddCar_Click(object sender, EventArgs e)
        {
            string brand = textBoxAddCarBrand.Text;
            string model = textBoxAddCarModel.Text;
            string category = comboBoxAddCarcategory.Text;
            string fuel = comboBoxAddCarFuelType.Text;
            string year = numericUpDownAddCarYear.Value.ToString();
            string hasAutomaticTransmition = radioButtonAddCarAuthmaticTransmition.Checked.ToString();
            string imageDirectory = textBoxAddCarImage.Text;
            category = categoryPresenter.getCategoryId(category);

            int id = carsPresenter.addCar(new string[] { brand, model, category, fuel, year, hasAutomaticTransmition, imageDirectory });
            if (id >= 0 )
            {
                Car newCar = new Car(id, brand, model, category, (FuelType)Enum.Parse(typeof(FuelType), fuel), short.Parse(year), (hasAutomaticTransmition=="True"|| hasAutomaticTransmition=="1"),
                    Image.FromFile(imageDirectory), false);

                MainForm.cars.Add(newCar);
                comboBoxDeleteCar.Items.Add($"{newCar.ID} {newCar.brand} {newCar.model} {newCar.yearOfProduction}");
                MessageBox.Show("Car is created!");
                textBoxAddCarBrand.Clear();
                textBoxAddCarModel.Clear();
                textBoxAddCarImage.Clear();
            } else
            {
                MessageBox.Show("Error");
            }
        }

        private void buttonDeleteCar_Click(object sender, EventArgs e)
        {
            string carString = comboBoxDeleteCar.Text;
            string carId = carString.Split(' ')[0];
            Console.WriteLine("Car to delete Id: "+carId);

            carsPresenter.deleteCar(carId);

            comboBoxDeleteCar.Items.RemoveAt(comboBoxDeleteCar.SelectedIndex);
            comboBoxDeleteCar.SelectedIndex = 0;
            MessageBox.Show("Car is deleted!");

        }

        private void buttonDeleteCategory_Click(object sender, EventArgs e)
        {
            string categoryName = listBoxDeleteCategories.SelectedItem.ToString();
            categoryPresenter.deleteCategory(categoryName);
            listBoxDeleteCategories.Items.RemoveAt(listBoxDeleteCategories.SelectedIndex);
            comboBoxAddCarcategory.Items.Remove(categoryName);
        }
    }
}
