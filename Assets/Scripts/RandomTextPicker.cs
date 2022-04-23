using UnityEngine;
using UnityEngine.UI;

public class RandomTextPicker : MonoBehaviour
{   
    public string[] playerDeathTexts;
    public string[] bossDeathTexts;

    [TextArea(2,10)]
    public string talkHint;
    [TextArea(2,10)]
    public string pickupHint;

    public void RandomPick(Text UIText, bool Player){

        if(Player){

            float RanNum = Mathf.Round(Random.Range(0, playerDeathTexts.Length));
            UIText.text = playerDeathTexts[(int)RanNum];
        }   else{

            float RanNum = Mathf.Round(Random.Range(0, bossDeathTexts.Length));
            UIText.text = bossDeathTexts[(int)RanNum];
        }
    }
}
