using UnityEngine;

public class Player : MonoBehaviour
{
    public bool throttle => Input.GetKey(KeyCode.Space);

    public float pitchSpeed = 175f, rollSpeed = 150f, yawSpeed = 125f, engineSpeed = 150f;
    private float activePitch, activeRoll, activeYaw;

    private void Start()
    {
        
    }

    private void Update()
    {
        //transform.position = transform.right * 1f;
        if (throttle) {
            transform.position -= transform.right * engineSpeed * Time.deltaTime;

            //Movement
            activePitch = Input.GetAxisRaw("Vertical") * pitchSpeed * Time.deltaTime;
            activeRoll = Input.GetAxisRaw("Horizontal") * rollSpeed * Time.deltaTime;
            activeYaw = Input.GetAxisRaw("Yaw") * yawSpeed * Time.deltaTime;

            transform.Rotate(
                activePitch * pitchSpeed * Time.deltaTime, 
                activeYaw * yawSpeed * Time.deltaTime, 
                -activeRoll * rollSpeed * Time.deltaTime);

        } else {

            transform.position -= transform.right * engineSpeed/3 * Time.deltaTime;

            activePitch = Input.GetAxisRaw("Vertical") * pitchSpeed/3 * Time.deltaTime;
            activeRoll = Input.GetAxisRaw("Horizontal") * rollSpeed/3 * Time.deltaTime;
            activeYaw = Input.GetAxisRaw("Yaw") * yawSpeed/3 * Time.deltaTime;

            transform.Rotate(
                activePitch * pitchSpeed * Time.deltaTime, 
                activeYaw * yawSpeed * Time.deltaTime, 
                -activeRoll * rollSpeed * Time.deltaTime);
        }
    } 
}