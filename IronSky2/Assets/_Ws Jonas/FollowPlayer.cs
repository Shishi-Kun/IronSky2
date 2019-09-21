using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject target;

    // Update is called once per frame
    void Update()
    {
        transform.position = target.transform.position + new Vector3(0f, 40f, -40f);
        transform.rotation = target.transform.rotation;
        transform.LookAt(target.transform);
    }
}
