using UnityEngine;

public class ItemsToSave : MonoBehaviour
{
    DataToSave gameData;
    private GameObject[] invSlots;

    // Start is called before the first frame update
    void Start()
    {
        gameData = GetComponent<DataToSave> ();
        invSlots = GameObject.FindGameObjectsWithTag("Slot");
    }

    public void SaveItems(){
        for (int i = 0; i < invSlots.Length; i++)
        {
            if(invSlots[i].transform.childCount > 0){
                gameData.inventoryItems[i] = invSlots[i].GetComponentInChildren<SpawnItem> ().Item.GetComponent<ItemDesc> ().Id;
            }
        }
    }
}
