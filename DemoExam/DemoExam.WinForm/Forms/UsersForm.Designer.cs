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
            pageSizeComboBox = new ComboBox();
            label1 = new Label();
            NextPrevButton = new Button();
            button1 = new Button();
            paginationLabel = new Label();
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
            UsersDataGrid.Size = new Size(688, 345);
            UsersDataGrid.TabIndex = 0;
            UsersDataGrid.CellMouseClick += UsersDataGrid_CellMouseClick;
            // 
            // pageSizeComboBox
            // 
            pageSizeComboBox.FormattingEnabled = true;
            pageSizeComboBox.Location = new Point(137, 401);
            pageSizeComboBox.Name = "pageSizeComboBox";
            pageSizeComboBox.Size = new Size(81, 23);
            pageSizeComboBox.TabIndex = 4;
            pageSizeComboBox.SelectedIndexChanged += pageSizeComboBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 404);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 5;
            label1.Text = "Размер страницы";
            // 
            // NextPrevButton
            // 
            NextPrevButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            NextPrevButton.Location = new Point(619, 399);
            NextPrevButton.Name = "NextPrevButton";
            NextPrevButton.Size = new Size(28, 39);
            NextPrevButton.TabIndex = 6;
            NextPrevButton.Text = ">";
            NextPrevButton.UseVisualStyleBackColor = true;
            NextPrevButton.Click += NextPrevButton_Click_1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(403, 399);
            button1.Name = "button1";
            button1.Size = new Size(28, 39);
            button1.TabIndex = 7;
            button1.Text = "<";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // paginationLabel
            // 
            paginationLabel.AutoSize = true;
            paginationLabel.Location = new Point(488, 414);
            paginationLabel.Name = "paginationLabel";
            paginationLabel.Size = new Size(38, 15);
            paginationLabel.TabIndex = 8;
            paginationLabel.Text = "label2";
            // 
            // UsersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(986, 450);
            Controls.Add(paginationLabel);
            Controls.Add(button1);
            Controls.Add(NextPrevButton);
            Controls.Add(label1);
            Controls.Add(pageSizeComboBox);
            Controls.Add(DeleteUserButton);
            Controls.Add(EditUserButton);
            Controls.Add(CreateUserButtom);
            Controls.Add(UsersDataGrid);
            Name = "UsersForm";
            Text = "UsersForm";
            Shown += UsersForm_Shown;
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)UsersDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private ComboBox pageSizeComboBox;
        private Label label1;
        private Button NextPrevButton;
        private Button button1;
        private Label paginationLabel;
    }
}