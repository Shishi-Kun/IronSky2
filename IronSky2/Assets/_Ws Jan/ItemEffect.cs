using UnityEngine;

public class ItemEffect : MonoBehaviour
{
    float rotSpeed = 60;

    void Start(){
        transform.Rotate(0, 3, 0, Space.World);
        Debug.Log("Start Rotating");
    }

    private void Update() 
    {
        transform.Rotate(0, 3, 0, Space.World);
    }

}
