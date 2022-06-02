using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MissionDesc : MonoBehaviour
{
    public int id;
    public Image image;
    public int award;
    public string description;
    public bool isMissionActive;
    public bool isMissionDone;

    public Image imageToReplace;
    public TMP_Text awardToReplace;
    public TMP_Text descriptionToReplace;
    private Button btn;

    MissionController misController;

    // Start is called before the first frame update
    void Start()
    {
        misController = transform.parent.parent.GetComponent<MissionController> ();
        imageToReplace = image;
        awardToReplace.text = award.ToString();
        descriptionToReplace.text = description;
        btn = GetComponent<Button> ();
        btn.onClick.AddListener(misController.AcceptMission);
    }

    void Update()
    {
        if(Input.GetMouseButton(0)){
            MouseDownEvent();
        }
    }

    void MouseDownEvent(){
        if(misController.idOfActiveMission == 0){
            misController.misDesc = GetComponent<MissionDesc> ();
            misController.btn = GetComponent<Button> ();
        }
    }
}
