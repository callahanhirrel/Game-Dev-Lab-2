using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// References:
//  - https://unity3d.com/learn/tutorials/topics/scripting/spinning-cube

public class RotateTarget : MonoBehaviour
{

    public float rotSpeed;

    // Update is called once per frame
    void Update()
    {
        // Rotation
        transform.Rotate(Vector3.up, rotSpeed * Time.deltaTime);

    }
}
