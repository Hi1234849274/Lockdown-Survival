using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movable : MonoBehaviour
{
public GameObject player;

    void Start() {
        player = GameObject.FindGameObjectWithTag("Player").transform.Find("PickupSpot").gameObject;
    }


    void Update() {
        // Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 pos = player.transform.position;
        pos.z = 0;
        if (Input.GetKey(KeyCode.F) && Vector2.Distance(transform.position, player.transform.position) > 5) {
            transform.position = pos;
        }
    }
}