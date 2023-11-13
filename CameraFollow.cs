using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform followTransform;
    public Vector3 offset;
    public float followSpeed=10f;
    public float lookSpeed = 10f;

    private void LookAtTarget()
    {
        Vector3 _lookDirection = followTransform.position - transform.position;
        Quaternion _rot = Quaternion.LookRotation(_lookDirection, Vector3.up);
        transform.rotation = Quaternion.Lerp(transform.rotation, _rot, lookSpeed * Time.deltaTime);
    }
    private void MoveToTarget()
    {
        var _targetPos = followTransform.TransformPoint(offset);
        transform.position = Vector3.Lerp(transform.position, _targetPos, followSpeed * Time.deltaTime);
    }

    private void FixedUpdate()
    {
        LookAtTarget();
        MoveToTarget();
    }

   
}
