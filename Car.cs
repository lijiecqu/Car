using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public Transform centerOfMass;
    public float motortorque = 500f;//Å¤¾Ø
    public float maxSteer = 30f;

    public float steer { get; set; }
    public float Throttle { get; set; }

    private Rigidbody _rigidbody;
    private Wheel[] wheels;

    private void Start()
    {
        wheels = GetComponentsInChildren<Wheel>();
        _rigidbody = GetComponent<Rigidbody>();
        _rigidbody.centerOfMass = centerOfMass.localPosition;
    }

    private void Update()
    {
        steer = GameManager.Instance.inputController.SteerInput;
        Throttle = GameManager.Instance.inputController.ThrottleInput;

        foreach (var wheel in wheels)
        {
            wheel.steerAngle = steer * maxSteer;
            wheel.Torque = Throttle * motortorque;
        }
    }

}
