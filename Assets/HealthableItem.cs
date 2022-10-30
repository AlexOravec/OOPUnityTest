using UnityEngine;

public class HealthableItem : PickableItem
{
    public int healthToGive;

    public override void Use()
    {
        base.Use();
        
        Debug.Log(this.title + " heals " + healthToGive + " health");
    }

    public override Color GetColor()
    {
        return Color.green;
    }
}