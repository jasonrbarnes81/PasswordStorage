using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordStorage
{
    public partial class NewEntry : Form
    {
        private string _connection;
        public NewEntry(string connection)
        {
            InitializeComponent();
            _connection = connection;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            con = new SqlConnection(_connection);
            AddItem add = new AddItem();
            try
            {
                if (add.InsertItem(_connection, tbUsername.Text, tbPassword.Text, tbDescription.Text))
                {
                    tbUsername.Text = "";
                    tbPassword.Text = "";
                    tbDescription.Text = "";
                }
                else
                {
                    MessageBox.Show("Entry Was Not Added.");
                };
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Entry Was Not Added.", ex.Message);
            }
        }
    }
}
