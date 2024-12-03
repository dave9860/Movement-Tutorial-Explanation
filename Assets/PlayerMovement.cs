using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private float speed = 20;
    private Vector3 movement = new Vector3(10,20);
    

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float movez = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveX, 0, movez) * speed * Time.deltaTime;
        transform.Translate (movement);

    }


}
