using UnityEngine;

public class Item : MonoBehaviour
{
    public string title;

    public virtual Color GetColor()
    {
        return Color.white;
    }
    
}