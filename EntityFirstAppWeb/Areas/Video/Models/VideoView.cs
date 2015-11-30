using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFirstAppWeb.Areas.Video.Models
{
    public class VideoView
    {

        public Int64 Id { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        public string Tittle { get; set; }
        public string Genre { get; set; }
        public int RentPrice { get; set; }
        public int Count { get; set; }
        public bool Status { get; set; }

    }
}