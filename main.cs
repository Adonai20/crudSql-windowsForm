using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crudSql
{
    public partial class main : Form
    {
        private layerBusines _busines;
        public main()
        {
            InitializeComponent();
            _busines = new layerBusines();
        }

        #region Events 
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            openDetail();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            loadContact(searchBar.Text);
            searchBar.Text = string.Empty;
        }
        #endregion

        #region PUBLIC METHOD

        public void loadContact(string search = null)
        {
            List<modelsContact> contacts = _busines.GetContactos(search);
            gridContacs.DataSource = contacts;
        }

        public void recordDelete(int id)
        {
            _busines.Delete(id);
        }
        #endregion

        #region PRIVATE METHODS

        private void main_Load(object sender, EventArgs e)
        {
            loadContact();
        }

        private void gridContacs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewLinkCell cell = (DataGridViewLinkCell)gridContacs.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (cell.Value.ToString() == "Edit")
            {
                clientDetails link = new clientDetails();
                link.edit(new modelsContact
                {
                    id = int.Parse(gridContacs.Rows[e.RowIndex].Cells[0].Value.ToString()),
                    nameFirst = gridContacs.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    nameLast = gridContacs.Rows[e.RowIndex].Cells[2].Value.ToString(),
                    phone = gridContacs.Rows[e.RowIndex].Cells[3].Value.ToString(),
                    addres = gridContacs.Rows[e.RowIndex].Cells[4].Value.ToString(),
                });
                link.ShowDialog(this);
            }
            else if (cell.Value.ToString() == "Delete")
            {
                recordDelete(int.Parse(gridContacs.Rows[e.RowIndex].Cells[0].Value.ToString()));
                loadContact();
            }
        }

        private void openDetail()
        {
            clientDetails open = new clientDetails();
            open.ShowDialog(this);
        }
        #endregion

    }
}
