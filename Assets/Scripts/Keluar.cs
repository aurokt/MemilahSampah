using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keluar : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        // Initialization code goes here if needed
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
