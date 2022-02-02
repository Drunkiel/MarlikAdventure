using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthBar : MonoBehaviour
{
    private Slider HealthBar;
    private Image FillBar;

    public Color FullHp, HalfHp, QuartHp;

    EnemyStats stats;
    HealthController contr;

    // Start is called before the first frame update
    void Start()
    {
        contr = GameObject.FindGameObjectWithTag("MainCamera").transform.GetChild(0).GetComponent<HealthController> ();
        stats = this.transform.parent.transform.GetChild(0).GetComponent<EnemyStats> ();
        HealthBar = this.transform.GetChild(0).GetComponent<Slider> ();
        FillBar = this.transform.GetChild(0).GetChild(1).GetChild(0).GetComponent<Image> ();
    }

    void FixedUpdate()
    {
        contr.HeartUpdate();
    }
}
