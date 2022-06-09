using UnityEngine;

public class ShadowAI : MonoBehaviour
{
    public bool isLightNearby;
    public bool isTriggered;

    public LayerMask layerToSearch;
    LanternController lanternC;

    // Update is called once per frame
    void Update()
    {
        isTriggered = transform.GetChild(1).GetComponent<TriggerController> ().isTriggered;

        if(isTriggered){
            SearchLantern();
        }

        if(isLightNearby){
            Death();
        }
    }

    void Death(){
        Destroy(this.gameObject, 0.5f);   
        lanternC.Counter();
        gameObject.transform.GetChild(1).GetComponent<CircleCollider2D>().enabled = false;
        isLightNearby = false;
    }

    void SearchLantern(){
        Collider2D[] hitLantern = Physics2D.OverlapCircleAll(transform.position, 1, layerToSearch);

        foreach(Collider2D lantern in hitLantern){
            lanternC = lantern.GetComponent<LanternController> ();
            isLightNearby = lanternC.isTurnedOn;          
        }
    }
}
