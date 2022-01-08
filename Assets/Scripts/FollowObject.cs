using UnityEngine;

public class FollowObject : MonoBehaviour
{
    public Transform ObjectToFollow;
    public float TimeSmooth;
    public float heightplus;
    private Vector3 currVelocity;

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = new Vector3(ObjectToFollow.position.x, ObjectToFollow.position.y + heightplus, transform.position.z);
        
        transform.position = Vector3.SmoothDamp(transform.position, newPosition, ref currVelocity, TimeSmooth);
    }
}
