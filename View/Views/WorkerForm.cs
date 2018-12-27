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
    public partial class WorkerForm : Form
    {
        WorkerPresenter workerPresenter;
        ClientPresenter clientPresenter;
        CategoriesPresenter categoriesPresenter;
        CarsPresenter carsPresenter;
        ContractPresenter contractPresenter;
        private bool loaded = false;
        uint carsInUse = 0;

        Category categoryLease;
        Car carLease;
        Client clientLease;

        public WorkerForm()
        {
            workerPresenter = new WorkerPresenter();
            clientPresenter = new ClientPresenter();
            categoriesPresenter = new CategoriesPresenter();
            carsPresenter = new CarsPresenter();
            contractPresenter = new ContractPresenter();

            InitializeComponent();
        }

        private void WorkerForm_Load(object sender, EventArgs e)
        {
            toolStripLabelWorkerName.Text = $"Welcome, {AuthPresenter.activeUser.name} {AuthPresenter.activeUser.surname}";

            foreach(Client cl in MainForm.clients)
            {
                comboBoxLeaseCarClients.Items.Add($"{cl.ID} {cl.name} {cl.surname}");
            }
            comboBoxLeaseCarClients.SelectedIndex = 0;

            foreach (Category cat in MainForm.categories)
            {
                comboBoxLeaseCarCategory.Items.Add($"{cat.getID()} {cat.getName()}");
            }
            comboBoxLeaseCarCategory.SelectedIndex = 0;

            foreach (Car car in MainForm.carsNotOccupied)
            {
                comboBoxLeaseCarCar.Items.Add($"{car.ID} {car.brand} {car.model} {car.yearOfProduction}");
            }
            comboBoxLeaseCarCar.SelectedIndex = 0;

            foreach(Car car in MainForm.carsOccupied)
            {
                comboBoxReturnCar.Items.Add($"{car.ID} {car.brand} {car.model} {car.yearOfProduction}");
            }
            if (comboBoxReturnCar.Items.Count != 0)
            {
                comboBoxReturnCar.SelectedIndex = 0;
            }

            carsInUse = carsPresenter.carsInUse();
            toolStripStatusLabelCarsInUse.Text = carsInUse.ToString();
        }

        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            string name = textBoxAddClientName.Text;
            string surname = textBoxAddClientSurname.Text;
            bool sex = radioButtonAddClientMale.Checked;
            string telephoneNumber = textBoxAddClientNumber.Text.Remove(0,1);
            DateTime date = DateTime.Now;

            Client client = clientPresenter.addClient(new string[] { "", name, surname, sex.ToString(), date.ToString("d"), "True", telephoneNumber });

            if (client == null)
            {
                MessageBox.Show("Error");
            }
            else
            {
                MainForm.clients.Add(client);
                comboBoxLeaseCarClients.Items.Add($"{client.ID} {client.name} {client.surname}");
                MessageBox.Show("Client is added!");
            }

        }

        private void buttonLeaseCarCalculate_Click(object sender, EventArgs e)
        {
            string id = comboBoxLeaseCarCar.Text.Split(' ')[0];
            float sum = 0;
            carLease = MainForm.cars.Find(item => item.ID == int.Parse(id));
            categoryLease = MainForm.categories.Find(item=>item.ID == carLease.categoryID);
            DateTime lease = dateTimeOfLeasing.Value;
            DateTime returning = dateTimeOfReturning_lease.Value;
            TimeSpan span = returning - lease;
            int relative = span.Days;

            sum = relative * categoryLease.tariff;
            if(sum <= 0)
            {
                textBoxLeaseCarSum.Text = "Error";
                return;
            }
            textBoxLeaseCarSum.Text = sum.ToString()+" BYR";
            buttonLease.Enabled = true;
        }

        private void comboBoxLeaseCarCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!loaded) // костыль, отвратительный
            {
                loaded = true;
                return;
            }

            comboBoxLeaseCarCar.Items.Clear();
            comboBoxLeaseCarCar.Text = "";

            string categoryId = comboBoxLeaseCarCategory.Text.Split(' ')[0];
            if(categoryId == "All")
            {

                foreach (Car car in MainForm.cars)
                {
                    comboBoxLeaseCarCar.Items.Add($"{car.ID} {car.brand} {car.model} {car.yearOfProduction}");
                }
                comboBoxLeaseCarCar.SelectedIndex = 0;
                return;
            }
            
            List<Car> cars = carsPresenter.getCars(categoryId);

            foreach (Car car in cars)
            {
                comboBoxLeaseCarCar.Items.Add($"{car.ID} {car.brand} {car.model} {car.yearOfProduction}");
            }
            if (comboBoxLeaseCarCar.Items.Count != 0)
            {
                comboBoxLeaseCarCar.SelectedIndex = 0;
            }
            //обновляется список comboBoxLeaseCarCar в соответствии с выбранной категорией
            
        }

        private void buttonLeaseCarChooseClient_Click(object sender, EventArgs e)
        {
            string clientId = comboBoxLeaseCarClients.Text.Split(' ')[0];
            clientLease = clientPresenter.getClient(clientId);
            if(clientLease == null)
            {
                MessageBox.Show("Error. Why??");
                return;
            }
            buttonLease.Enabled = false;
            if (clientLease.isReliable )
            {
                textBoxLeaseCarIsReliable.Text = "Yes";
                textBoxLeaseCarIsReliable.BackColor = Color.Green;
            }
            else
            {
                textBoxLeaseCarIsReliable.Text = "No";
                textBoxLeaseCarIsReliable.BackColor = Color.Red;
                buttonLeaseCarCalculate.Enabled = false;
                return;
            }
            buttonLeaseCarCalculate.Enabled = true;
            textBoxLeaseClientName.Text = clientLease.name;
            textBoxLeaseClientSurname.Text = clientLease.surname;
            textBoxLeaseCarTel.Text = "+" + clientLease.telephoneNumber;
        }

        private void buttonLease_Click(object sender, EventArgs e)
        {
            string clientId = clientLease.ID.ToString();
            string workerId = workerPresenter.getWorkerId(AuthPresenter.activeUser.login);
            Console.WriteLine("workerId "+ workerId);
            string carId = carLease.ID.ToString();
            string dateOfLeasing = dateTimeOfLeasing.Value.ToString("d");
            string dateOfStipulatedReturn = dateTimeOfReturning_lease.Value.ToString("d");
            string sum = textBoxLeaseCarSum.Text.Split(' ')[0];

            string contractId = (contractPresenter.getMaxId() + 1).ToString();

            Contract contract = contractPresenter.addContract(new string[]{contractId, clientId, workerId, carId, dateOfLeasing,
                dateOfStipulatedReturn, DateTime.Now.ToString("d"), sum, ""}) ;
            Console.WriteLine(contract.contractID);

            if (contract != null)
            {
                MainForm.cars.Find(item => item.ID == int.Parse(carId)).isOccupied = true;
                carsPresenter.setOccupied(carId);
                carsInUse++;
                toolStripStatusLabelCarsInUse.Text = carsInUse.ToString();
                comboBoxLeaseCarCar.Items.RemoveAt(comboBoxLeaseCarCar.SelectedIndex);
                if (comboBoxLeaseCarCar.Items.Count != 0)
                {
                    comboBoxLeaseCarCar.SelectedIndex = 0;
                }
                MainForm.carsOccupied.Add(MainForm.carsNotOccupied.Find(item => item.ID == int.Parse(carId)));
                Car car = MainForm.carsNotOccupied.Find(item => item.ID == int.Parse(carId));
                comboBoxReturnCar.Items.Add($"{car.ID} {car.brand} {car.model} {car.yearOfProduction}");
                MainForm.carsNotOccupied.Remove(MainForm.carsNotOccupied.Find(item => item.ID == int.Parse(carId)));
                comboBoxLeaseCarCar.Text = "";
                if(comboBoxLeaseCarCar.Items.Count != 0 )
                {
                    comboBoxLeaseCarCar.SelectedIndex = 0;
                }

                MainForm.activeContracts.Add(contract);
            }
            buttonLeaseCarCalculate.Enabled = true;
        }

        private void radioButtonReturnBad_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonReturnBad.Checked)
            {
                textBoxRepairCost.Enabled = true;
            }
            else
            {
                textBoxRepairCost.Enabled = false;
            }
        }

        private void buttonReturnTotal_Click(object sender, EventArgs e)
        {
            int carId = int.Parse(comboBoxReturnCar.Text.Split(' ')[0]);
            Contract contract = MainForm.activeContracts.Find(item => item.cardID == carId);
            Car car = MainForm.cars.Find(item => item.ID ==carId);
            Category category = MainForm.categories.Find(item=>item.ID == car.categoryID);

            DateTime returning = dateTimeOfReturning_return.Value;

            TimeSpan spanStipulated = contract.dateOfStipulatedReturn - contract.dateOfLeasing;
            int relativeStipulated = spanStipulated.Days;
            TimeSpan spanReal = returning - contract.dateOfStipulatedReturn;
            int relativeReal = spanReal.Days;

            float repairCost = 0;
            if (textBoxRepairCost.Text != "")
            {
                repairCost = float.Parse(textBoxRepairCost.Text);
            }

            float total = relativeStipulated * category.tariff + relativeReal*category.fine + repairCost;

            textBoxReturnTotalSum.Text = total.ToString() + "BYR";
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            // считать данные с полей  +
            // обновить контракт +
            // обновить машину  +
            // убрать её из carsOccupied, поместить в carsNotOccupied +
            // убрать контракт из activeContracts  +
            // убрать машину из комбо-бокса возврата +
            // добавить машину в комбо-бокс лизинга +
            // изменить счётчик машин +

            string comment = textBoxComment_return.Text;
            string total = textBoxReturnTotalSum.Text.Split(' ')[0];
            DateTime dateOfReturn = dateTimeOfReturning_return.Value;

            int carId = int.Parse(comboBoxReturnCar.Text.Split(' ')[0]);
            Contract contract = MainForm.activeContracts.Find(item => item.cardID == carId);
            contract.dateOfReturning = dateOfReturn;
            contract.comment = comment;
            contractPresenter.updateContract(contract);

            MainForm.carsOccupied.Find(item => item.ID == contract.cardID).isOccupied = false;
            MainForm.carsNotOccupied.Add(MainForm.carsOccupied.Find(item=>item.ID== contract.cardID));
            MainForm.carsOccupied.Remove(MainForm.carsOccupied.Find(item => item.ID == contract.cardID));

            MainForm.activeContracts.Remove(MainForm.activeContracts.Find(item=>item.contractID==contract.contractID));

            comboBoxLeaseCarCar.Items.Add(comboBoxReturnCar.Text);
            comboBoxReturnCar.Items.RemoveAt(comboBoxReturnCar.SelectedIndex);

            carsInUse--;
            toolStripStatusLabelCarsInUse.Text = carsInUse.ToString();

            comboBoxReturnCar.Text = "";
            textBoxRepairCost.Text = "";
            textBoxComment_return.Text = "";
            textBoxReturnTotalSum.Text = "";
            if (comboBoxReturnCar.Items.Count != 0)
            {
                comboBoxReturnCar.SelectedIndex = 0;
            }
        }

        private void textBoxComment_return_TextChanged(object sender, EventArgs e)
        {
            if(textBoxComment_return.Text != "")
            {
                buttonReturn.Enabled = true;
            } else
            {
                buttonReturn.Enabled = false;

            }
        }


    }
}
