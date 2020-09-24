namespace GeometricFigureHandler
{
    public class Rectangle : Shape2D
    {
        private readonly Vector2 mySize;

        public Rectangle(Vector3 center, Vector2 size)
        {
            Center = new Vector3 {X = center.X, Y = center.Y, Z = 0};
            mySize = size;
        }

        public Rectangle(Vector3 center, float width)
        {
            Center = new Vector3 {X = center.X, Y = center.Y, Z = 0};
            mySize = new Vector2 {X = width, Y = width};
        }

        public override Vector3 Center { get; }
        public override float Area => mySize.X * mySize.Y;
        public override float Circumference => 2 * (mySize.X + mySize.Y);
        public bool IsSquare => mySize.X == mySize.Y;

        public override string ToString()
        {
            return IsSquare
                       ? $"Square @ ({Center.X:N1}, {Center.Y:N1}): w = h = {mySize.Y:N1}"
                       : $"Rectangle @ ({Center.X:N1}, {Center.Y:N1}): w = {mySize.X:N1}, h = {mySize.Y:N1}";
        }
    }
}