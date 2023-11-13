using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    public string inputSteerAxis = "Horizontal";// 转向轴
    public string inputThrottleAxis = "Vertical";//刹车动力轴

    public float SteerInput { get; set; }
    public float ThrottleInput { get; set; }

    private void Update()
    {
        SteerInput = Input.GetAxis(inputSteerAxis);
        ThrottleInput = Input.GetAxis(inputThrottleAxis);
    }
}
