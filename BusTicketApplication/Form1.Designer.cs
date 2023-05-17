
namespace BusTicketApplication
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBoxDataGrid = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seferBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.firstAppDataSet = new BusTicketApplication.FirstAppDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.seferBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelRegister = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBoxGender = new System.Windows.Forms.GroupBox();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxBus = new System.Windows.Forms.GroupBox();
            this.radioButton27 = new System.Windows.Forms.RadioButton();
            this.radioButton26 = new System.Windows.Forms.RadioButton();
            this.radioButton25 = new System.Windows.Forms.RadioButton();
            this.radioButton24 = new System.Windows.Forms.RadioButton();
            this.radioButton23 = new System.Windows.Forms.RadioButton();
            this.radioButton22 = new System.Windows.Forms.RadioButton();
            this.radioButton19 = new System.Windows.Forms.RadioButton();
            this.radioButton20 = new System.Windows.Forms.RadioButton();
            this.radioButton21 = new System.Windows.Forms.RadioButton();
            this.radioButton16 = new System.Windows.Forms.RadioButton();
            this.radioButton17 = new System.Windows.Forms.RadioButton();
            this.radioButton18 = new System.Windows.Forms.RadioButton();
            this.radioButton13 = new System.Windows.Forms.RadioButton();
            this.radioButton14 = new System.Windows.Forms.RadioButton();
            this.radioButton15 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.BtnBusInfo = new System.Windows.Forms.Button();
            this.buttonShutDown = new System.Windows.Forms.Button();
            this.seferTableAdapter = new BusTicketApplication.FirstAppDataSetTableAdapters.SeferTableAdapter();
            this.btnTicketCancel = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.groupBoxDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seferBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstAppDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seferBindingSource)).BeginInit();
            this.panelRegister.SuspendLayout();
            this.groupBoxGender.SuspendLayout();
            this.groupBoxBus.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDataGrid
            // 
            this.groupBoxDataGrid.Controls.Add(this.dataGridView1);
            this.groupBoxDataGrid.Controls.Add(this.label1);
            this.groupBoxDataGrid.Location = new System.Drawing.Point(12, 11);
            this.groupBoxDataGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxDataGrid.Name = "groupBoxDataGrid";
            this.groupBoxDataGrid.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxDataGrid.Size = new System.Drawing.Size(458, 190);
            this.groupBoxDataGrid.TabIndex = 15;
            this.groupBoxDataGrid.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView1.DataSource = this.seferBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(458, 150);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "departure";
            this.dataGridViewTextBoxColumn1.HeaderText = "departure";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "destination";
            this.dataGridViewTextBoxColumn2.HeaderText = "destination";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "price";
            this.dataGridViewTextBoxColumn3.HeaderText = "price";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // seferBindingSource1
            // 
            this.seferBindingSource1.DataMember = "Sefer";
            this.seferBindingSource1.DataSource = this.firstAppDataSet;
            // 
            // firstAppDataSet
            // 
            this.firstAppDataSet.DataSetName = "FirstAppDataSet";
            this.firstAppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(163, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Journey";
            // 
            // seferBindingSource
            // 
            this.seferBindingSource.DataMember = "Sefer";
            // 
            // panelRegister
            // 
            this.panelRegister.BackColor = System.Drawing.Color.Snow;
            this.panelRegister.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRegister.Controls.Add(this.btnSave);
            this.panelRegister.Controls.Add(this.groupBoxGender);
            this.panelRegister.Controls.Add(this.txtMail);
            this.panelRegister.Controls.Add(this.txtSurname);
            this.panelRegister.Controls.Add(this.txtName);
            this.panelRegister.Controls.Add(this.label6);
            this.panelRegister.Controls.Add(this.label5);
            this.panelRegister.Controls.Add(this.label4);
            this.panelRegister.Controls.Add(this.label3);
            this.panelRegister.Controls.Add(this.label2);
            this.panelRegister.Location = new System.Drawing.Point(476, 21);
            this.panelRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelRegister.Name = "panelRegister";
            this.panelRegister.Size = new System.Drawing.Size(301, 250);
            this.panelRegister.TabIndex = 16;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightSalmon;
            this.btnSave.Location = new System.Drawing.Point(24, 193);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(250, 30);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save your information";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBoxGender
            // 
            this.groupBoxGender.Controls.Add(this.radioButtonFemale);
            this.groupBoxGender.Controls.Add(this.radioButtonMale);
            this.groupBoxGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.groupBoxGender.Location = new System.Drawing.Point(113, 104);
            this.groupBoxGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxGender.Name = "groupBoxGender";
            this.groupBoxGender.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxGender.Size = new System.Drawing.Size(144, 38);
            this.groupBoxGender.TabIndex = 9;
            this.groupBoxGender.TabStop = false;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.radioButtonFemale.Location = new System.Drawing.Point(72, 12);
            this.radioButtonFemale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(75, 21);
            this.radioButtonFemale.TabIndex = 1;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.radioButtonMale.Location = new System.Drawing.Point(7, 12);
            this.radioButtonMale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(59, 21);
            this.radioButtonMale.TabIndex = 0;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtMail.Location = new System.Drawing.Point(113, 151);
            this.txtMail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(161, 28);
            this.txtMail.TabIndex = 8;
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtSurname.Location = new System.Drawing.Point(113, 72);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(161, 28);
            this.txtSurname.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtName.Location = new System.Drawing.Point(113, 40);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(161, 28);
            this.txtName.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.Location = new System.Drawing.Point(20, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(20, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(20, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(20, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(48, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Your Information";
            // 
            // groupBoxBus
            // 
            this.groupBoxBus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBoxBus.Controls.Add(this.radioButton27);
            this.groupBoxBus.Controls.Add(this.radioButton26);
            this.groupBoxBus.Controls.Add(this.radioButton25);
            this.groupBoxBus.Controls.Add(this.radioButton24);
            this.groupBoxBus.Controls.Add(this.radioButton23);
            this.groupBoxBus.Controls.Add(this.radioButton22);
            this.groupBoxBus.Controls.Add(this.radioButton19);
            this.groupBoxBus.Controls.Add(this.radioButton20);
            this.groupBoxBus.Controls.Add(this.radioButton21);
            this.groupBoxBus.Controls.Add(this.radioButton16);
            this.groupBoxBus.Controls.Add(this.radioButton17);
            this.groupBoxBus.Controls.Add(this.radioButton18);
            this.groupBoxBus.Controls.Add(this.radioButton13);
            this.groupBoxBus.Controls.Add(this.radioButton14);
            this.groupBoxBus.Controls.Add(this.radioButton15);
            this.groupBoxBus.Controls.Add(this.radioButton10);
            this.groupBoxBus.Controls.Add(this.radioButton11);
            this.groupBoxBus.Controls.Add(this.radioButton12);
            this.groupBoxBus.Controls.Add(this.radioButton7);
            this.groupBoxBus.Controls.Add(this.radioButton8);
            this.groupBoxBus.Controls.Add(this.radioButton9);
            this.groupBoxBus.Controls.Add(this.radioButton4);
            this.groupBoxBus.Controls.Add(this.radioButton5);
            this.groupBoxBus.Controls.Add(this.radioButton6);
            this.groupBoxBus.Controls.Add(this.radioButton3);
            this.groupBoxBus.Controls.Add(this.radioButton2);
            this.groupBoxBus.Controls.Add(this.radioButton);
            this.groupBoxBus.Controls.Add(this.radioButton1);
            this.groupBoxBus.Location = new System.Drawing.Point(12, 275);
            this.groupBoxBus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxBus.Name = "groupBoxBus";
            this.groupBoxBus.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxBus.Size = new System.Drawing.Size(765, 263);
            this.groupBoxBus.TabIndex = 17;
            this.groupBoxBus.TabStop = false;
            // 
            // radioButton27
            // 
            this.radioButton27.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton27.BackColor = System.Drawing.Color.LightGray;
            this.radioButton27.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.radioButton27.Location = new System.Drawing.Point(638, 37);
            this.radioButton27.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton27.Name = "radioButton27";
            this.radioButton27.Size = new System.Drawing.Size(70, 48);
            this.radioButton27.TabIndex = 27;
            this.radioButton27.TabStop = true;
            this.radioButton27.Text = "27";
            this.radioButton27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton27.UseVisualStyleBackColor = false;
            // 
            // radioButton26
            // 
            this.radioButton26.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton26.BackColor = System.Drawing.Color.LightGray;
            this.radioButton26.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.radioButton26.Location = new System.Drawing.Point(638, 89);
            this.radioButton26.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton26.Name = "radioButton26";
            this.radioButton26.Size = new System.Drawing.Size(70, 48);
            this.radioButton26.TabIndex = 26;
            this.radioButton26.TabStop = true;
            this.radioButton26.Text = "26";
            this.radioButton26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton26.UseVisualStyleBackColor = false;
            // 
            // radioButton25
            // 
            this.radioButton25.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton25.BackColor = System.Drawing.Color.LightGray;
            this.radioButton25.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.radioButton25.Location = new System.Drawing.Point(638, 201);
            this.radioButton25.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton25.Name = "radioButton25";
            this.radioButton25.Size = new System.Drawing.Size(70, 48);
            this.radioButton25.TabIndex = 25;
            this.radioButton25.TabStop = true;
            this.radioButton25.Text = "25";
            this.radioButton25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton25.UseVisualStyleBackColor = false;
            // 
            // radioButton24
            // 
            this.radioButton24.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton24.BackColor = System.Drawing.Color.LightGray;
            this.radioButton24.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.radioButton24.Location = new System.Drawing.Point(562, 37);
            this.radioButton24.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton24.Name = "radioButton24";
            this.radioButton24.Size = new System.Drawing.Size(70, 48);
            this.radioButton24.TabIndex = 24;
            this.radioButton24.TabStop = true;
            this.radioButton24.Text = "24";
            this.radioButton24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton24.UseVisualStyleBackColor = false;
            // 
            // radioButton23
            // 
            this.radioButton23.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton23.BackColor = System.Drawing.Color.LightGray;
            this.radioButton23.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.radioButton23.Location = new System.Drawing.Point(562, 89);
            this.radioButton23.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton23.Name = "radioButton23";
            this.radioButton23.Size = new System.Drawing.Size(70, 48);
            this.radioButton23.TabIndex = 23;
            this.radioButton23.TabStop = true;
            this.radioButton23.Text = "23";
            this.radioButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton23.UseVisualStyleBackColor = false;
            // 
            // radioButton22
            // 
            this.radioButton22.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton22.BackColor = System.Drawing.Color.LightGray;
            this.radioButton22.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.radioButton22.Location = new System.Drawing.Point(562, 201);
            this.radioButton22.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton22.Name = "radioButton22";
            this.radioButton22.Size = new System.Drawing.Size(70, 48);
            this.radioButton22.TabIndex = 22;
            this.radioButton22.TabStop = true;
            this.radioButton22.Text = "22";
            this.radioButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton22.UseVisualStyleBackColor = false;
            // 
            // radioButton19
            // 
            this.radioButton19.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton19.BackColor = System.Drawing.Color.LightGray;
            this.radioButton19.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.radioButton19.Location = new System.Drawing.Point(486, 201);
            this.radioButton19.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton19.Name = "radioButton19";
            this.radioButton19.Size = new System.Drawing.Size(70, 48);
            this.radioButton19.TabIndex = 19;
            this.radioButton19.TabStop = true;
            this.radioButton19.Text = "19";
            this.radioButton19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton19.UseVisualStyleBackColor = false;
            // 
            // radioButton20
            // 
            this.radioButton20.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton20.BackColor = System.Drawing.Color.LightGray;
            this.radioButton20.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.radioButton20.Location = new System.Drawing.Point(486, 89);
            this.radioButton20.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton20.Name = "radioButton20";
            this.radioButton20.Size = new System.Drawing.Size(70, 48);
            this.radioButton20.TabIndex = 20;
            this.radioButton20.TabStop = true;
            this.radioButton20.Text = "20";
            this.radioButton20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton20.UseVisualStyleBackColor = false;
            // 
            // radioButton21
            // 
            this.radioButton21.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton21.BackColor = System.Drawing.Color.LightGray;
            this.radioButton21.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.radioButton21.Location = new System.Drawing.Point(486, 37);
            this.radioButton21.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton21.Name = "radioButton21";
            this.radioButton21.Size = new System.Drawing.Size(70, 48);
            this.radioButton21.TabIndex = 21;
            this.radioButton21.TabStop = true;
            this.radioButton21.Text = "21";
            this.radioButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton21.UseVisualStyleBackColor = false;
            // 
            // radioButton16
            // 
            this.radioButton16.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton16.BackColor = System.Drawing.Color.LightGray;
            this.radioButton16.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.radioButton16.Location = new System.Drawing.Point(410, 201);
            this.radioButton16.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton16.Name = "radioButton16";
            this.radioButton16.Size = new System.Drawing.Size(70, 48);
            this.radioButton16.TabIndex = 16;
            this.radioButton16.TabStop = true;
            this.radioButton16.Text = "16";
            this.radioButton16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton16.UseVisualStyleBackColor = false;
            // 
            // radioButton17
            // 
            this.radioButton17.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton17.BackColor = System.Drawing.Color.LightGray;
            this.radioButton17.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.radioButton17.Location = new System.Drawing.Point(410, 89);
            this.radioButton17.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton17.Name = "radioButton17";
            this.radioButton17.Size = new System.Drawing.Size(70, 48);
            this.radioButton17.TabIndex = 17;
            this.radioButton17.TabStop = true;
            this.radioButton17.Text = "17";
            this.radioButton17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton17.UseVisualStyleBackColor = false;
            // 
            // radioButton18
            // 
            this.radioButton18.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton18.BackColor = System.Drawing.Color.LightGray;
            this.radioButton18.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.radioButton18.Location = new System.Drawing.Point(410, 37);
            this.radioButton18.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton18.Name = "radioButton18";
            this.radioButton18.Size = new System.Drawing.Size(70, 48);
            this.radioButton18.TabIndex = 18;
            this.radioButton18.TabStop = true;
            this.radioButton18.Text = "18";
            this.radioButton18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton18.UseVisualStyleBackColor = false;
            // 
            // radioButton13
            // 
            this.radioButton13.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton13.BackColor = System.Drawing.Color.LightGray;
            this.radioButton13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.radioButton13.Location = new System.Drawing.Point(334, 201);
            this.radioButton13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton13.Name = "radioButton13";
            this.radioButton13.Size = new System.Drawing.Size(70, 48);
            this.radioButton13.TabIndex = 13;
            this.radioButton13.TabStop = true;
            this.radioButton13.Text = "13";
            this.radioButton13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton13.UseVisualStyleBackColor = false;
            // 
            // radioButton14
            // 
            this.radioButton14.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton14.BackColor = System.Drawing.Color.LightGray;
            this.radioButton14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.radioButton14.Location = new System.Drawing.Point(334, 89);
            this.radioButton14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton14.Name = "radioButton14";
            this.radioButton14.Size = new System.Drawing.Size(70, 48);
            this.radioButton14.TabIndex = 14;
            this.radioButton14.TabStop = true;
            this.radioButton14.Text = "14";
            this.radioButton14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton14.UseVisualStyleBackColor = false;
            // 
            // radioButton15
            // 
            this.radioButton15.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton15.BackColor = System.Drawing.Color.LightGray;
            this.radioButton15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.radioButton15.Location = new System.Drawing.Point(334, 37);
            this.radioButton15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton15.Name = "radioButton15";
            this.radioButton15.Size = new System.Drawing.Size(70, 48);
            this.radioButton15.TabIndex = 15;
            this.radioButton15.TabStop = true;
            this.radioButton15.Text = "15";
            this.radioButton15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton15.UseVisualStyleBackColor = false;
            // 
            // radioButton10
            // 
            this.radioButton10.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton10.BackColor = System.Drawing.Color.LightGray;
            this.radioButton10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.radioButton10.Location = new System.Drawing.Point(258, 201);
            this.radioButton10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(70, 48);
            this.radioButton10.TabIndex = 10;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "10";
            this.radioButton10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton10.UseVisualStyleBackColor = false;
            // 
            // radioButton11
            // 
            this.radioButton11.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton11.BackColor = System.Drawing.Color.LightGray;
            this.radioButton11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.radioButton11.Location = new System.Drawing.Point(258, 89);
            this.radioButton11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(70, 48);
            this.radioButton11.TabIndex = 11;
            this.radioButton11.TabStop = true;
            this.radioButton11.Text = "11";
            this.radioButton11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton11.UseVisualStyleBackColor = false;
            // 
            // radioButton12
            // 
            this.radioButton12.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton12.BackColor = System.Drawing.Color.LightGray;
            this.radioButton12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.radioButton12.Location = new System.Drawing.Point(258, 37);
            this.radioButton12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(70, 48);
            this.radioButton12.TabIndex = 12;
            this.radioButton12.TabStop = true;
            this.radioButton12.Text = "12";
            this.radioButton12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton12.UseVisualStyleBackColor = false;
            // 
            // radioButton7
            // 
            this.radioButton7.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton7.BackColor = System.Drawing.Color.LightGray;
            this.radioButton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.radioButton7.Location = new System.Drawing.Point(182, 201);
            this.radioButton7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(70, 48);
            this.radioButton7.TabIndex = 9;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "7";
            this.radioButton7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton7.UseVisualStyleBackColor = false;
            // 
            // radioButton8
            // 
            this.radioButton8.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton8.BackColor = System.Drawing.Color.LightGray;
            this.radioButton8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.radioButton8.Location = new System.Drawing.Point(182, 89);
            this.radioButton8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(70, 48);
            this.radioButton8.TabIndex = 8;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "8";
            this.radioButton8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton8.UseVisualStyleBackColor = false;
            // 
            // radioButton9
            // 
            this.radioButton9.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton9.BackColor = System.Drawing.Color.LightGray;
            this.radioButton9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.radioButton9.Location = new System.Drawing.Point(182, 37);
            this.radioButton9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(70, 48);
            this.radioButton9.TabIndex = 7;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "9";
            this.radioButton9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton9.UseVisualStyleBackColor = false;
            // 
            // radioButton4
            // 
            this.radioButton4.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton4.BackColor = System.Drawing.Color.LightGray;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.radioButton4.Location = new System.Drawing.Point(106, 201);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(70, 48);
            this.radioButton4.TabIndex = 6;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "4";
            this.radioButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton4.UseVisualStyleBackColor = false;
            // 
            // radioButton5
            // 
            this.radioButton5.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton5.BackColor = System.Drawing.Color.LightGray;
            this.radioButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.radioButton5.Location = new System.Drawing.Point(106, 89);
            this.radioButton5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(70, 48);
            this.radioButton5.TabIndex = 5;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "5";
            this.radioButton5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton5.UseVisualStyleBackColor = false;
            // 
            // radioButton6
            // 
            this.radioButton6.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton6.BackColor = System.Drawing.Color.LightGray;
            this.radioButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.radioButton6.Location = new System.Drawing.Point(106, 37);
            this.radioButton6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(70, 48);
            this.radioButton6.TabIndex = 4;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "6";
            this.radioButton6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton6.UseVisualStyleBackColor = false;
            // 
            // radioButton3
            // 
            this.radioButton3.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton3.BackColor = System.Drawing.Color.LightGray;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.radioButton3.Location = new System.Drawing.Point(30, 201);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(70, 48);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "1";
            this.radioButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton3.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            this.radioButton2.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton2.BackColor = System.Drawing.Color.LightGray;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.radioButton2.Location = new System.Drawing.Point(30, 89);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(70, 48);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "2";
            this.radioButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton
            // 
            this.radioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton.BackColor = System.Drawing.Color.LightGray;
            this.radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.radioButton.Location = new System.Drawing.Point(30, 37);
            this.radioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton.Name = "radioButton";
            this.radioButton.Size = new System.Drawing.Size(70, 48);
            this.radioButton.TabIndex = 1;
            this.radioButton.TabStop = true;
            this.radioButton.Text = "3";
            this.radioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton.UseVisualStyleBackColor = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Cursor = System.Windows.Forms.Cursors.Default;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.radioButton1.Location = new System.Drawing.Point(1323, -226);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(177, 33);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // BtnBusInfo
            // 
            this.BtnBusInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnBusInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.BtnBusInfo.Location = new System.Drawing.Point(12, 542);
            this.BtnBusInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnBusInfo.Name = "BtnBusInfo";
            this.BtnBusInfo.Size = new System.Drawing.Size(153, 36);
            this.BtnBusInfo.TabIndex = 6;
            this.BtnBusInfo.Text = "Bus Info";
            this.BtnBusInfo.UseVisualStyleBackColor = false;
            this.BtnBusInfo.Click += new System.EventHandler(this.BtnBusInfo_Click);
            // 
            // buttonShutDown
            // 
            this.buttonShutDown.BackColor = System.Drawing.Color.Red;
            this.buttonShutDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonShutDown.Location = new System.Drawing.Point(569, 544);
            this.buttonShutDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonShutDown.Name = "buttonShutDown";
            this.buttonShutDown.Size = new System.Drawing.Size(208, 36);
            this.buttonShutDown.TabIndex = 6;
            this.buttonShutDown.Text = "Exit";
            this.buttonShutDown.UseVisualStyleBackColor = false;
            this.buttonShutDown.Click += new System.EventHandler(this.buttonShutDown_Click);
            // 
            // seferTableAdapter
            // 
            this.seferTableAdapter.ClearBeforeFill = true;
            // 
            // btnTicketCancel
            // 
            this.btnTicketCancel.BackColor = System.Drawing.Color.IndianRed;
            this.btnTicketCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnTicketCancel.Location = new System.Drawing.Point(265, 215);
            this.btnTicketCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTicketCancel.Name = "btnTicketCancel";
            this.btnTicketCancel.Size = new System.Drawing.Size(205, 36);
            this.btnTicketCancel.TabIndex = 19;
            this.btnTicketCancel.Text = "Ticket Cancel";
            this.btnTicketCancel.UseVisualStyleBackColor = false;
            // 
            // btnBuy
            // 
            this.btnBuy.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnBuy.Location = new System.Drawing.Point(12, 215);
            this.btnBuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(208, 36);
            this.btnBuy.TabIndex = 18;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(795, 591);
            this.Controls.Add(this.btnTicketCancel);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.BtnBusInfo);
            this.Controls.Add(this.buttonShutDown);
            this.Controls.Add(this.groupBoxBus);
            this.Controls.Add(this.panelRegister);
            this.Controls.Add(this.groupBoxDataGrid);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxDataGrid.ResumeLayout(false);
            this.groupBoxDataGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seferBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstAppDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seferBindingSource)).EndInit();
            this.panelRegister.ResumeLayout(false);
            this.panelRegister.PerformLayout();
            this.groupBoxGender.ResumeLayout(false);
            this.groupBoxGender.PerformLayout();
            this.groupBoxBus.ResumeLayout(false);
            this.groupBoxBus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDataGrid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelRegister;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBoxGender;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxBus;
        private System.Windows.Forms.RadioButton radioButton24;
        private System.Windows.Forms.RadioButton radioButton23;
        private System.Windows.Forms.RadioButton radioButton22;
        private System.Windows.Forms.RadioButton radioButton19;
        private System.Windows.Forms.RadioButton radioButton20;
        private System.Windows.Forms.RadioButton radioButton21;
        private System.Windows.Forms.RadioButton radioButton16;
        private System.Windows.Forms.RadioButton radioButton17;
        private System.Windows.Forms.RadioButton radioButton18;
        private System.Windows.Forms.RadioButton radioButton13;
        private System.Windows.Forms.RadioButton radioButton14;
        private System.Windows.Forms.RadioButton radioButton15;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.RadioButton radioButton11;
        private System.Windows.Forms.RadioButton radioButton12;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton27;
        private System.Windows.Forms.RadioButton radioButton26;
        private System.Windows.Forms.RadioButton radioButton25;
        private System.Windows.Forms.Button buttonShutDown;
        private System.Windows.Forms.Button BtnBusInfo;
        
        private System.Windows.Forms.BindingSource seferBindingSource;
        
        private System.Windows.Forms.DataGridViewTextBoxColumn departureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private FirstAppDataSet firstAppDataSet;
        private System.Windows.Forms.BindingSource seferBindingSource1;
        private FirstAppDataSetTableAdapters.SeferTableAdapter seferTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button btnTicketCancel;
        private System.Windows.Forms.Button btnBuy;
    }
}