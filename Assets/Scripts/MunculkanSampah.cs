using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MunculkanSampah : MonoBehaviour {
    public float jeda = 0.8f;
    float timer;
    public GameObject[] obyekSampah;

    void Start() {
        // Initialization code goes here if needed
    }

    void Update() {
        timer += Time.deltaTime;
        if (timer > jeda) {
            int random = Random.Range(0, obyekSampah.Length);
            Instantiate(obyekSampah[random], transform.position, transform.rotation);
            timer = 0;
        }
    }
}
