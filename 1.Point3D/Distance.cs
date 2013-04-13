using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

static class Distance
{
    static double Calculate(Point3D firstPoint, Point3D secondPoint)
    {
        return Math.Sqrt((firstPoint.X - secondPoint.X) * (firstPoint.X - secondPoint.X) + (firstPoint.Y - secondPoint.Y) * (firstPoint.Y - secondPoint.Y) + (firstPoint.Z - secondPoint.Z) * (firstPoint.Z - secondPoint.Z));

    }
}

