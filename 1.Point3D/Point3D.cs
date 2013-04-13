using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


struct Point3D
{
    private double x;
    private double y;
    private double z;
    private static readonly Point3D zero = new Point3D(0, 0, 0);
    public double X
    {
        get
        {
            return this.x;
        }
        set
        {
            this.x = value;
        }
    }
    public double Y
    {
        get
        {
            return this.y;
        }
        set
        {
            this.y = value;
        }
    }
    public double Z
    {
        get
        {
            return this.z;
        }
        set
        {
            this.z = value;
        }
    }
    public static Point3D Zero
    {
        get
        {
            return Point3D.zero;
        }
    }
    public Point3D(double x0, double y0, double z0)
    {
        this.x=x0;
        this.y=y0;
        this.z=z0;
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append(this.x.ToString() + ",");
        sb.Append(this.y.ToString() + ",");
        sb.Append(this.z.ToString());
        
        return sb.ToString();
    }
}

