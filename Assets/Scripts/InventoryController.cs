using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour
{
    [HideInInspector]
    public ItemGrid selectedItemGrid;

    InventoryItem selectedItem;
    RectTransform rectTransform;

    [SerializeField] List<ItemData> items;
    [SerializeField] GameObject itemPrefab;
    [SerializeField] Transform canvasTransform;

    private void Update()
    {
        ItemIconDrag();
        
        // not select any grid now
        if(selectedItemGrid == null) { return; }

        // for test
        if(Input.GetKeyDown(KeyCode.Q))
        {
            CreateRandomItem();
        }

        if(Input.GetMouseButtonDown(0))
        {
            LeftMouseButtonPress();
            
        }
        if(Input.GetMouseButtonUp(0))
        {
            LeftMouseButtonRelease();
            
        }
    }
    private void ItemIconDrag()
    {
        if(selectedItem != null)
            {
                Vector2 position = new Vector2();
                position.x = Input.mousePosition.x-32;
                position.y = Input.mousePosition.y+32;
                rectTransform.position = position;
            }
    }
    private void LeftMouseButtonPress()
    {
        Vector2Int tileGridPosition = selectedItemGrid.GetTileGridPosition(Input.mousePosition);

        if(selectedItem == null)
        {
            PickUpItem(tileGridPosition);
        }
    }
    private void LeftMouseButtonRelease()
    {
        Vector2Int tileGridPosition = selectedItemGrid.GetTileGridPosition(Input.mousePosition);

        if(selectedItem != null)
        {
            PlaceItem(tileGridPosition);
        }
    }
    private void PickUpItem(Vector2Int tileGridPosition)
    {
        selectedItem = selectedItemGrid.PickUpItem(tileGridPosition.x, tileGridPosition.y);
        if(selectedItem != null)
        {
            rectTransform = selectedItem.GetComponent<RectTransform>();
        }
    }
    private void PlaceItem(Vector2Int tileGridPosition)
    {
        selectedItemGrid.PlaceItem(selectedItem, tileGridPosition.x, tileGridPosition.y);
        selectedItem = null;
    }

    private void CreateRandomItem()
    {
        InventoryItem inventoryItem = Instantiate(itemPrefab).GetComponent<InventoryItem>();
        selectedItem = inventoryItem;

        rectTransform = inventoryItem.GetComponent<RectTransform>();
        rectTransform.SetParent(canvasTransform);

        int selectedItemID = UnityEngine.Random.Range(0, items.Count);
        inventoryItem.Set(items[selectedItemID]);
    }
}

