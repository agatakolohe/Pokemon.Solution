using Microsoft.AspNetCore.Mvc;
using PokemonDb.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PokemonDb.Controllers
{
    public class PokemonsController : Controller
    {
        // private readonly PokemonDbContext _db; //TODO declares private and readonly field of ProjectNameContext
        // public PokemonsController(PokemonDbContext db)
        // {
        //     _db = db; //allows to set a value for _db to ProjectNameContext due to dependency injection
        // }
        // public ActionResult Index()
        // {
        //     List<Pokemon> model = _db.Pokemons.Include(pokemons => pokemons.PokeType).ToList(); //utlize eager-loading by using Entity's built-in Include(), eager loading means that all information related to an oject should be loaded, for each item in the database include the category it belongs to and then put all the items into a list
        //     return View(model);
        // }

        // public ActionResult Create()
        // {
        //     ViewBag.PokeTypeId = new SelectList(_db.PokeTypes, "PokeTypeId", "Name"); //ViewBag sends temporary data from a controller to a view. SelectList will provide all the categories for a dropdown menu in addtion to setting the selection option value to CategoryId and the select option display name to Name. that way a user can select an Item from the dropdown to associate with the Category in question
        //     return View();
        // }

        // [HttpPost]
        // public ActionResult Create(Pokemon pokemon) //POST request, take var as an argument, add it to the DBSet, and save changes to db, redirects user to Index view
        // {
        //     _db.Pokemons.Add(pokemon); //method we run in DbSet property of our DbContext
        //     _db.SaveChanges(); //method run on DbConect
        //     return RedirectToAction("Index");
        // }

        // public ActionResult Details(int id) //takes the id of the entry we want to view as its sole parameter, need to match the property of the anonymous object we created using the ActionLink()
        // {
        //     Pokemon thisPokemon = _db.Pokemons.FirstOrDefault(pokemons => pokemons.PokemonId == id); //LINQ method that starts by looking at db.Items (items table), finds any items where the ItemId of an item is equal to the id we have passed into this method
        //     return View(thisPokemon);
        // }

        // public ActionResult Edit(int id) //GET, will route to a page with a form for updating an item
        // {
        //     var thisPokemon = _db.Pokemons.FirstOrDefault(pokemons => pokemons.PokemonId == id);
        //     ViewBag.PokeTypeId = new SelectList(_db.Types, "TypeId", "Name");
        //     return View(thisPokemon);
        // }

        // [HttpPost]
        // public ActionResult Edit(Pokemon pokemon) //actually updates the item
        // {
        //     _db.Entry(pokemon).State = EntityState.Modified; //find and update all of the properties of the item we are editing by passing the item (our route parameter) into Entry(). then we need to update its State property to EntityState.Modified. This is so Entity knows that the entry has been modified, as it is not explicitly tracking it(we have not actually retrieved it from the database). once we have marked this specific entrys state as Modified, we can then askk the db to SaveChanges() and then redirect to the Index
        //     _db.SaveChanges();
        //     return RedirectToAction("Index");
        // }

        // public ActionResult Delete(int id)
        // {
        //     var thisPokemon = _db.Pokemons.FirstOrDefault(pokemons => pokemons.PokemonId == id);
        //     return View(this);
        // }

        // [HttpPost, ActionName("Delete")]
        // public ActionResult DeleteConfirmed(int id) //POST action is named DeleteConfirmed both GET and POST action methods for Delete take id as a paramter. C# will not allow to have 2 methods with the same signature. (signature is the method name and parameters. To avoid eerors we call one method Delte and the other DeleteConfirmed. Action name is utilized the proper Delete ction)
        // {
        //     var thisItem = _db.Items.FirstOrDefault(items => items.ItemId == id);
        //     _db.Items.Remove(thisItem); //Remove() built-in method
        //     _db.SaveChanges();
        //     return RedirectToAction("Index");
        // }

    }
}