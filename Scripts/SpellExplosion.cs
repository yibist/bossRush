using Godot;
using System;

public partial class SpellExplosion : Area2D
{
	[Export]
	public AnimatedSprite2D sprite;

	[Export]
	public CollisionShape2D collisionShape;


	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		sprite.AnimationFinished += OnAnimationFinished;
	}

	
	

	private void AreaEnteredEventHandler(Area2D area) {
		if (area is not HurtBox) {
			return;
		}
		HurtBox hurtBox = (HurtBox)area;
		hurtBox.damage(2.0f);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (sprite.Frame == 0)
		{
			collisionShape.Disabled = false;
		}
		else
		{
			//collisionShape.Disabled = true;
		}
	}


	private void OnAnimationFinished()
	{
		QueueFree();
	}
}
