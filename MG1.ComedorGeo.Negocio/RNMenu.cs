using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MG1.ComedorGeo.Datos;
using MG1.ComedorGeo.Utilitarios;

namespace MG1.ComedorGeo.Negocio
{
    public class RNMenu : Contexto
    {
        dbAlimentacionGeoEntities Esquema;

        public RNMenu()
        {
            Esquema = this.TraerContexto();
        }

        public Boolean Insertar(Menu objMenu)
        {
            try
            {
                Esquema.Menu.Add(objMenu);
                return Esquema.SaveChanges() == 1;
            }
            catch (Exception f)
            {
                return false;
            }
        }

        public Int64 TraerId(Int64 id, DateTime dt)
        {
            if (id == 0)
            {
                return Convert.ToInt64(from m in Esquema.Menu select m);
            }
            else
            {
                return Convert.ToInt64(from m in Esquema.Menu where m.idAlimento.Equals(id) && m.FechaMenu.Equals(dt) select m);
            }
        }

    }
}
