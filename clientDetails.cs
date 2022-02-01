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
    public partial class clientDetails : Form
    {
        private layerBusines _busines = new layerBusines();
        
        public clientDetails()
        {
            InitializeComponent();
            _busines = new layerBusines();
        }

        #region EVENTS
        private void buttonClouse_Click(object sender, EventArgs e)
        {
            clouseDetail();
        }
        
        public void buttonSave_Click(object sender, EventArgs e)
        {
            save();
            clouseDetail();
            ((main)this.Owner).loadContact();
        }

        private void connectar_Click(object sender, EventArgs e)
        {
            _busines.Connection();
        }
        #endregion

        #region PRIVATE METHODS
        private void clouseDetail()
        {
            this.Close();
        }

        private void save()
        {
            modelsContact models = new modelsContact();
            models.id = (int)userId.Value;
            models.nameFirst = userNameFirst.Text;
            models.nameLast = userNameLast.Text;
            models.phone = dPhone.Text;
            models.addres = userAddres.Text;    
            _busines.createUser(models);
        }

        private void clear()
        {
            userId.Value = 0;
            userNameFirst.Text = String.Empty;
            userNameLast.Text = String.Empty;
            dPhone.Text = String.Empty;
            userAddres.Text = String.Empty;
        }
        #endregion

        #region PUBLIC METHOD
        public void edit(modelsContact models)
        {
            if (models != null)
            {
                clear();
                userId.Value = models.id;
                userNameFirst.Text = models.nameFirst;
                userNameLast.Text = models.nameLast;
                dPhone.Text = models.phone;
                userAddres.Text = models.addres;
            }
            #endregion
        }
    }
}
