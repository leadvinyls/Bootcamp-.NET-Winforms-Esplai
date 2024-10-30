using System.Drawing;
using System.Windows.Forms;

namespace Bootcamp_.NET_Winforms_Esplai
{
    partial class FormBootstrap
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.prodCheckBox = new System.Windows.Forms.CheckBox();
            this.locationLabel = new System.Windows.Forms.Label();
            this.locationComboBox = new System.Windows.Forms.ComboBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.criticityComboBox = new System.Windows.Forms.ComboBox();
            this.criticityLabel = new System.Windows.Forms.Label();
            this.environmentLabel = new System.Windows.Forms.Label();
            this.preprodCheckBox = new System.Windows.Forms.CheckBox();
            this.demoCheckBox = new System.Windows.Forms.CheckBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.startDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.durationLabel = new System.Windows.Forms.Label();
            this.durationNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.statusLabel = new System.Windows.Forms.Label();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.completeTrackBar = new System.Windows.Forms.TrackBar();
            this.completeLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.sendEmailCheckBox = new System.Windows.Forms.CheckBox();
            this.percentLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.durationNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.completeTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.CausesValidation = false;
            this.titleLabel.Font = new System.Drawing.Font("Ubuntu", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(32, 35);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(36, 17);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title";
            // 
            // titleTextBox
            // 
            this.titleTextBox.AllowDrop = true;
            this.titleTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleTextBox.Font = new System.Drawing.Font("Ubuntu", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTextBox.Location = new System.Drawing.Point(35, 56);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(188, 22);
            this.titleTextBox.TabIndex = 1;
            // 
            // prodCheckBox
            // 
            this.prodCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prodCheckBox.AutoSize = true;
            this.prodCheckBox.Font = new System.Drawing.Font("Ubuntu", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodCheckBox.Location = new System.Drawing.Point(340, 122);
            this.prodCheckBox.Name = "prodCheckBox";
            this.prodCheckBox.Size = new System.Drawing.Size(59, 21);
            this.prodCheckBox.TabIndex = 5;
            this.prodCheckBox.Tag = "";
            this.prodCheckBox.Text = "Prod";
            this.prodCheckBox.UseVisualStyleBackColor = true;
            // 
            // locationLabel
            // 
            this.locationLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.locationLabel.AutoSize = true;
            this.locationLabel.Font = new System.Drawing.Font("Ubuntu", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLabel.Location = new System.Drawing.Point(258, 35);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(61, 17);
            this.locationLabel.TabIndex = 0;
            this.locationLabel.Text = "Location";
            // 
            // locationComboBox
            // 
            this.locationComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.locationComboBox.FormattingEnabled = true;
            this.locationComboBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.locationComboBox.Items.AddRange(new object[] {
            "Spain",
            "England",
            "United States",
            "Netherlands",
            "Switzerland"});
            this.locationComboBox.Location = new System.Drawing.Point(261, 56);
            this.locationComboBox.Name = "locationComboBox";
            this.locationComboBox.Size = new System.Drawing.Size(188, 25);
            this.locationComboBox.TabIndex = 2;
            this.locationComboBox.Tag = "required";
            // 
            // typeComboBox
            // 
            this.typeComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.typeComboBox.Items.AddRange(new object[] {
            "TypeA",
            "TypeB",
            "TypeC"});
            this.typeComboBox.Location = new System.Drawing.Point(35, 122);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(129, 25);
            this.typeComboBox.TabIndex = 3;
            this.typeComboBox.Tag = "required";
            // 
            // typeLabel
            // 
            this.typeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Ubuntu", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLabel.Location = new System.Drawing.Point(32, 100);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(38, 17);
            this.typeLabel.TabIndex = 0;
            this.typeLabel.Text = "Type";
            // 
            // criticityComboBox
            // 
            this.criticityComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.criticityComboBox.FormattingEnabled = true;
            this.criticityComboBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.criticityComboBox.Items.AddRange(new object[] {
            "IndicentA",
            "IncidentB",
            "IncidentC",
            "IncidentD"});
            this.criticityComboBox.Location = new System.Drawing.Point(189, 122);
            this.criticityComboBox.Name = "criticityComboBox";
            this.criticityComboBox.Size = new System.Drawing.Size(129, 25);
            this.criticityComboBox.TabIndex = 4;
            this.criticityComboBox.Tag = "required";
            // 
            // criticityLabel
            // 
            this.criticityLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.criticityLabel.AutoSize = true;
            this.criticityLabel.Font = new System.Drawing.Font("Ubuntu", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.criticityLabel.Location = new System.Drawing.Point(186, 100);
            this.criticityLabel.Name = "criticityLabel";
            this.criticityLabel.Size = new System.Drawing.Size(57, 17);
            this.criticityLabel.TabIndex = 0;
            this.criticityLabel.Text = "Criticity";
            // 
            // environmentLabel
            // 
            this.environmentLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.environmentLabel.AutoSize = true;
            this.environmentLabel.Font = new System.Drawing.Font("Ubuntu", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.environmentLabel.Location = new System.Drawing.Point(337, 100);
            this.environmentLabel.Name = "environmentLabel";
            this.environmentLabel.Size = new System.Drawing.Size(84, 17);
            this.environmentLabel.TabIndex = 0;
            this.environmentLabel.Text = "Environment";
            // 
            // preprodCheckBox
            // 
            this.preprodCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.preprodCheckBox.AutoSize = true;
            this.preprodCheckBox.Location = new System.Drawing.Point(340, 151);
            this.preprodCheckBox.Name = "preprodCheckBox";
            this.preprodCheckBox.Size = new System.Drawing.Size(80, 21);
            this.preprodCheckBox.TabIndex = 6;
            this.preprodCheckBox.Tag = "";
            this.preprodCheckBox.Text = "Preprod";
            this.preprodCheckBox.UseVisualStyleBackColor = true;
            // 
            // demoCheckBox
            // 
            this.demoCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.demoCheckBox.AutoSize = true;
            this.demoCheckBox.Location = new System.Drawing.Point(340, 178);
            this.demoCheckBox.Name = "demoCheckBox";
            this.demoCheckBox.Size = new System.Drawing.Size(66, 21);
            this.demoCheckBox.TabIndex = 7;
            this.demoCheckBox.Tag = "";
            this.demoCheckBox.Text = "Demo";
            this.demoCheckBox.UseVisualStyleBackColor = true;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.descriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descriptionTextBox.Location = new System.Drawing.Point(35, 222);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(413, 96);
            this.descriptionTextBox.TabIndex = 8;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.BackColor = System.Drawing.Color.Transparent;
            this.descriptionLabel.Font = new System.Drawing.Font("Ubuntu", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(32, 201);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(78, 17);
            this.descriptionLabel.TabIndex = 0;
            this.descriptionLabel.Text = "Description";
            // 
            // startDateDateTimePicker
            // 
            this.startDateDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startDateDateTimePicker.CalendarTitleBackColor = System.Drawing.Color.Black;
            this.startDateDateTimePicker.CalendarTrailingForeColor = System.Drawing.Color.Transparent;
            this.startDateDateTimePicker.CustomFormat = "";
            this.startDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDateDateTimePicker.Location = new System.Drawing.Point(36, 356);
            this.startDateDateTimePicker.Name = "startDateDateTimePicker";
            this.startDateDateTimePicker.Size = new System.Drawing.Size(188, 22);
            this.startDateDateTimePicker.TabIndex = 9;
            this.startDateDateTimePicker.Tag = "required";
            this.startDateDateTimePicker.Value = new System.DateTime(2024, 10, 30, 10, 35, 49, 0);
            // 
            // startDateLabel
            // 
            this.startDateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.startDateLabel.Font = new System.Drawing.Font("Ubuntu", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDateLabel.Location = new System.Drawing.Point(33, 335);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(72, 17);
            this.startDateLabel.TabIndex = 0;
            this.startDateLabel.Tag = "required";
            this.startDateLabel.Text = "Start Date";
            // 
            // durationLabel
            // 
            this.durationLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.durationLabel.AutoSize = true;
            this.durationLabel.BackColor = System.Drawing.Color.Transparent;
            this.durationLabel.Font = new System.Drawing.Font("Ubuntu", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durationLabel.Location = new System.Drawing.Point(248, 335);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(119, 17);
            this.durationLabel.TabIndex = 0;
            this.durationLabel.Tag = "required";
            this.durationLabel.Text = "Duration (in Hours)";
            // 
            // durationNumericUpDown
            // 
            this.durationNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.durationNumericUpDown.AutoSize = true;
            this.durationNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.durationNumericUpDown.Location = new System.Drawing.Point(251, 356);
            this.durationNumericUpDown.Name = "durationNumericUpDown";
            this.durationNumericUpDown.Size = new System.Drawing.Size(188, 22);
            this.durationNumericUpDown.TabIndex = 10;
            this.durationNumericUpDown.Tag = "required";
            // 
            // statusLabel
            // 
            this.statusLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(33, 394);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(47, 17);
            this.statusLabel.TabIndex = 0;
            this.statusLabel.Tag = "required";
            this.statusLabel.Text = "Status";
            // 
            // statusComboBox
            // 
            this.statusComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.statusComboBox.Items.AddRange(new object[] {
            "Planned",
            "Unplanned",
            "In-progress"});
            this.statusComboBox.Location = new System.Drawing.Point(36, 414);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(188, 25);
            this.statusComboBox.TabIndex = 11;
            this.statusComboBox.Tag = "required";
            // 
            // completeTrackBar
            // 
            this.completeTrackBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.completeTrackBar.LargeChange = 50;
            this.completeTrackBar.Location = new System.Drawing.Point(251, 414);
            this.completeTrackBar.Maximum = 100;
            this.completeTrackBar.Name = "completeTrackBar";
            this.completeTrackBar.Size = new System.Drawing.Size(188, 56);
            this.completeTrackBar.SmallChange = 25;
            this.completeTrackBar.TabIndex = 12;
            this.completeTrackBar.Tag = "";
            this.completeTrackBar.TickFrequency = 25;
            this.completeTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.completeTrackBar.ValueChanged += new System.EventHandler(this.completeTrackBar_ValueChanged);
            // 
            // completeLabel
            // 
            this.completeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.completeLabel.AutoSize = true;
            this.completeLabel.Location = new System.Drawing.Point(248, 394);
            this.completeLabel.Name = "completeLabel";
            this.completeLabel.Size = new System.Drawing.Size(122, 17);
            this.completeLabel.TabIndex = 13;
            this.completeLabel.Tag = "required";
            this.completeLabel.Text = "Complete Percent";
            // 
            // submitButton
            // 
            this.submitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.submitButton.BackColor = System.Drawing.Color.SteelBlue;
            this.submitButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.submitButton.FlatAppearance.BorderSize = 0;
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitButton.ForeColor = System.Drawing.Color.White;
            this.submitButton.Location = new System.Drawing.Point(340, 480);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(109, 39);
            this.submitButton.TabIndex = 14;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Location = new System.Drawing.Point(225, 480);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(109, 39);
            this.cancelButton.TabIndex = 15;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // sendEmailCheckBox
            // 
            this.sendEmailCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sendEmailCheckBox.AutoSize = true;
            this.sendEmailCheckBox.Font = new System.Drawing.Font("Ubuntu", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendEmailCheckBox.Location = new System.Drawing.Point(36, 498);
            this.sendEmailCheckBox.Name = "sendEmailCheckBox";
            this.sendEmailCheckBox.Size = new System.Drawing.Size(100, 21);
            this.sendEmailCheckBox.TabIndex = 16;
            this.sendEmailCheckBox.Text = "Send Email";
            this.sendEmailCheckBox.UseVisualStyleBackColor = true;
            // 
            // percentLabel
            // 
            this.percentLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.percentLabel.AutoSize = true;
            this.percentLabel.Location = new System.Drawing.Point(435, 418);
            this.percentLabel.Name = "percentLabel";
            this.percentLabel.Size = new System.Drawing.Size(0, 17);
            this.percentLabel.TabIndex = 18;
            this.percentLabel.Tag = "required";
            // 
            // FormBootstrap
            // 
            this.AcceptButton = this.submitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(488, 552);
            this.Controls.Add(this.percentLabel);
            this.Controls.Add(this.sendEmailCheckBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.completeLabel);
            this.Controls.Add(this.completeTrackBar);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.durationNumericUpDown);
            this.Controls.Add(this.durationLabel);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.startDateDateTimePicker);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.demoCheckBox);
            this.Controls.Add(this.preprodCheckBox);
            this.Controls.Add(this.environmentLabel);
            this.Controls.Add(this.criticityComboBox);
            this.Controls.Add(this.criticityLabel);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.locationComboBox);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.prodCheckBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.titleLabel);
            this.Font = new System.Drawing.Font("Ubuntu", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "FormBootstrap";
            this.ShowIcon = false;
            this.Text = "Form Bootstrap";
            this.Load += new System.EventHandler(this.FormBootstrap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.durationNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.completeTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.CheckBox prodCheckBox;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.ComboBox locationComboBox;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.ComboBox criticityComboBox;
        private System.Windows.Forms.Label criticityLabel;
        private System.Windows.Forms.Label environmentLabel;
        private System.Windows.Forms.CheckBox preprodCheckBox;
        private System.Windows.Forms.CheckBox demoCheckBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label descriptionLabel;
        private DateTimePicker startDateDateTimePicker;
        private Label startDateLabel;
        private Label durationLabel;
        private NumericUpDown durationNumericUpDown;
        private Label statusLabel;
        private ComboBox statusComboBox;
        private TrackBar completeTrackBar;
        private Label completeLabel;
        private Button submitButton;
        private Button cancelButton;
        private CheckBox sendEmailCheckBox;
        private Label percentLabel;
    }
}

