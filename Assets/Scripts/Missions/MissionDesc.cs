using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MissionDesc : MonoBehaviour
{
    public int id;
    public Image image;
    public int award;
    public string description;

    public Image imageToReplace;
    public TMP_Text awardToReplace;
    public TMP_Text descriptionToReplace;

    //!Now for tests
    public TestMission mission;
    MissionController misController;

    // Start is called before the first frame update
    void Start()
    {
        misController = transform.parent.parent.GetComponent<MissionController> ();
        award = mission.award;
        imageToReplace = image;
        awardToReplace.text = award.ToString();
        descriptionToReplace.text = description;
    }

    void Update()
    {
        OnMouseDown();
    }

    void OnMouseDown(){
        misController.misDesc = GetComponent<MissionDesc> ();
        misController.btn = GetComponent<Button> ();

        if(misController.misDesc != null){
            mission.isMissionActive = true;
        }
    }
}
