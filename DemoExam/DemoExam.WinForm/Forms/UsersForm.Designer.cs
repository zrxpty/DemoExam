namespace DemoExam.WinForm.Forms
{
    partial class UsersForm
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
            components = new System.ComponentModel.Container();
            CreateUserButtom = new Button();
            EditUserButton = new Button();
            DeleteUserButton = new Button();
            userBindingSource = new BindingSource(components);
            passwordDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            UsersDataGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UsersDataGrid).BeginInit();
            SuspendLayout();
            // 
            // CreateUserButtom
            // 
            CreateUserButtom.Location = new Point(724, 34);
            CreateUserButtom.Name = "CreateUserButtom";
            CreateUserButtom.Size = new Size(164, 63);
            CreateUserButtom.TabIndex = 1;
            CreateUserButtom.Text = "Создать";
            CreateUserButtom.UseVisualStyleBackColor = true;
            CreateUserButtom.Click += CreateUserButtom_Click_1;
            // 
            // EditUserButton
            // 
            EditUserButton.Location = new Point(724, 103);
            EditUserButton.Name = "EditUserButton";
            EditUserButton.Size = new Size(164, 63);
            EditUserButton.TabIndex = 2;
            EditUserButton.Text = "Edit";
            EditUserButton.UseVisualStyleBackColor = true;
            // 
            // DeleteUserButton
            // 
            DeleteUserButton.Location = new Point(724, 172);
            DeleteUserButton.Name = "DeleteUserButton";
            DeleteUserButton.Size = new Size(164, 63);
            DeleteUserButton.TabIndex = 3;
            DeleteUserButton.Text = "Delete";
            DeleteUserButton.UseVisualStyleBackColor = true;
            DeleteUserButton.Click += DeleteUserButton_Click;
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(Data.Models.User);
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // UsersDataGrid
            // 
            UsersDataGrid.AutoGenerateColumns = false;
            UsersDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UsersDataGrid.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, passwordDataGridViewTextBoxColumn });
            UsersDataGrid.DataSource = userBindingSource;
            UsersDataGrid.Location = new Point(12, 34);
            UsersDataGrid.Name = "UsersDataGrid";
            UsersDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            UsersDataGrid.Size = new Size(688, 404);
            UsersDataGrid.TabIndex = 0;
            UsersDataGrid.CellMouseClick += UsersDataGrid_CellMouseClick;
            // 
            // UsersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(986, 450);
            Controls.Add(DeleteUserButton);
            Controls.Add(EditUserButton);
            Controls.Add(CreateUserButtom);
            Controls.Add(UsersDataGrid);
            Name = "UsersForm";
            Text = "UsersForm";
            Load += UsersForm_Load;
            Shown += UsersForm_Shown;
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)UsersDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button CreateUserButtom;
        private Button EditUserButton;
        private Button DeleteUserButton;
        private BindingSource userBindingSource;
        private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridView UsersDataGrid;
    }
}