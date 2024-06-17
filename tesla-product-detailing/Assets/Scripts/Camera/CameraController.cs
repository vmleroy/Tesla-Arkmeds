using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraController : MonoBehaviour
{

    [SerializeField] CinemachineVirtualCamera vCam;

    [SerializeField] float zoomSpeed = 150f;
    [SerializeField] float zoomInMax = 26f;
    [SerializeField] float zoomOutMax = 60f;

    void Awake() {
        vCam = GetComponent<CinemachineVirtualCamera>();
    }

    void Update() {
        float zoomIncrement = Input.mouseScrollDelta.y;
        CameraZoom(-zoomIncrement);
    }

    void CameraZoom (float increment) {
        float fov = vCam.m_Lens.FieldOfView;
        float target = Mathf.Clamp(fov+increment, zoomInMax, zoomOutMax);
        vCam.m_Lens.FieldOfView = Mathf.Lerp(fov, target, zoomSpeed*Time.deltaTime);
    }
}
