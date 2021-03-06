﻿using System;
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

        ushort cars_in_use = 0;
        Form extraForm;
        static Form adminForm = null;
        static Form workerForm = null;
        static public List<Category> categories;
        static public List<Car> cars;
        static public List<Client> clients;
        static public List<Car> carsNotOccupied;
        static public List<Car> carsOccupied;
        static public List<Contract> activeContracts;


        ClientPresenter clientPresenter;
        CarsPresenter carsPresenter;
        ContractPresenter contractPresenter;
        CategoriesPresenter categoriesPresenter;


        public MainForm()
        {
            clientPresenter = new ClientPresenter();
            carsPresenter = new CarsPresenter();
            contractPresenter = new ContractPresenter();
            categoriesPresenter = new CategoriesPresenter();
            InitializeComponent();
        }

     
        private void MainForm_Load(object sender, EventArgs e)
        {
            categories = categoriesPresenter.getCategories();
            clients = clientPresenter.getClients();
            cars = carsPresenter.getCars();
            foreach (Category cat in categories)
            {
                //listBoxCategories.Items.Add(cat.getName());
            }

            carsNotOccupied = carsPresenter.getCarsOccupied(false);
            carsOccupied = carsPresenter.getCarsOccupied(true);

            activeContracts = contractPresenter.getActiveContracts();

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


        private void button5_Click(object sender, EventArgs e)
        {
          //  buttonReturn.Enabled = true;
        }

        private void buttonViewClient_Click(object sender, EventArgs e)
        {
            extraForm = new Form();
            extraForm.StartPosition = FormStartPosition.CenterScreen;
            extraForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!CheckConnection.check())
            {
                label1.Text = "Error";
            }
            else
            {
                label1.Text = "Opened";
            }
            
        }

        private void buttonLogin_Click(object sender, EventArgs e) // аутентификация
        {
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;

            AuthPresenter.activeUser = AuthPresenter.authenticate(AuthPresenter.activeUser, login, password);
            if (AuthPresenter.activeUser == null)
            {
                MessageBox.Show("Login or password is invalid!");
                return;
            }            
            textBoxPassword.Clear();
            if (AuthPresenter.activeUser.isAdmin)
            {
                adminAccess();
            }
            else
            {
                workerAccess();
            }
        }
    }
}
