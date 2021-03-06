using System;

namespace GeometricFigureHandler
{
    public abstract class Shape
    {
        public abstract Vector3 Center { get; }
        public abstract float Area { get; }
    }
}
