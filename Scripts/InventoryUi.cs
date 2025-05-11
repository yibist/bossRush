using Godot;
using System;

public partial class InventoryUi : Control
{
	[Export]
	public Node2D owner;
	[Export]
	public TextureRect texture;
	public InventorySlot[] inventorySlots;
	public override void _Ready()
	{
		close();
		if (!owner.HasNode("InventoryManager")) throw new Exception("The owner of this InventoryUi does not have an inventory");
		Inventory inventory = ((InventoryManager)owner.GetNode("InventoryManager")).inventory;
		texture.Texture = inventory.texture;

		inventorySlots = new InventorySlot[(inventory.rows*inventory.colls)];
		
		int x = inventory.vEdge;
		int y = inventory.hEdge;
            InventorySlot inventorySlot = new InventorySlot
            {
                Position = new Vector2(0, 0)
            };
			inventorySlot.Visible=true;
            this.AddChild(inventorySlot);

		for (int i = 0; i < inventorySlots.Length; i++) {
             inventorySlot = new InventorySlot
            {
                Position = new Vector2(x, y)
            };
            this.AddChild(inventorySlot);
			x += inventory.vEdge;

			if (x > inventory.vGap*inventory.colls + inventory.vEdge) {
				x = inventory.vGap;
				y += inventory.hGap;
			}
		}
	}

	public override void _Process(double delta)
	{
		if (Input.IsActionJustPressed("Inventory"))
		{
			if (Visible)
			{
				close();
			}
			else
			{
				open();
			}
		}
	}

	public void close()
	{
		Visible = false;
	}

	public void open()
	{
		Visible = true;
	}
}
