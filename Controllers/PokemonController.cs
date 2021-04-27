using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using POKEDEX.Models;

namespace POKEDEX.Controllers
{
    public class PokemonController : Controller
    {
        public IActionResult Nuevo(){
            return View();
        }

        [HttpPost]
        public IActionResult Nuevo(Pokemon p){
            if (ModelState.IsValid){
                return  RedirectToAction("Lista");
            }
            return View(p);
        }
        public IActionResult Lista(){
            var pokemones=new List<Pokemon>();
            return View(pokemones);
        }
    }
}