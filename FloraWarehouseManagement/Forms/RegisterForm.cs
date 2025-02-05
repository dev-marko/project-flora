﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

using FloraWarehouseManagement.Classes.Utilities;

namespace FloraWarehouseManagement.Forms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            AlignControls.CenterControlHorizontal(pnlLogo);
            AlignControls.CenterControlHorizontal(pnlButtons);
        }

        private void RegisterForm_SizeChanged(object sender, EventArgs e)
        {
            AlignControls.CenterControlHorizontal(pnlLogo);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            int userExists = CheckCredentials.CheckUsername(tbUsername.Text);

            if(userExists < 1)
            {
                try
                {
                    AddUser.Register(tbUsername.Text, tbPassword.Text);
                }
                finally
                {
                    if 
                    (
                        MessageBox.Show
                        (
                            "Регистрацијата е успешна!",
                            "Регистрација",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Information
                        )
                        == DialogResult.OK
                    )
                    {
                        this.Close();
                    }
                }

            } else
            {
                MessageBox.Show
                (
                    "Тоа корисничко име веќе постои!", 
                    "Грешка", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
