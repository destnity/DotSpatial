﻿using DotSpatial.Projections.ProjectedCategories.UTM.WGS1984;

namespace DotSpatial.Projections.ProjectedSystem
{
    public class Wgs1984
    {
        private NorthernHemisphere _northernHemisphere;
        private SouthernHemisphere _southernHemisphere;

        public NorthernHemisphere NorthernHemisphere => _northernHemisphere ?? (_northernHemisphere = new NorthernHemisphere());
        public SouthernHemisphere SouthernHemisphere => _southernHemisphere ?? (_southernHemisphere = new SouthernHemisphere());
    }
}