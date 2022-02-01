namespace crudSql
{
    partial class main
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
            this.components = new System.ComponentModel.Container();
            this.gridContacs = new System.Windows.Forms.DataGridView();
            this.userSearch = new System.Windows.Forms.Label();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.userDialog = new System.Windows.Forms.OpenFileDialog();
            this.modelsContactBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.modelsContactBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameFirstDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameLastDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Delete = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridContacs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelsContactBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelsContactBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridContacs
            // 
            this.gridContacs.AutoGenerateColumns = false;
            this.gridContacs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridContacs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameFirstDataGridViewTextBoxColumn,
            this.nameLastDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.addresDataGridViewTextBoxColumn,
            this.edit,
            this.Delete});
            this.gridContacs.DataSource = this.modelsContactBindingSource1;
            this.gridContacs.Location = new System.Drawing.Point(18, 103);
            this.gridContacs.Margin = new System.Windows.Forms.Padding(4);
            this.gridContacs.Name = "gridContacs";
            this.gridContacs.Size = new System.Drawing.Size(1147, 422);
            this.gridContacs.TabIndex = 0;
            this.gridContacs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridContacs_CellContentClick);
            // 
            // userSearch
            // 
            this.userSearch.AutoSize = true;
            this.userSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userSearch.Location = new System.Drawing.Point(27, 51);
            this.userSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userSearch.Name = "userSearch";
            this.userSearch.Size = new System.Drawing.Size(69, 16);
            this.userSearch.TabIndex = 1;
            this.userSearch.Text = "SEARCH";
            // 
            // searchBar
            // 
            this.searchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBar.Location = new System.Drawing.Point(113, 47);
            this.searchBar.Margin = new System.Windows.Forms.Padding(4);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(767, 24);
            this.searchBar.TabIndex = 2;
            this.searchBar.Text = " ";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(913, 47);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(112, 28);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(1048, 47);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(117, 28);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // userDialog
            // 
            this.userDialog.FileName = "openFileDialog1";
            // 
            // modelsContactBindingSource1
            // 
            this.modelsContactBindingSource1.DataSource = typeof(crudSql.modelsContact);
            // 
            // modelsContactBindingSource
            // 
            this.modelsContactBindingSource.DataSource = typeof(crudSql.modelsContact);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameFirstDataGridViewTextBoxColumn
            // 
            this.nameFirstDataGridViewTextBoxColumn.DataPropertyName = "nameFirst";
            this.nameFirstDataGridViewTextBoxColumn.HeaderText = "nameFirst";
            this.nameFirstDataGridViewTextBoxColumn.Name = "nameFirstDataGridViewTextBoxColumn";
            // 
            // nameLastDataGridViewTextBoxColumn
            // 
            this.nameLastDataGridViewTextBoxColumn.DataPropertyName = "nameLast";
            this.nameLastDataGridViewTextBoxColumn.HeaderText = "nameLast";
            this.nameLastDataGridViewTextBoxColumn.Name = "nameLastDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // addresDataGridViewTextBoxColumn
            // 
            this.addresDataGridViewTextBoxColumn.DataPropertyName = "addres";
            this.addresDataGridViewTextBoxColumn.HeaderText = "addres";
            this.addresDataGridViewTextBoxColumn.Name = "addresDataGridViewTextBoxColumn";
            // 
            // edit
            // 
            this.edit.ActiveLinkColor = System.Drawing.Color.Black;
            this.edit.HeaderText = "Edit";
            this.edit.LinkColor = System.Drawing.Color.DarkCyan;
            this.edit.Name = "edit";
            this.edit.ReadOnly = true;
            this.edit.Text = "Edit";
            this.edit.UseColumnTextForLinkValue = true;
            this.edit.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // Delete
            // 
            this.Delete.ActiveLinkColor = System.Drawing.Color.DarkCyan;
            this.Delete.HeaderText = "Delete";
            this.Delete.LinkColor = System.Drawing.Color.Teal;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForLinkValue = true;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1626, 576);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.userSearch);
            this.Controls.Add(this.gridContacs);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridContacs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelsContactBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelsContactBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridContacs;
        private System.Windows.Forms.Label userSearch;
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.OpenFileDialog userDialog;
        private System.Windows.Forms.BindingSource modelsContactBindingSource;
        private System.Windows.Forms.BindingSource modelsContactBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameFirstDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameLastDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn edit;
        private System.Windows.Forms.DataGridViewLinkColumn Delete;
    }
}

