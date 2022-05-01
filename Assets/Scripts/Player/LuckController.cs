using UnityEngine;
using UnityEngine.UI;

public class LuckController : MonoBehaviour
{
    public int todaysLuck;
    public Sprite[] luckImages;
    public Image imageRepresentation;

    public void DrawLuck(){
        todaysLuck = (int)Mathf.Round(Random.Range(0, 5));
        imageRepresentation.sprite = luckImages[todaysLuck];

        switch(todaysLuck)
        {
            case 0:
                //Very bad luck
                break;
            case 1:
                //Bad luck
                break;
            case 2:
                //Neutral luck
                break;
            case 3:
                //Good luck 
                break;
            case 4:
                //Very good luck
                break;
        }
    }
}