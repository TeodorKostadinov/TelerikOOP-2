using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

static class PathStorage
{
    public static void SavePath(Path onePath)
    {
        using (StreamWriter writer = new StreamWriter("storage.txt"))
        {
            writer.WriteLine(onePath);
        }
    }
    public static List<Path> LoadPath()
    {
        List<Path> allPaths=new List<Path>();
        
        using (StreamReader reader = new StreamReader("storage.txt"))
        {
            string line=reader.ReadLine();
            while(line!=null)
            {
                Path onePath = new Path();
                string[] onePointCoords=line.Split(';');
                foreach (var point in onePointCoords)
	            {
		            string[] coords=point.Split(',');
                    Point3D aPoint=new Point3D();
                    aPoint.X=double.Parse(coords[0]);
                    aPoint.Y=double.Parse(coords[1]);
                    aPoint.Z=double.Parse(coords[2]);
                    onePath.Add(aPoint);
	            }
                allPaths.Add(onePath);
                line=reader.ReadLine();
            }
        }
        return allPaths;
    }
}

