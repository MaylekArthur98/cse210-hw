using System.ComponentModel.DataAnnotations;

public class Retangle:Shape{
    private double _length;
    private double _width;

    public Retangle(string color, double length, double width):base(color){
        _length = length;
        _width = width;
    }
    public override double GetArea()
    {
        return _length * _width;
    }
}