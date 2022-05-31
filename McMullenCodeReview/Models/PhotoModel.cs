using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace McMullenCodeReview.Models
{
    public class PhotoModel
    {
        public int AlbumID { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string thumbnailUrl { get; set; }
    }
}
