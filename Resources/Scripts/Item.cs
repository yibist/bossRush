using Godot;

[GlobalClass]
public partial class Item : Resource
{
    [Export]
    public string id;
    [Export]
    public string name;
    [Export]
    public Texture2D texture;
    [Export]
    public int maxStackSize;
    public int currentStack;

}
