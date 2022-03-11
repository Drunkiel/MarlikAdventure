using UnityEngine;

public class ShadowAI : MonoBehaviour
{
    public bool isLightNearby;
    public bool isTriggered;

    public LayerMask LayerToSearch;

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
        isLightNearby = false;
    }

    void SearchLantern(){
        Collider2D[] hitLantern = Physics2D.OverlapCircleAll(transform.position, 1, LayerToSearch);

        foreach(Collider2D lantern in hitLantern){

            isLightNearby = lantern.GetComponent<LanternController> ().isTurnedOn;          
        }
    }
}
