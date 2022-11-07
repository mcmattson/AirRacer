using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCamera : MonoBehaviour
{

    public Vector2 turn;
    public float sensitivity = .5f;
    public Vector3 deltaMove;
    public float speed = 1;
    public GameObject mover;
    public Transform target;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;

 void Start()
 {
    Cursor.lockState = CursorLockMode.Locked;
 }   

 void Update()
 {
    turn.x += Input.GetAxis("Mouse X") * sensitivity;
    turn.y += Input.GetAxis("Mouse Y") * sensitivity;
    mover.transform.localRotation = Quaternion.Euler(0,turn.x, 0);
    transform.localRotation = Quaternion.Euler(-turn.y, 0,0);

    deltaMove = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")) * speed * Time.deltaTime;
    mover.transform.Translate(deltaMove);
 }

 private void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothPosition;
    }
}