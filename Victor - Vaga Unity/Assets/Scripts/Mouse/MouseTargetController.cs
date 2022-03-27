using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseTargetController : MonoBehaviour
{

    [SerializeField] LayerMask mouseRayColliderLayerMask = new LayerMask();

    void Update() {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit raycastHit, 999f, mouseRayColliderLayerMask, QueryTriggerInteraction.Ignore)) {
            transform.position = raycastHit.point;
            //Debug.Log($"mouse position: {transform.position}");
            if (raycastHit.collider != null) {
                Debug.Log($"mouse collision: {raycastHit.collider.name}");
            }
        }
    }

}
