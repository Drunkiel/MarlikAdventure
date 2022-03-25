using UnityEngine;

public class ItemsPickup : MonoBehaviour
{
    InventoryController inventory;
    public GameObject itemBtn;
    
    void Start() {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<InventoryController>();
    }

    void OnTriggerStay2D(Collider2D other) {

        if(other.CompareTag("Player") && Input.GetKey(KeyCode.F)) {
            
            for (int i = 0; i < inventory.Slots.Length; i++) {
                if(inventory.isFull[i] == false){
                    
                    inventory.isFull[i] = true;
                    Instantiate(itemBtn, inventory.Slots[i].transform, false);
                    Destroy(gameObject);
                    break;
                }
            }
        }
    }
}

