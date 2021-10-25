using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdCylinder : MonoBehaviour
{
    private GameObject player;
    public float distance = 4f;
    public float speed = 1.5f;
    void Start() {
        player = GameObject.FindGameObjectWithTag("MyCharacter");
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, player.transform.position) < distance) {
            Vector3 moveDir = transform.position - player.transform.position;
            moveDir.y = 0;
            transform.Translate(moveDir.normalized * speed * Time.deltaTime);
        }   
    }
}
