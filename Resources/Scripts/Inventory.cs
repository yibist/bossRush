using Godot;
using System;

[GlobalClass]
public partial class Inventory : Resource
{
    [Export]
    public Item[] items;
    [Export]
    public Texture2D texture;
    [Export]
    public int rows;
    [Export]
    public int colls;
    [Export]
    public int hEdge;
    [Export]
    public int vEdge;
    [Export]
    public int hGap;
    [Export]
    public int vGap;
        
}
