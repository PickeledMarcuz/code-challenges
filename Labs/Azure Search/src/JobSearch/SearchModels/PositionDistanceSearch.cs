﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;

namespace JobSearch.SearchModels
{
    public class PositionDistanceSearch
    {
        public Geopoint GeoPoint { get; set; }
        public int Radius { get; set; }
    }
}
