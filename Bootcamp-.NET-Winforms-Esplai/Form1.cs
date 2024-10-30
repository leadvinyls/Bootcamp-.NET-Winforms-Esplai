using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bootcamp_.NET_Winforms_Esplai
{
    public partial class FormBootstrap : Form
    {
        public FormBootstrap()
        {
            InitializeComponent();

        }

        private bool IsControlEmpty(Control control)
        {
            if (control is TextBox textBox)
                return string.IsNullOrWhiteSpace(textBox.Text);
            if (control is ComboBox comboBox)
                return comboBox.SelectedIndex == -1 || string.IsNullOrWhiteSpace(comboBox.Text);
            if (control is ListBox listBox)
                return listBox.SelectedIndex == -1;
            if (control is CheckBox checkBox)
                return !checkBox.Checked;
            if (control is RadioButton radioButton)
                return !radioButton.Checked;
            if (control is NumericUpDown numericUpDown)
                return numericUpDown.Value == numericUpDown.Minimum;

            // Añadir más casos según el tipo de control

            return false;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl.Tag != null)
                {
                    if (ctrl.Tag.ToString() == "required")
                    {
                        if (IsControlEmpty(ctrl))
                        {
                            MessageBox.Show("Debe completar los campos obligatorios (*)");
                            return;
                        }
                    }
                }
            }



            MessageBox.Show($@"Title: {this.titleTextBox.Text}
Location: {this.locationComboBox.Text}
Type: {this.typeComboBox.Text}
Criticity: {this.criticityComboBox.Text}

Environments:{(this.prodCheckBox.Checked ? "\n   Production" : "" )}{(this.preprodCheckBox.Checked ? "\n   Pre-Production" : "")}{(this.demoCheckBox.Checked ? "\n   Demo" : "")}

Description:
    {this.descriptionTextBox.Text}

Start Date: {this.startDateDateTimePicker.Text}
Duration: {this.durationNumericUpDown.Value} hours
Status: {this.statusComboBox.Text}
Complete: {this.completeTrackBar.Value}%
{(this.sendEmailCheckBox.Checked ? "Email Sended" : "Email not sended")}");
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void completeTrackBar_ValueChanged(object sender, EventArgs e)
        {
            this.percentLabel.Text = this.completeTrackBar.Value.ToString();
        }

        private void FormBootstrap_Load(object sender, EventArgs e)
        {
            this.percentLabel.Text = this.completeTrackBar.Value.ToString();
        }
    }
}
