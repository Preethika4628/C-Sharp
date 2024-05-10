using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    public class Box
    {
        private int _length;
        private int _height;
        private int _width;
        public Box()
        {

        }
        public Box(int length, int height, int width)
        {
            _length = length;
            _height = height;
            _width = width;
        }
        public double CalculateVolume()
        {
            return _length * _height * _width;
        }
        public static Box operator+(Box box, Box box1)
        {
            Box box2 = new Box();
            box2._length = box._length + box1._length;
            box2._height = box._height + box1._height;
            box2._width = box._width + box1._width;
            return box2;
        }

    }
}