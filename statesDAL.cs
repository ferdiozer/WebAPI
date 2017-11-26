using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfControl.DAL
{//Telefon Durum(mobil_state) veritabanı işlemleri    //       CRUD
    public class statesDAL
    {
        //EF ile veritabanı bağlantısı
        SelfControlDBEntities db = new SelfControlDBEntities();
        
        //Tüm durumları Getir
        public IEnumerable<mobil_state> getAll()
        {
            return db.mobil_state;
        }

        // İd ye göre durum getir
        public mobil_state getById(int id)
        {
            return db.mobil_state.Find(id);
        }

        // Ekleme işlemi (eklenen nesneyi Geri Döndür)
        public mobil_state create(mobil_state s)
        {
            db.mobil_state.Add(s);
            db.SaveChanges();

            return s;
        }

        // Güncelleme
        public mobil_state update(int id,mobil_state s)
        {
            db.Entry(s).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();

            return s;
        }

        //Silme
        public void delete(int id)
        {       //gelen id ye ait bir surum bulması durumunda silecektir
            db.mobil_state.Remove(db.mobil_state.Find(id));
            db.SaveChanges();
        }
    }
}
