﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicFall2016.Models
{
    public class Album
    {
        public int AlbumID { get; set; }
        [Required(ErrorMessage = "Title is required!")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Price is required!")]
        [Range(0.01, 100.00,
        ErrorMessage = "Price must be between $0.01 and $100.00.")]
        public decimal Price { get; set; }
        // Foreign key
        public int ArtistID { get; set; }
        // Navigation property
        public Artist Artist { get; set; }
        public int GenreID { get; set; }
        public Genre Genre { get; set; }
        public int Likes { get; set; }
        public List<PlaylistAlbums> Playlists { get; set; }
    }
}
