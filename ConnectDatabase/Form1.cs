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

namespace ConnectDatabase
{
    public partial class MainForm : Form
    {
        static string connectionString = "Data Source=85.208.21.117:54321;" +
            "Initial Catalog=DylanEmployees;" +
            "User id=sa;" +
            "Password=Sql#123456789;";
        static SqlConnection connection = new SqlConnection(connectionString);
        public MainForm()
        {
            InitializeComponent();
            ConnectionStatusPanel.Width = this.Width - 50;
            ConnectionStatusPanel.Left = (this.Width - ConnectionStatusPanel.Width) / 2;
            this.MinimumSize = new Size(ConnectionStatusPanel.Width, 0);
            ConnectButton.Width = ConnectionStatusPanel.Width / 2 - 5;
            ConnectButton.Left = ConnectionStatusPanel.Left;
            DisconnectButton.Width = ConnectButton.Width;
            DisconnectButton.Left = ConnectionStatusPanel.Right - DisconnectButton.Width;
            
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            ConnectButton.Width = ConnectionStatusPanel.Width / 2 - 5;
            ConnectButton.Left = ConnectionStatusPanel.Left;
            DisconnectButton.Width = ConnectButton.Width;
            DisconnectButton.Left = ConnectionStatusPanel.Right - DisconnectButton.Width;
            ConnectionStatusPanel.MinimumSize = new Size(DisconnectButton.MinimumSize.Width + ConnectButton.MinimumSize.Width + 10, 0);
        }

        private async void ConnectButton_Click(object sender, EventArgs e)
        {
            ConnectionStatusLabel.Text = "Connecting to Database...";
            ConnectionStatusPanel.BackColor = Color.FromArgb(237, 145, 33);

            try
            {
                await connection.OpenAsync();
            }
            catch (Exception)
            {

                ConnectionStatusLabel.Text = "Error al conectar";
            }
            finally 
            {
                ConnectionStatusPanel.BackColor = Color.FromArgb(76, 175, 80);
                ConnectButton.Enabled = false;
                ConnectButton.BackColor = Color.FromArgb(219, 219, 219);
                DisconnectButton.Enabled = true;
                DisconnectButton.BackColor = Color.FromArgb(255, 85, 85);
                ConnectionStatusLabel.Text = "Connected";
            }

            
        }

        private void DisconnectButton_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Close();
            }
            catch (Exception)
            {

                ConnectionStatusLabel.Text = "Error al cerrar";
            }
            finally
            {
                ConnectionStatusPanel.BackColor = Color.FromArgb(106, 115, 125);
                DisconnectButton.Enabled = false;
                DisconnectButton.BackColor = Color.FromArgb(219, 219, 219);
                ConnectButton.Enabled = true;
                ConnectButton.BackColor = Color.FromArgb(38, 139, 220);
                ConnectionStatusLabel.Text = "Disconnected";
            }
        }
    }
}
