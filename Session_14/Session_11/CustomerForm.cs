﻿using DevExpress.XtraEditors;
using EF_Library.Repositories;
using PetShopLib.Impl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_11
{
    public partial class CustomerForm : DevExpress.XtraEditors.XtraForm
    {
        private const string FILE_NAME = "PetShop.json";

        private PetShop _petShop;
        private Customer _customer;
        private Customer _originalcustomer = new Customer();

        private readonly IEntityRepo<Customer> _customerRepo;

        public CustomerForm()
        {
            InitializeComponent();
            
        }
        public CustomerForm(PetShop petShop, IEntityRepo<Customer> customerRepo)
        {
            InitializeComponent();
            _petShop = petShop;
            _customerRepo = customerRepo;
        }
        public CustomerForm(PetShop petShop,IEntityRepo<Customer> customerRepo ,Customer customer):this(petShop, customerRepo)
        {            
            _customer = customer;
        }
        private void CustomerForm_Load(object sender, EventArgs e)
        {
            if (_customer == null)
            {
                _customer = new Customer();
                _petShop.Customers.Add(_customer);
                bsCustomers.DataSource = _customer;
            }
            bsCustomers.DataSource = _customer;
            SetDataBindings();
            
        }

        private void SetDataBindings()
        {
            ctrlName.DataBindings.Add(new Binding("EditValue", bsCustomers,"Name",true));
            ctrlSurName.DataBindings.Add(new Binding("EditValue", bsCustomers, "SurName", true));
            ctrlTIN.DataBindings.Add(new Binding("EditValue", bsCustomers, "TIN", true));
            ctrlPhone.DataBindings.Add(new Binding("EditValue", bsCustomers, "Phone", true));
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            _customerRepo.Create(_customer);
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _petShop.Customers.Remove(_customer);
            this.Close();
        }
    }
}