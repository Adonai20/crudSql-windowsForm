using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudSql
{
    public class layerBusines
    {
        private layerDate _data = new layerDate();   
        
        public void Connection()
        {
            _data.Connectar();
        }

        public modelsContact createUser(modelsContact models)
        {
            if (models.id == 0)
            {
                _data.userCreate(models);
            }
            else
            {
                _data.UserUpdate(models);
            }
            return models;
        }         

        public List<modelsContact> GetContactos(string search = null)
        {
            return _data.mostrarActualizar (search);  
        }

        public void Delete(int id)
        {
            _data.UserDelete(id);
        }
               
    } 
}
