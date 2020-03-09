using System;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace PasswordStorage
{
    public partial class PasswordManager : Form
    {
        public PasswordManager()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = null;


            connectionString = @"Data Source=" + tbServerName.Text + ";Initial Catalog=" + tbDatabseName.Text + "; User ID=" +
                tbSQLUsername.Text + "; Password=" + tbSQLPassword.Text;

            RetreiveItems items = new RetreiveItems();
            dgPasswordInfo.DataSource = items.SelectAll(connectionString);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string connectionString = null;
            int Id;

            connectionString = @"Data Source=" + tbServerName.Text + ";Initial Catalog=" + tbDatabseName.Text + "; User ID=" +
                tbSQLUsername.Text + "; Password=" + tbSQLPassword.Text;

            foreach (DataGridViewRow item in dgPasswordInfo.Rows)
            {
                Int32.TryParse(item.Cells[0].Value.ToString(), out Id);
                try
                {
                    DeleteItem removeRow = new DeleteItem();
                    if(removeRow.DeleteRow(connectionString, Id))
                    {
                        dgPasswordInfo.Rows.RemoveAt(item.Cells[0].RowIndex);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Entry Was Not Deleted", ex.Message);
                }
                
               
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string connectionString = null;
            

            connectionString = @"Data Source=" + tbServerName.Text + ";Initial Catalog=" + tbDatabseName.Text + "; User ID=" +
                tbSQLUsername.Text + "; Password=" + tbSQLPassword.Text;

            NewEntry newEntry = new NewEntry(connectionString);
           
                newEntry.Show();
           

        }
    }
}
