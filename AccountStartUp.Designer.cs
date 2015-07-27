namespace Kitchen_Manager
{
    partial class AccountStartUp
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
            System.Windows.Forms.Label usernameLabel;
            System.Windows.Forms.Label passwordLabel;
            this.kitchenDataSet = new Kitchen_Manager.KitchenDataSet();
            this.passwordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.passwordTableAdapter = new Kitchen_Manager.KitchenDataSetTableAdapters.PasswordTableAdapter();
            this.tableAdapterManager = new Kitchen_Manager.KitchenDataSetTableAdapters.TableAdapterManager();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.buttonCreateAdmin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            usernameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kitchenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new System.Drawing.Point(82, 80);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(56, 13);
            usernameLabel.TabIndex = 3;
            usernameLabel.Text = "username:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(82, 106);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(55, 13);
            passwordLabel.TabIndex = 5;
            passwordLabel.Text = "password:";
            // 
            // kitchenDataSet
            // 
            this.kitchenDataSet.DataSetName = "KitchenDataSet";
            this.kitchenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // passwordBindingSource
            // 
            this.passwordBindingSource.DataMember = "Password";
            this.passwordBindingSource.DataSource = this.kitchenDataSet;
            // 
            // passwordTableAdapter
            // 
            this.passwordTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.IngredientsTableAdapter = null;
            this.tableAdapterManager.PackagingTableAdapter = null;
            this.tableAdapterManager.PasswordTableAdapter = this.passwordTableAdapter;
            this.tableAdapterManager.StaffTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Kitchen_Manager.KitchenDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.passwordBindingSource, "username", true));
            this.usernameTextBox.Location = new System.Drawing.Point(147, 77);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(100, 20);
            this.usernameTextBox.TabIndex = 4;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.passwordBindingSource, "password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(147, 103);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox.TabIndex = 6;
            // 
            // buttonCreateAdmin
            // 
            this.buttonCreateAdmin.Location = new System.Drawing.Point(107, 146);
            this.buttonCreateAdmin.Name = "buttonCreateAdmin";
            this.buttonCreateAdmin.Size = new System.Drawing.Size(109, 23);
            this.buttonCreateAdmin.TabIndex = 7;
            this.buttonCreateAdmin.Text = "CREATE ADMIN";
            this.buttonCreateAdmin.UseVisualStyleBackColor = true;
            this.buttonCreateAdmin.Click += new System.EventHandler(this.buttonCreateAdmin_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "This is the first time running the program. \r\nPlease create an ADMIN username & p" +
    "assword";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(280, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "DELETE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // AccountStartUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 203);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCreateAdmin);
            this.Controls.Add(usernameLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Name = "AccountStartUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountStartUp";
            this.Load += new System.EventHandler(this.AccountStartUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kitchenDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KitchenDataSet kitchenDataSet;
        private System.Windows.Forms.BindingSource passwordBindingSource;
        private KitchenDataSetTableAdapters.PasswordTableAdapter passwordTableAdapter;
        private KitchenDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button buttonCreateAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}