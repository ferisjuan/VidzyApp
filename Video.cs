﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCourse.Vidzy
{
    enum Clasification : byte
    {
        Silver = 1,
        Gold = 2,
        Platinum = 3
    }
    class Video
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Genre Genre { get; set; }
        public int GenreId { get; set; }
        public Clasification Clasification { get; set; }
    }
}
