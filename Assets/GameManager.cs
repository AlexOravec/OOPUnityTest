using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class GameManager : MonoBehaviour
{
    private Item[] _items;
    
    public GameObject inventoryPanel;
    public GameObject inventorySlot;
    
    public int slotAmount;

    private void Awake()
    {
        for (int i = 0; i < slotAmount; i++)
        {
            Instantiate(inventorySlot, inventoryPanel.transform);
        }
        
    }

    private void Start()
    {
        _items = FindObjectsOfType<Item>();
        foreach (ItemBox itemBox in FindObjectsOfType<ItemBox>())
        {
            itemBox.SetItem(_items[Random.Range(0, _items.Length)]);
        }
    }
}