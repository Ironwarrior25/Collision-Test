using Godot;
using System;

public partial class pickable : Area2D
{
	
private void _on_body_entered(Node2D body)
{
	// Replace with function body.
	GD.Print("Pickable start overlap.");
	QueueFree();
}


}



