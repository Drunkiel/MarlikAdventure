using UnityEngine;

public class ShadowAI : MonoBehaviour
{
    public bool isLightNearby;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        isLightNearby = transform.GetChild(1).GetComponent<TriggerController> ().isTriggered;

        if(isLightNearby){
            RandomTp();
        }
    }

    void RandomTp(){
        Transform bodyPos = GetComponent<Transform> ();

        float RandomXPos = Mathf.Round(Random.Range(bodyPos.position.x - 5, bodyPos.position.x + 5));
        float RandomYPos = Mathf.Round(Random.Range(bodyPos.position.y - 5, bodyPos.position.y + 5));

        bodyPos.position = new Vector3(RandomXPos, RandomYPos, 0);
    }
}
