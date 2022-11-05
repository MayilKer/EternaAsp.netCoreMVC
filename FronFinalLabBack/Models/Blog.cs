using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FronFinalLabBack.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }



        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
