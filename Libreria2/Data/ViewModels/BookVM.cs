﻿using System;
using System.Collections.Generic;

namespace Libreria2.Data.ViewModels
{
    public class BookVM
    {
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public bool IsRead { get; set; }
        public DateTime? DataRead { get; set; }
        public int? Rate { get; set; }
        public string Genero { get; set; }
        public string CoverUrl { get; set; }


        public int PublisherID { get; set; }
        public List<int> AuthorIDs { get; set; }


    }

    public class BookWithAuthorsVM
    {
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public bool IsRead { get; set; }
        public DateTime? DataRead { get; set; }
        public int? Rate { get; set; }
        public string Genero { get; set; }
        public string CoverUrl { get; set; }


        public string PublisherName { get; set; }
        public List<string> AuthorNames { get; set; }


    }

}