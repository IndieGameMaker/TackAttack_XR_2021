using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonCtrl : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(Vector3.right * Time.deltaTime * 20.0f * Input.GetAxis("Mouse ScrollWheel"));
    }
}
