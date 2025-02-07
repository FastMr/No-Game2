﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform CameraAxisTransform;

    public float minAngle;
    public float maxAngle;
    public float RotationSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localEulerAngles = new Vector3(0, transform.localEulerAngles.y + RotationSpeed * Input.GetAxis("Mouse X") * Time.deltaTime, 0);
        
        var newAngleX = CameraAxisTransform.localEulerAngles.x - RotationSpeed * Input.GetAxis("Mouse Y") * Time.deltaTime;
        if (newAngleX > 180)
            newAngleX -= 360;

        newAngleX = Mathf.Clamp(newAngleX, minAngle, maxAngle);

        CameraAxisTransform.localEulerAngles = new Vector3(newAngleX, 0, 0);
    }
}