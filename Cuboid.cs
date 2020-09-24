namespace GeometricFigureHandler
{
    public class Cuboid : Shape3D
    {
        private readonly Vector3 mySize;

        public Cuboid(Vector3 center, Vector3 size)
        {
            Center = center;
            mySize = size;
        }

        public Cuboid(Vector3 center, float width)
        {
            Center = center;
            mySize = new Vector3 {X = width, Y = width, Z = width};
        }

        public override Vector3 Center { get; }
        public override float Area => 2 * mySize.X * mySize.Y + 2 * mySize.Y * mySize.Z + 2 * mySize.Z * mySize.X;
        public override float Volume => mySize.X * mySize.Y * mySize.Z;
        public bool IsCube => mySize.X == mySize.Y && mySize.Y == mySize.Z;

        public override string ToString()
        {
            return IsCube
                       ? $"Cube @ ({Center.X:N1}, {Center.Y:N1}, {Center.Z:N1}): h = w = l = {mySize.X:N1}"
                       : $"Cuboid @ ({Center.X:N1}, {Center.Y:N1}, {Center.Z:N1}): h = {mySize.X:N1}, w = {mySize.Y:N1}, l = {mySize.Z:N1}";
        }
    }
}