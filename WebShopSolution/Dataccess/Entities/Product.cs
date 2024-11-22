using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dataccess.Entities
{
    // Produktmodellen representerar en produkt i webbshoppen
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public bool Discontinued { get; set; }

        //public int CategoryId { get; set; }
        //// Example of navigation property
        //public Category Category { get; set; }
    }
}
