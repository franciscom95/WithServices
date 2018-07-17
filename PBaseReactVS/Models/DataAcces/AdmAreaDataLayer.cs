using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace PBaseReactVS.Models
{
    public class AdmAreaDataLayer
    {
        //Contexto
        DBBaseReactContext db = new DBBaseReactContext();
        public IEnumerable<AdmArea> GetAllAreas()

        {

            try

            {

                return db.AdmArea.ToList();

            }

            catch

            {

                throw;

            }

        }

        //To Add new employee record     

        public int AddArea(AdmArea area)

        {

            try

            {

                db.AdmArea.Add(area);

                db.SaveChanges();

                return 1;

            }

            catch

            {

                throw;

            }

        }

        //To Update the records of a particluar employee    

        public int UpdateArea(AdmArea area)

        {

            try

            {

                db.Entry(area).State = EntityState.Modified;

                db.SaveChanges();

                return 1;

            }

            catch

            {

                throw;

            }

        }

        //Get the details of a particular employee    

        public AdmArea GetAreaData(int id)

        {

            try

            {

                AdmArea area = db.AdmArea.Find(id);

                return area;

            }

            catch

            {

                throw;

            }

        }

        //To Delete the record of a particular employee    

        public int DeleteArea(int id)

        {

            try

            {

                AdmArea area = db.AdmArea.Find(id);

                db.AdmArea.Remove(area);

                db.SaveChanges();

                return 1;

            }

            catch

            {

                throw;

            }

        }

    
 


    }
}
