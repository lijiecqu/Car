using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheel:MonoBehaviour
{
    public bool steer;//代表转向轮
    public bool inverSteer;//是否反向
    public bool power;

    public float steerAngle { get; set; }

    public float Torque { get; set; }

    private WheelCollider wheelCollider;
    private Transform wheelTransform;

    private void Start()
    {
        wheelCollider = GetComponent<WheelCollider>();
        wheelTransform = GetComponentInChildren<MeshRenderer>().transform;
    }

    private void Update()
    {
        wheelCollider.GetWorldPose(out Vector3 pos, out Quaternion rot);
        wheelTransform.position = pos;
        wheelTransform.rotation = rot;
    }

    private void FixedUpdate()
    {
        if (steer) {
            wheelCollider.steerAngle = steerAngle;
        }else if (power)
        {
            wheelCollider.motorTorque = Torque;
        }
    }


}
