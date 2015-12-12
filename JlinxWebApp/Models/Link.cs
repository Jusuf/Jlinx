using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JlinxWebApp.Models
{
    public class Link
    {
        public int Id { get; set; }

        public string LinkDescription { get; set; }

        public string UrlAddress { get; set; }

        public DateTime Created { get; set; }

    }
}