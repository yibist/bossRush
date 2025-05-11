using Godot;
using System;

public partial class Player : CharacterBody2D
{
	[Export]
	private AnimatedSprite2D playerSprite;
	[Export]

	PackedScene spellExplosion;

	private const float Speed = 300.0f;


	public override void _Ready()
    {
        spellExplosion = GD.Load<PackedScene>("res://Nodes/Spells/SpellExplosion.tscn");
    }

	public override void _PhysicsProcess(double delta)
	{
		Vector2 velocity = Velocity;

		Vector2 direction = Input.GetVector("ui_left", "ui_right", "ui_up", "ui_down");

		if (direction != Vector2.Zero)
		{
			velocity.X = direction.X * Speed;
			velocity.Y = direction.Y * Speed;
			if (direction.X < 0)
			{
				playerSprite.FlipH = false;
			}

			if (direction.X > 0)
			{
				playerSprite.FlipH = true;
			}
		}
		else
		{
			velocity.X = Mathf.MoveToward(Velocity.X, 0, Speed / 2);
			velocity.Y = Mathf.MoveToward(Velocity.Y, 0, Speed / 2);

		}

		Velocity = velocity;
		MoveAndSlide();
	}
	public override void _Process(double delta)
	{
		if (Input.IsActionPressed("LeftMouseButtonClick")) {
			SpellExplosion s = (SpellExplosion)spellExplosion.Instantiate();
			s.Position = GetGlobalMousePosition();
			GetParent().AddChild(s);
		}
	}
}
