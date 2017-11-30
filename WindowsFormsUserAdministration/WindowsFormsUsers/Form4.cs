﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseService;

namespace WindowsFormsUsers
{
    public partial class Form4 : Form
    {
        private readonly Form1 FormUserList;
        public Form4(Form1 FormUsers)
        {
            FormUserList = FormUsers;
            InitializeComponent();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {

            User oUser = new User();
            Crud Crud = new Crud();
            oUser.sUserName= inptAddName.Text;
            oUser.sUserFirstName = inptAddUsername.Text;
            oUser.sUserLastName = inptAddSurname.Text;
            oUser.sUserPassword = inptAddPassword.Text;

            Crud.AddUsers(oUser);
            this.FormUserList.dataGridViewUsers.DataSource = Crud.GetUsers();
            this.Hide();
        }
    }
}
