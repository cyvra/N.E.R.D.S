using Godot;
using System;

public partial class Player : CharacterBody2D
{
    [Export]
    private float speed = 200.0f;

    public override void _Ready()
    {
        GD.Print("Primera prueba de movimiento (script funcioanl)");
    }

    public override void _PhysicsProcess(double delta)
    {
        Vector2 direccion = Vector2.Zero;

        if (Input.IsActionPressed("der"))  
        {
            direccion.X += 1; 
        }

        if (Input.IsActionPressed("izq"))
        {
            direccion.X -= 1;
        }

        if (Input.IsActionPressed("aba"))
        {
            direccion.Y += 1;
        }

        if (Input.IsActionPressed("arr"))  
        {
            direccion.Y -= 1;
        }

        direccion = direccion.Normalized();

        Velocity = direccion * speed;

        MoveAndSlide();  
    }
}
