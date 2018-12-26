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

        public WorkerForm()
        {
            workerPresenter = new WorkerPresenter();
            clientPresenter = new ClientPresenter();
            InitializeComponent();
        }

        private void WorkerForm_Load(object sender, EventArgs e)
        {
            toolStripLabelWorkerName.Text = $"Welcome, {AuthPresenter.activeUser.name} {AuthPresenter.activeUser.surname}";
            MainForm.clients = clientPresenter.getClients();
            foreach(Client cl in MainForm.clients)
            {
                comboBoxViewClient.Items.Add($"{cl.ID} {cl.name} {cl.surname}");
            }
        }

        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            string name = textBoxAddClientName.Text;
            string surname = textBoxAddClientSurname.Text;
            bool sex = radioButtonAddClientMale.Checked;
            DateTime date = dateTimePickerAddClientDrivingStart.Value;

            Client client = clientPresenter.addClient(new string[] { name, surname, sex.ToString(), date.ToString("d")});
            if (client == null)
            {
                MessageBox.Show("Error");
            }
            else
            {
                MainForm.clients.Add(client);
                comboBoxViewClient.Items.Add($"{client.ID} {client.name} {client.surname}");

                MessageBox.Show("Client is added!");
            }

        }
    }
}
