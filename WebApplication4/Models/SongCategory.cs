using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class SongCategory
    {
        public string SongId { get; set; }
        public string CategoryId { get; set; }
        public Song Song { get; set; }
        public Category Category { get; set; }

        public SongCategory()
        {

        }
    }
}
