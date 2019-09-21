using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player; 
    public Vector3 offset;

    void Update()
    {
        //Debug.log(player.position);
    
        transform.position = player.position + offset;
    }
}
