using Godot;
using System;

public partial class DropedItem : CharacterBody2D
{

	[Export]
	public float Speed = 300.0f;
	[Export]
	public CollisionShape2D collisionShape2D;
	[Export]
	public Sprite2D sprite2D;
	[Export]
	public Item item;


    public override void _Ready()
    {
		sprite2D.Texture = item.texture;
    }

	public override void _PhysicsProcess(double delta)
	{

	}
}
