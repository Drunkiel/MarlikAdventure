using UnityEngine;

public class SpawnItem : MonoBehaviour
{
    public GameObject Item;

    public void SpawnDroppedItem(GameObject Item) {
        Transform Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>  ();
        Instantiate(Item, Player.position, Quaternion.identity);
    }
}

