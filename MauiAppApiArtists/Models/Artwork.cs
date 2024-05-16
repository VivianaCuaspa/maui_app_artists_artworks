using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppApiArtists.Models
{
    public class Artwork
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string PublicationYear { get; set; }

        public string Technique { get; set; }
        public string Description { get; set; }

        public int ArtistId { get; set; }
    }
}
