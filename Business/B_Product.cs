using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business {
    public class B_Product {//Será el CRUD

        //LAMADO A DATOS
        public static List<ProductEntity> ProductList() {
            using (var db = new InventaryContext()) { //Se usa Using para abrir y luego cerrar al finalizar la ulima instrucción cierra la conexión
                return db.Products.ToList();
            }
        }

        //CREACIÓN DE DATOS
        public static void CreateProduct(ProductEntity oProduct) {
            using (var db = new InventaryContext()) {
                db.Products.Add(oProduct);
                db.SaveChanges();
            }
        }

        //ACTUALIZACIÓN DE DATOS
        public static void UpdateProduct(ProductEntity oProduct) {

            using (var db = new InventaryContext()) {
                db.Products.Update(oProduct);    //El mismo sistema se encarga de revisar el Id que trae el objeto, como viene, que es lo que hay que actualizar (tecnicamente hablando)
                db.SaveChanges();
            }

        }
    }
}
