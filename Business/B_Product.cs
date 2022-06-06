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
        
        //Para el update, que nos pueda retornar el registro con el id que se le manda por parámetro
        public static ProductEntity ProductById(string id) {
            using (var db = new InventaryContext()) {
                return db.Products.Find(id);
                //return db.Products.ToList().LastOrDefault(p => p.ProductId == id);    //Se puede hacer de esta manera pero hay que convertir a ToList lo que lo hace menos optimo
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
