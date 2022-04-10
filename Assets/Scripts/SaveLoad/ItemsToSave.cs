using UnityEngine;

public class ItemsToSave : MonoBehaviour
{
    public GameObject[] allGameItems;
    private GameObject[] invSlots;
    DataToSave gameData;
    InventoryController invController;

    // Start is called before the first frame update
    void Start()
    {
        gameData = GetComponent<DataToSave> ();
        invController = GameObject.FindGameObjectWithTag("Player").GetComponent<InventoryController> ();
        invSlots = invController.Slots;
    }

    public void SaveItems(){
        for (int i = 0; i < invSlots.Length; i++)
        {
            if(invSlots[i].transform.childCount > 0){
                gameData.inventoryItems[i] = invSlots[i].GetComponentInChildren<SpawnItem> ().Item.GetComponent<ItemDesc> ().Id;
            }
        }
    }

    public void LoadItems(){
        for (int i = 0; i < invSlots.Length; i++)
        {
            if(invSlots[i].transform.childCount > 0){
                Destroy(invSlots[i].transform.GetChild(0).gameObject);
            }

            if(gameData.inventoryItems[i] != 0){
                Instantiate(allGameItems[gameData.inventoryItems[i]], invSlots[i].transform, false);
                invController.isFull[i] = true;
            }
        }
    }
}
