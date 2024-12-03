using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : Shape
{
    private int side;

    public override void CalculateArea(float area)
    {
        Debug.Log($"{ShapeName} side is {side}");
        side = side * side;
        Debug.Log($"{ShapeName} side is {side}");
    }

    public override void Init(string name, float area)
    {
        ShapeName = "Square";
        side = 3;
    }

    public override void Resize(string Name)
    {
        Debug.Log($"Resizing Shape...");
        Debug.Log($"{ShapeName} is resizing...");
    }

    public override void Draw(string name)
    {
        Debug.Log($"Drawing {ShapeName}");
    }

    private void Start()
    {
        Init(ShapeName, side);
        Draw(ShapeName);
        Resize(ShapeName);
        CalculateArea(side);
    }
}
