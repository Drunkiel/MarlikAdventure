using UnityEngine;

public class LuckController : MonoBehaviour
{
    public int TodaysLuck;

    public void DrawLuck(){
        TodaysLuck = (int)Mathf.Round(Random.Range(1, 4));

        // switch(TodaysLuck)
        // {
        //     case 1:

        //         break;
        //     case 2:

        //         break;
        //     case 3:

        //         break;
        //     case 4:

        //         break;
        // }
    }
}