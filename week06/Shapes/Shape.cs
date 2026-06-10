using System;

namespace Shapes
{
    abstract class abstractShape
    {
        protected string _color;

        public abstractShape(string color)
        {
            _color = color;
        }
      
        public string GetColor()
        {
            return _color;
        }

        public void SetColor(string color)
        {
            _color = color;
        }


        public abstract double GetArea();
        
     }
}
