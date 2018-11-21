using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class Category
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public List<SongCategory> SongCategory { get; set; }

        public Category()
        {

        }
    }
}
