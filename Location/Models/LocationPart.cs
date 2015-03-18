using Orchard.ContentManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Trailscout.Location.Models
{
    public class LocationPart : ContentPart
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Postcode { get; set; }
    }
}