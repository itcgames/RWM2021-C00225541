
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationScript : MonoBehaviour
{
    //rotates object
    void Update()
    {
        transform.Rotate((Vector3.up * 50 * Time.deltaTime), Space.Self);
    }
}
