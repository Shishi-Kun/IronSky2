
using UnityEngine;
//using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void StartTheGame()
    {
        Debug.Log("test");
        //SceneManagement.LoadScene("Strecke_2");
        //SceneManager.LoadScene("gameplay");
                 Application.LoadLevel("Strecke_2");


    }

}
