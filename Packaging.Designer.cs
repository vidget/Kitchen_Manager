namespace Kitchen_Manager
{
    partial class Packaging
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label typeLabel;
            System.Windows.Forms.Label quantityLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label retail_sale_priceLabel;
            System.Windows.Forms.Label notesLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Packaging));
            this.packagingBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.packagingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kitchenDataSet = new Kitchen_Manager.KitchenDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.packagingBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.packagingDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.retail_sale_priceTextBox = new System.Windows.Forms.TextBox();
            this.notesRichTextBox = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.packagingTableAdapter = new Kitchen_Manager.KitchenDataSetTableAdapters.PackagingTableAdapter();
            this.tableAdapterManager = new Kitchen_Manager.KitchenDataSetTableAdapters.TableAdapterManager();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label44 = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            retail_sale_priceLabel = new System.Windows.Forms.Label();
            notesLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.packagingBindingNavigator)).BeginInit();
            this.packagingBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.packagingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitchenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagingDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(16, 15);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 2;
            idLabel.Text = "Id:";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new System.Drawing.Point(99, 15);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(30, 13);
            typeLabel.TabIndex = 4;
            typeLabel.Text = "type:";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new System.Drawing.Point(16, 47);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(47, 13);
            quantityLabel.TabIndex = 6;
            quantityLabel.Text = "quantity:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(116, 48);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(33, 13);
            priceLabel.TabIndex = 8;
            priceLabel.Text = "price:";
            // 
            // retail_sale_priceLabel
            // 
            retail_sale_priceLabel.AutoSize = true;
            retail_sale_priceLabel.Location = new System.Drawing.Point(258, 48);
            retail_sale_priceLabel.Name = "retail_sale_priceLabel";
            retail_sale_priceLabel.Size = new System.Drawing.Size(80, 13);
            retail_sale_priceLabel.TabIndex = 10;
            retail_sale_priceLabel.Text = "retail sale price:";
            // 
            // notesLabel1
            // 
            notesLabel1.AutoSize = true;
            notesLabel1.Location = new System.Drawing.Point(16, 82);
            notesLabel1.Name = "notesLabel1";
            notesLabel1.Size = new System.Drawing.Size(36, 13);
            notesLabel1.TabIndex = 14;
            notesLabel1.Text = "notes:";
            // 
            // packagingBindingNavigator
            // 
            this.packagingBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.packagingBindingNavigator.BindingSource = this.packagingBindingSource;
            this.packagingBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.packagingBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.packagingBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.packagingBindingNavigatorSaveItem});
            this.packagingBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.packagingBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.packagingBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.packagingBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.packagingBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.packagingBindingNavigator.Name = "packagingBindingNavigator";
            this.packagingBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.packagingBindingNavigator.Size = new System.Drawing.Size(642, 25);
            this.packagingBindingNavigator.TabIndex = 0;
            this.packagingBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // packagingBindingSource
            // 
            this.packagingBindingSource.DataMember = "Packaging";
            this.packagingBindingSource.DataSource = this.kitchenDataSet;
            // 
            // kitchenDataSet
            // 
            this.kitchenDataSet.DataSetName = "KitchenDataSet";
            this.kitchenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // packagingBindingNavigatorSaveItem
            // 
            this.packagingBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.packagingBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("packagingBindingNavigatorSaveItem.Image")));
            this.packagingBindingNavigatorSaveItem.Name = "packagingBindingNavigatorSaveItem";
            this.packagingBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.packagingBindingNavigatorSaveItem.Text = "Save Data";
            this.packagingBindingNavigatorSaveItem.Click += new System.EventHandler(this.packagingBindingNavigatorSaveItem_Click);
            // 
            // packagingDataGridView
            // 
            this.packagingDataGridView.AutoGenerateColumns = false;
            this.packagingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.packagingDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.packagingDataGridView.DataSource = this.packagingBindingSource;
            this.packagingDataGridView.Location = new System.Drawing.Point(12, 232);
            this.packagingDataGridView.Name = "packagingDataGridView";
            this.packagingDataGridView.Size = new System.Drawing.Size(618, 201);
            this.packagingDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 25;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "type";
            this.dataGridViewTextBoxColumn2.HeaderText = "type";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "quantity";
            this.dataGridViewTextBoxColumn3.HeaderText = "quantity";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 50;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "price";
            this.dataGridViewTextBoxColumn4.HeaderText = "price";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 75;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "retail_sale_price";
            this.dataGridViewTextBoxColumn5.HeaderText = "sale_price";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 75;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "notes";
            this.dataGridViewTextBoxColumn6.HeaderText = "notes";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 200;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packagingBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(41, 12);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(50, 20);
            this.idTextBox.TabIndex = 3;
            // 
            // typeTextBox
            // 
            this.typeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packagingBindingSource, "type", true));
            this.typeTextBox.Location = new System.Drawing.Point(135, 13);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(283, 20);
            this.typeTextBox.TabIndex = 5;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packagingBindingSource, "quantity", true));
            this.quantityTextBox.Location = new System.Drawing.Point(69, 45);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(41, 20);
            this.quantityTextBox.TabIndex = 7;
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packagingBindingSource, "price", true));
            this.priceTextBox.Location = new System.Drawing.Point(155, 45);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(88, 20);
            this.priceTextBox.TabIndex = 9;
            // 
            // retail_sale_priceTextBox
            // 
            this.retail_sale_priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packagingBindingSource, "retail_sale_price", true));
            this.retail_sale_priceTextBox.Location = new System.Drawing.Point(344, 45);
            this.retail_sale_priceTextBox.Name = "retail_sale_priceTextBox";
            this.retail_sale_priceTextBox.Size = new System.Drawing.Size(74, 20);
            this.retail_sale_priceTextBox.TabIndex = 11;
            // 
            // notesRichTextBox
            // 
            this.notesRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packagingBindingSource, "notes", true));
            this.notesRichTextBox.Location = new System.Drawing.Point(58, 79);
            this.notesRichTextBox.Name = "notesRichTextBox";
            this.notesRichTextBox.Size = new System.Drawing.Size(360, 56);
            this.notesRichTextBox.TabIndex = 15;
            this.notesRichTextBox.Text = "";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(idLabel);
            this.panel1.Controls.Add(notesLabel1);
            this.panel1.Controls.Add(this.retail_sale_priceTextBox);
            this.panel1.Controls.Add(this.notesRichTextBox);
            this.panel1.Controls.Add(retail_sale_priceLabel);
            this.panel1.Controls.Add(this.priceTextBox);
            this.panel1.Controls.Add(this.idTextBox);
            this.panel1.Controls.Add(priceLabel);
            this.panel1.Controls.Add(typeLabel);
            this.panel1.Controls.Add(this.quantityTextBox);
            this.panel1.Controls.Add(this.typeTextBox);
            this.panel1.Controls.Add(quantityLabel);
            this.panel1.Location = new System.Drawing.Point(12, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 156);
            this.panel1.TabIndex = 16;
            // 
            // packagingTableAdapter
            // 
            this.packagingTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.IngredientsTableAdapter = null;
            this.tableAdapterManager.PackagingTableAdapter = this.packagingTableAdapter;
            this.tableAdapterManager.UpdateOrder = Kitchen_Manager.KitchenDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(467, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(158, 156);
            this.panel2.TabIndex = 17;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(14, 33);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(86, 18);
            this.label44.TabIndex = 18;
            this.label44.Text = "Packaging";
            // 
            // Packaging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 448);
            this.Controls.Add(this.label44);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.packagingDataGridView);
            this.Controls.Add(this.packagingBindingNavigator);
            this.Name = "Packaging";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Packaging";
            this.Load += new System.EventHandler(this.Packaging_Load);
            ((System.ComponentModel.ISupportInitialize)(this.packagingBindingNavigator)).EndInit();
            this.packagingBindingNavigator.ResumeLayout(false);
            this.packagingBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.packagingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitchenDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagingDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KitchenDataSet kitchenDataSet;
        private System.Windows.Forms.BindingSource packagingBindingSource;
        private KitchenDataSetTableAdapters.PackagingTableAdapter packagingTableAdapter;
        private KitchenDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator packagingBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton packagingBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView packagingDataGridView;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox retail_sale_priceTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.RichTextBox notesRichTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label44;
    }
}