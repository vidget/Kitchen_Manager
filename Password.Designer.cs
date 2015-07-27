namespace Kitchen_Manager
{
    partial class Password
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
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.buttonPasswordSubmit = new System.Windows.Forms.Button();
            this.kitchenDataSet = new Kitchen_Manager.KitchenDataSet();
            this.passwordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.passwordTableAdapter = new Kitchen_Manager.KitchenDataSetTableAdapters.PasswordTableAdapter();
            this.tableAdapterManager = new Kitchen_Manager.KitchenDataSetTableAdapters.TableAdapterManager();
            this.passwordListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.kitchenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(77, 53);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword.TabIndex = 2;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(18, 56);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(53, 13);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "User";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(77, 19);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(100, 20);
            this.textBoxUserName.TabIndex = 1;
            // 
            // buttonPasswordSubmit
            // 
            this.buttonPasswordSubmit.Location = new System.Drawing.Point(102, 90);
            this.buttonPasswordSubmit.Name = "buttonPasswordSubmit";
            this.buttonPasswordSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonPasswordSubmit.TabIndex = 3;
            this.buttonPasswordSubmit.Text = "SUBMIT";
            this.buttonPasswordSubmit.UseVisualStyleBackColor = true;
            this.buttonPasswordSubmit.Click += new System.EventHandler(this.buttonPasswordSubmit_Click);
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
            // passwordListBox
            // 
            this.passwordListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.passwordBindingSource, "password", true));
            this.passwordListBox.FormattingEnabled = true;
            this.passwordListBox.Location = new System.Drawing.Point(57, 256);
            this.passwordListBox.Name = "passwordListBox";
            this.passwordListBox.Size = new System.Drawing.Size(120, 95);
            this.passwordListBox.TabIndex = 7;
            this.passwordListBox.Visible = false;
            // 
            // Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 134);
            this.Controls.Add(this.passwordListBox);
            this.Controls.Add(this.buttonPasswordSubmit);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Name = "Password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password";
            this.Load += new System.EventHandler(this.Password_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kitchenDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Button buttonPasswordSubmit;
        private KitchenDataSet kitchenDataSet;
        private System.Windows.Forms.BindingSource passwordBindingSource;
        private KitchenDataSetTableAdapters.PasswordTableAdapter passwordTableAdapter;
        private KitchenDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ListBox passwordListBox;
    }
}