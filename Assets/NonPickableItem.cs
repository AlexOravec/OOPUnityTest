using UnityEngine;

public class NonPickableItem : Item
{
    public override Color GetColor()
    {
        return Color.red;
    }
}