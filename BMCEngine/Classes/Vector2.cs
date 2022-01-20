namespace Engine.Classes
{
    public class Vector2
    {
        public float X;
        public float Y;

        public Vector2(float x, float y)
        {
            this.X = x;
            this.Y = y;
        }

        public Vector2()
        {
            this.X = Zero().X;
            this.Y = Zero().Y;
        }

        public Vector2 Zero()
        {
            return new Vector2(0, 0);
        }

        public Vector3 ToVector3()
        {
            return new Vector3(this.X, this.Y, 0);
        }

        public Vector3 ToVector3(float Z)
        {
            return new Vector3(this.X, this.Y, Z);
        }

        public string ToString()
        {
            return "X: " + X.ToString() + ", Y: " + Y.ToString();
        }
    }
}
