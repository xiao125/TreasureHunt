public class Point
{
    public int x, y;

    public Point(int x,int y)
    {
        this.x = x;
        this.y = y;
    }


    public new bool Equals(object obj) //C# 方法
    {
        return (obj != null) && (obj is Point) && (((Point)obj).x == x && ((Point)obj).y == y);
    }

}

public class PointData
{
    public Point point; //自身节点
    public double g, h;
    public PointData parent; //父节点

    public PointData(Point point,double g,double h,PointData parent)
    {
        this.point = point;
        this.g = g;
        this.h = h;
        this.parent = parent;
    }

    public double F()
    {
        return g + h;
    }
}
