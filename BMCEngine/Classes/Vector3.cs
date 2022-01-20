namespace Engine.Classes
{
    public class Vector3
    {
        public float X;
        public float Y;
        public float Z;

        public Vector3(float x, float y, float z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public Vector3()
        {
            this.X = Zero().X;
            this.Y = Zero().Y;
            this.Z = Zero().Z;
        }

        public Vector3 Zero()
        {
            return new Vector3(0, 0, 0);
        }

        public Vector2 ToVector2()
        {
            return new Vector2(this.X, this.Y);
        }

        public string ToString()
        {
            return "X: " + X.ToString() + ", Y: " + Y.ToString() + ", Z: " + Z.ToString();
        }
    }
}
