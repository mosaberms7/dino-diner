using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DinoDiner.Menu;
using System.Collections;


namespace Website.Pages
{
    public class MenueModel : PageModel
    {
        public Menue Menu { get; } = new Menue();
        public IEnumerable<MenuItem> Items;
        public Size Size { get; }
        [BindProperty]
        public string search { get; set; }
        [BindProperty]
        public List<string> menuCategory { get; set; } = new List<string>();
        [BindProperty]
        public float? MinP { get; set; }
        [BindProperty]
        public float? MaxP { get; set; }
        [BindProperty]
        public List<string> Exingri { get; set; } = new List<string>();
        public void OnGet()
        {
            Items = Menu.AvailableMenuItems;
        }
        public void OnPost()
        {
            Items = Menu.AvailableMenuItems;

            if (search != null)
            {
                Items = Menu.AvailableMenuItems.Where(menuItem => menuItem.ToString().Contains(search, StringComparison.OrdinalIgnoreCase));
            }
            if (menuCategory.Count != 0)
            {
                Items = Menu.AvailableMenuItems.Where(menuItem => menuCategory.Contains(menuItem.Category));
            }
            if (MaxP != null)
            {
                Items = Menu.AvailableMenuItems.Where(menuItem => menuItem.Price <= MaxP);
            }
            else if (MinP != null)
            {
                Items = Menu.AvailableMenuItems.Where(menuItem => menuItem.Price >= MinP);
            }
            if (Exingri != null)
            {
                foreach (string s in Exingri)
                {
                    Items = Menu.AvailableMenuItems.Where(menuItem => !menuItem.Ingredients.Contains(s));
                }
            }

        }
    }
}
}