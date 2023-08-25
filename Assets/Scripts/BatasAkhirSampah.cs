using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BatasAkhirSampah : MonoBehaviour {
	
    // Use this for initialization
    void Start() {
        // Initialization code goes here if needed
    }

    // Update is called once per frame
    void Update() {
        // Update code goes here if needed
    }

    void OnTriggerEnter2D(Collider2D collision) {
        Destroy(collision.gameObject);
        SceneManager.LoadScene("GameOver"); // Baris Ini akan digunakan pada submodul GameOver
    }
}
