using Godot;

public partial class player : CharacterBody2D
{
	private float _runSpeed = 350;
	private float _jumpSpeed = -1000;
	private float _gravity = 0;

	private void GetInput()
	{
		var velocity = Velocity;
		velocity.X = 0;
		velocity.Y = 0;

		var right = Input.IsActionPressed("right");
		var left = Input.IsActionPressed("left");
		var up = Input.IsActionPressed("up");
		var down = Input.IsActionPressed("down");
		
		if (right)
			velocity.X += _runSpeed;
		if (left)
			velocity.X -= _runSpeed;
		if (down)
			velocity.Y += _runSpeed;
		if (up)
			velocity.Y -= _runSpeed;
			
		Velocity = velocity;
	}

	public override void _PhysicsProcess(double delta)
	{
		var velocity = Velocity;
		velocity.Y += _gravity * (float)delta;
		Velocity = velocity;
		GetInput();
		MoveAndSlide();
	}
}
