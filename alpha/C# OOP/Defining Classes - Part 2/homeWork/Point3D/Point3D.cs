﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    public struct Point3D
    {
        //Problem 2. Static read-only field

        // Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}.
        // Add a static property to return the point O.

        private static readonly Point3D pointO = new Point3D(0, 0, 0);

        // Problem 1. Structure

        // Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space.
        // Implement the ToString() to enable printing a 3D point.
        public Point3D(double x, double y, double z)
        {
            this.XCoordinates = x;
            this.YCoordinates = y;
            this.ZCoordinates = z;
        }

        public double XCoordinates { get; set; }
        public double YCoordinates { get; set; }
        public double ZCoordinates { get; set; }


        //Problem 2. Static read-only field

        // Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}.
        // Add a static property to return the point O.

        public static Point3D PointO
        {
            get
            {
                return pointO;
            }
        }

        public override string ToString()
        {
            return string.Format("x = {0}, y = {1}, z = {2}", this.XCoordinates, this.YCoordinates, this.ZCoordinates);
        }
    }

}
