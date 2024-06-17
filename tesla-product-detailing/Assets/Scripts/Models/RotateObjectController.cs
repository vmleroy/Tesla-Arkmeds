using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObjectController : MonoBehaviour
{

    [SerializeField] float rotationSpeed = 0;

    // If mouse grab object rotation happens while clicked
    void OnMouseDrag() {
        float rotX = Input.GetAxis("Mouse X") * rotationSpeed * Mathf.Deg2Rad;
        float rotY = Input.GetAxis("Mouse Y") * rotationSpeed * Mathf.Deg2Rad;
        Debug.Log($"rotx: {rotX} roty: {rotY}");

        transform.Rotate(Vector3.up, -rotX, Space.World);
        transform.Rotate(Vector3.right, rotY, Space.World);
    }

}
