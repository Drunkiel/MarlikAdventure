using UnityEngine;

[System.Serializable]
public class DataToSave : MonoBehaviour
{
    public string[] scenesNames;
    public Vector2[] playerSavedPosition;
    public int playerCash;
    public float experience;

    public int[] inventoryItems;
}
