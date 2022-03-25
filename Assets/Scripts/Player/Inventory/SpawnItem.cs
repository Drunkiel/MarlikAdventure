using UnityEngine;

public class SpawnItem : MonoBehaviour
{
    public GameObject item;

    public void SpawnDroppedItem() {
        Instantiate(item, new Vector2(0, 0), Quaternion.identity);
    }
}

