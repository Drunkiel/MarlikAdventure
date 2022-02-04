using UnityEngine;

public class LanternController : MonoBehaviour
{
    public GameObject Light;

    public bool isTurnedOn;


    // Start is called before the first frame update
    void Start()
    {
        Light = transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
