using Engine.Classes;

namespace Engine
{
    public partial class BMCEngine : Form
    {
        private Vector2 vector2;
        public BMCEngine()
        {
            InitializeComponent();
            vector2 = new Vector2();
            label1.Text = vector2.ToString();
        }
    }
}