using System;
using System.ComponentModel.DataAnnotations;

namespace MvcMagnet.Models
{
    public class Magnet
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Life { get; set; }
        public string type { get; set; }
        public string color { get; set; }
        public decimal Price { get; set; }
    }
}
