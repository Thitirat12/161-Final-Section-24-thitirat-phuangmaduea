using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Circle : Shape
{
    private float raduis;
    
    public override void CalculateArea(float area)
    {
        Debug.Log($"{ShapeName} raduis is {raduis}");
        raduis = Mathf.PI * raduis * raduis;
        Debug.Log($"{ShapeName} raduis is {raduis}");
    }

    public override void Init(string name, float area)
    {
        ShapeName = "Circle";
        raduis = 5;
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
        Init(ShapeName,raduis);
        Draw(ShapeName);
        Resize(ShapeName);
        CalculateArea(raduis);
    }       
}
    
