using Godot;
using System;

public partial class HurtBox : Area2D
{
	[Export]
	public float maxHealth;
	public float health;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		health = maxHealth;
	}

	public void damage(float damage) {
		health = Mathf.Clamp(health-damage,0,maxHealth);
		if (health == 0) GetParent().QueueFree();
	}

	public void heal(float heal) {
		damage(-heal);
	}
}
