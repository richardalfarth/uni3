using OpenTK.Input;
namespace uni3
{
    public class Mouse
    {

        public double x { get; set; }
        public double y { get; set; }
        public bool isLeft { get; set; }

        public Mouse(MouseButtonEventArgs e)
        {
            Camera camera = Camera.Instance();
            this.x = e.Position.X;
            this.y = ((int)camera.ymax) - e.Position.Y;
            this.isLeft = e.Mouse.IsButtonDown(MouseButton.Left);
        }

        public Mouse(MouseMoveEventArgs e)
        {
            Camera camera = Camera.Instance();
            this.x = e.Position.X;
            this.y = ((int)camera.ymax) - e.Position.Y;
            this.isLeft = e.Mouse.IsButtonDown(MouseButton.Left);
        }
    }
}