using Entities;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Business {
    public class B_Category {//Será el CRUD

        //LAMADO A DATOS
        public List<CategoryEntity> CategoryList() {
            using (var db = new InventaryContext()) { //Se usa Using para abrir y luego cerrar al finalizar la ulima instrucción cierra la conexión
                return db.Categories.ToList();
            }
        }

        //CREACIÓN DE DATOS
        public void CreateCategory(CategoryEntity oCategory) {
            using( var db = new InventaryContext()) {
                db.Categories.Add(oCategory);
                db.SaveChanges();
            }
        }

        //ACTUALIZACIÓN DE DATOS
        public void UpdateCategory(CategoryEntity oCategory) {

            using( var db = new InventaryContext()) {
                db.Categories.Update(oCategory);    //El mismo sistema se encarga de revisar el Id que trae el objeto, como viene, que es lo que hay que actualizar (tecnicamente hablando)
                db.SaveChanges();
            }
        }
    }
}
