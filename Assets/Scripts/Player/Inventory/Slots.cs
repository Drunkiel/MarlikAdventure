using UnityEngine;

public class Slots : MonoBehaviour
{
    InventoryController inventory;
    public int i;

    void Start() {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<InventoryController>();
    }

    void Update() {
        if(transform.childCount <= 0){
            inventory.isFull[i] = false;
        }
    }

    public void DropItem(){
        foreach (Transform child in transform){
            SpawnItem Spawn = child.GetComponent<SpawnItem>();
            Spawn.SpawnDroppedItem(Spawn.Item);
            GameObject.Destroy(child.gameObject);
        }
    }
}
