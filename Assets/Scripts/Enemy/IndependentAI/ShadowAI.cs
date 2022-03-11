using UnityEngine;

public class ShadowAI : MonoBehaviour
{
    public bool isLightNearby;
    public bool isTriggered;

    public LayerMask LayerToSearch;

    // Start is called before the first frame update
    void Start()
    {

    }

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

    void RandomTp(){
        Transform bodyPos = GetComponent<Transform> ();

        float RandomXPos = Mathf.Round(Random.Range(bodyPos.position.x - 5, bodyPos.position.x + 5));
        float RandomYPos = Mathf.Round(Random.Range(bodyPos.position.y - 5, bodyPos.position.y + 5));

        bodyPos.position = new Vector3(RandomXPos, RandomYPos, 0);
        isLightNearby = false;
    }

    void SearchLantern(){
        Collider2D[] hitLantern = Physics2D.OverlapCircleAll(transform.position, 1, LayerToSearch);

        foreach(Collider2D lantern in hitLantern){

            isLightNearby = lantern.GetComponent<LanternController> ().isTurnedOn;          
        }
    }
}
