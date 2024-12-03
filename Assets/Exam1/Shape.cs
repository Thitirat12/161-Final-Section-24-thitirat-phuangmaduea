using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    protected string shapeName;
    public string ShapeName
    {
        get { return shapeName; }
        set { shapeName = value; }
    }

    public abstract void Init(string name,float area);
    public abstract void CalculateArea(float area);

    public virtual void Resize(string name)
    {
        Debug.Log($"Resizing Shape...");
    }    

    public virtual void Draw(string name)
    {
        Debug.Log($"Drawing....");
    }

}
