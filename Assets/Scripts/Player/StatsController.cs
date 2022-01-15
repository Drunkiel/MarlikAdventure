using UnityEngine;
using UnityEngine.UI;

public class StatsController : MonoBehaviour
{
    public float Health;
    private float MaxHealth;
    public int Level;
    public float Experience;
    public float ExpToNextLvl;
    public int Cash;

    // Start is called before the first frame update
    void Start()
    {
        MaxHealth = Health;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
