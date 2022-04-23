using UnityEngine;
using UnityEngine.UI;

public class BuyItem : MonoBehaviour
{
    public GameObject Item;
    public int Cost;
    public Image Image;

    void Start()
    {
        Cost = Item.GetComponent<ItemDesc> ().Cost;   
        Image.sprite = Item.GetComponent<SpriteRenderer> ().sprite;
    }

    public void Buy(){
        int PlayerCash = GameObject.FindGameObjectWithTag("Player").GetComponent<StatsController> ().cash;
        
        if(PlayerCash >= Cost){
            SpawnItem Spawn = GameObject.FindGameObjectWithTag("Shop").GetComponent<SpawnItem> ();
            PlayerCash -= Cost;
            Spawn.SpawnDroppedItem(Item);
        }
    }
}
