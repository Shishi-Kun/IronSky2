
using UnityEngine;
//using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public AudioSource audio;

    public void StartTheGame()
    {
        audio.Play();
        Application.LoadLevel("Strecke_2");
    }

}
