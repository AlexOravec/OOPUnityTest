using UnityEngine;

public class ManableItem : PickableItem
{
    public int manaToGive;

    public override void Use()
    {
        base.Use();
        Debug.Log(this.title + " gives " + manaToGive + " mana");
    }

    public override Color GetColor()
    {
        return Color.blue;
    }
}