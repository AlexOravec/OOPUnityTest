using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ItemBox : MonoBehaviour, IPointerClickHandler
{
    public Item item;
    
    private Image image;
    
    [SerializeField]
    private Text textOfTitle;
    
    private void Awake()
    {
        image = GetComponent<Image>();
    }
    
    public void SetItem(Item item)
    {
        this.item = item;
        SetColorByItemRarity(item);
        textOfTitle.text = item.title;
    }
    
    private void SetColorByItemRarity(Item item)
    {
        image.color = item.GetColor();
        
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (item != null)
        {
            if (item is PickableItem pickableItem)
            {
                pickableItem.Use();
            }
            else
            {
                Debug.Log("This is not a pickable item");
            }
            
            Destroy(this.gameObject);
        }
    }
}
