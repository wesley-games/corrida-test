using UnityEngine;

public class CarEngineController : MonoBehaviour
{

    public float velocity;
    public float maxVelocity = 1f;
    public float torque = 100f;
    public float maxSteerAngle = 45f;
    public WheelCollider wheelFL;
    public WheelCollider wheelFR;
    public Rigidbody rb;

    void FixedUpdate()
    {
        if (Input.GetKey("a"))
        {
            if (wheelFL.steerAngle > -maxSteerAngle)
            {
                wheelFL.steerAngle -= 5;
                wheelFR.steerAngle -= 5;
            }
        }
        if (Input.GetKey("d"))
        {
            if (wheelFL.steerAngle < maxSteerAngle)
            {
                wheelFL.steerAngle += 5;
                wheelFR.steerAngle += 5;
            }
        }
        wheelFL.motorTorque = torque;
        wheelFR.motorTorque = torque;

        velocity = rb.velocity.magnitude;
    }

    void LateUpdate()
    {
        if (rb.velocity.z > maxVelocity)
        {
            rb.velocity = new Vector3(0, 0, maxVelocity);
        }
    }
}
