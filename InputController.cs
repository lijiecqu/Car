using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    public string inputSteerAxis = "Horizontal";// ת����
    public string inputThrottleAxis = "Vertical";//ɲ��������

    public float SteerInput { get; set; }
    public float ThrottleInput { get; set; }

    private void Update()
    {
        SteerInput = Input.GetAxis(inputSteerAxis);
        ThrottleInput = Input.GetAxis(inputThrottleAxis);
    }
}
