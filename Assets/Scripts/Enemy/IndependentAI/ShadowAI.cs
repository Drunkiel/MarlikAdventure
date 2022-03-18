using UnityEngine;

public class ShadowAI : MonoBehaviour
{
    public bool isLightNearby;
    public bool isTriggered;

    public LayerMask LayerToSearch;
    LanternController Lantern;

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
        Lantern.Counter();
        gameObject.transform.GetChild(1).GetComponent<CircleCollider2D>().enabled = false;
        isLightNearby = false;
    }

    void SearchLantern(){
        Collider2D[] hitLantern = Physics2D.OverlapCircleAll(transform.position, 1, LayerToSearch);

        foreach(Collider2D lantern in hitLantern){

            Lantern = lantern.GetComponent<LanternController> ();
            isLightNearby = Lantern.isTurnedOn;          
        }
    }
}
