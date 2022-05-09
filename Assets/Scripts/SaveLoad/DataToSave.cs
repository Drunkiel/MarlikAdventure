using UnityEngine;

[System.Serializable]
public class DataToSave : MonoBehaviour
{
    public static string[] scenesNames = new string[] {"SampleScene", "City", "PlayerHouse", "ShadowBiom"};
    public Vector2[] playerSavedPosition = new Vector2[scenesNames.Length];
    public int playerCash;
    public float experience;

    public int[] inventoryItems;
}
