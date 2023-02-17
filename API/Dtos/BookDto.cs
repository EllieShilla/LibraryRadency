using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class BookDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Cover { get; set; }   
        public string Content { get; set; }
        public string Genre { get; set; }
        public string Author { get; set; }
    }
}