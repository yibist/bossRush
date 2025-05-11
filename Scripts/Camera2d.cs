using Godot;
using System;

public partial class Camera2d : Camera2D
{
Vector2 zoomchange = new Vector2(1.1f,1.1f);
public override void _Input(InputEvent @event)
{
if (Input.IsActionPressed("mousewheel_up"))
{
    this.Zoom = this.Zoom * zoomchange;
    // Handle scroll up event
}
else if (Input.IsActionPressed("mousewheel_down"))
{
    this.Zoom = this.Zoom / zoomchange;
    // Handle scroll down event
}
}

}


