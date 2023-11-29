using System.Collections.Generic;
using static System.Reflection.Metadata.BlobBuilder;
using Libreria2.Data.Models;
using Libreria2.Data.ViewModels;

namespace Libreria2.Data.Models
{
    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Propiedades de navegacion
        public List<Book> Books { get; set; }




    }
}
