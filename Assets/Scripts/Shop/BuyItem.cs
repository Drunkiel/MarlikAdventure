using UnityEngine;

public class BuyItem : MonoBehaviour
{
    public GameObject Item;
    public int Cost;

    public void Buy(){
        int PlayerCash = GameObject.FindGameObjectWithTag("Player").GetComponent<StatsController> ().Cash;
        
        if(PlayerCash >= Cost){
            SpawnItem Spawn = GameObject.FindGameObjectWithTag("Shop").GetComponent<SpawnItem> ();
            Spawn.SpawnDroppedItem(Item);
        }
    }
}
