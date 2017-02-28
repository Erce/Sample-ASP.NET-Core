using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project.Models
{
    public class Photo
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ImgUrl { get; set; }
        public int ProductID { get; set; }

        public Product Product { get; set; }
    }
}
