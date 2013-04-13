using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Path
{
    private List<Point3D> pointSequence=new List<Point3D>();
    public void Add(Point3D onePoint)
    {
        pointSequence.Add(onePoint);
    }
    public List<Point3D> ViewPath
    {
        get
        {
            return this.pointSequence;
        }
    }
    public override string ToString()
    {
        StringBuilder sb=new StringBuilder();
        foreach (var point in pointSequence)
	    {
            sb.Append(point.ToString());
            sb.Append(";");
	    }
 	    return sb.ToString();
    }
}

