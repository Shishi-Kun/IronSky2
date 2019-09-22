using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TextManager : MonoBehaviour
{
    public GUIText timeText;
    public double timer = 0f;

    void Start()
    {
        timeText.text = "Time: 00:00";
    }

    void Update()
    {
        int min, sek;

        timer += Time.deltaTime;
        min = (int) Math.Round(timer / 60);
        sek = (int) Math.Round(timer % 60);


        GameObject.Find("Time").GetComponent<UnityEngine.UI.Text>().text = "Time: " + new String('0', 2 - min.ToString().Length) + min.ToString() + ":" + new String('0', 2 - sek.ToString().Length) + sek.ToString() ;
    }
}
