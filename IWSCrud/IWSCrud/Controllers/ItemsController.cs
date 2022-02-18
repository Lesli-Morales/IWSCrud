using IWSCrud.Data;
using IWSCrud.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace IWSCrud.Controllers
{
    public class ItemsController : Controller
    {

        private readonly ApplicationDbContext _context;

        public ItemsController(ApplicationDbContext contex)
        {
            _context = contex;
        }

        public IActionResult Index()
        {
            //Generando lista de archivos disponibles
            IEnumerable<Item> listItems = _context.Item;
            return View(listItems);
        }


        //GET CREAR
        public IActionResult Crear()
        {
            return View();
        }


        //POS CREAR
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Crear(Item item)
        {
            if (ModelState.IsValid){
                _context.Item.Add(item);
                _context.SaveChanges();


                TempData["mensaje"] = "El producto se creo con exito";
                return RedirectToAction("Index");
            }

            return View();
        }


        //GET EDIT
        public IActionResult Editar(int? idItem)
        {
            if (idItem == null || idItem == 0 )
            {
                return NotFound();
            }

            var itemm = _context.Item.Find(idItem);

            if(itemm == null)
            {
                return NotFound();
            }


            return View(itemm);
        }


        //POS EDIT
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Editar(Item item)
        {
            if (ModelState.IsValid)
            {
                _context.Item.Update(item);
                _context.SaveChanges();


                TempData["mensaje"] = "El producto se actualizo con exito";
                return RedirectToAction("Index");
            }

            return View();
        }



        //GET ELIMINAR
        public IActionResult Eliminar(int? idItem)
        {
            if (idItem == null || idItem == 0)
            {
                return NotFound();
            }

            var itemm = _context.Item.Find(idItem);

            if (itemm == null)
            {
                return NotFound();
            }


            return View(itemm);
        }


        //POST EDIT
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EliminarItem(int? idItem)
        {

            var item = _context.Item.Find(idItem);
            if (item == null)
            {
                return NotFound();
            }

            _context.Item.Update(item);
            _context.SaveChanges();
           
            TempData["mensaje"] = "El producto se eliminado con exito";
            return RedirectToAction("Index");
            

        }

    }
}
