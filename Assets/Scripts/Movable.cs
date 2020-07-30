using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movable : MonoBehaviour
{
private bool isCarrying = false;

public GameObject player;

    void Start() {
        player = GameObject.FindGameObjectWithTag("Player");
    }


    void Update() {
        Vector3 pos = player.transform.position;
        pos.z = 0;
        if (isCarrying) {
            transform.position = pos;
        }
        if (Vector2.Distance(transform.position, player.transform.position) < 5) {
            Debug.Log("Close enough to interact!");
            if (Input.GetKeyDown(KeyCode.F)) {
                if (isCarrying) {
                    isCarrying = false;
                } else {
                    isCarrying = true;
                }
            }
        }
    }
}