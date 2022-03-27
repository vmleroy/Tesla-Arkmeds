using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseTargetController : MonoBehaviour
{

    [SerializeField] LayerMask teslaComponentsLayerMask = new LayerMask();
    GameObject lastObjectHit = null;

    void Update() {
        MouseRaycast();
    }

    void MouseRaycast() {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit targetObjectHit, 999f, teslaComponentsLayerMask, QueryTriggerInteraction.Ignore)) {
            transform.position = targetObjectHit.point;
            Debug.Log($"mouse collision: {targetObjectHit.collider.name}\n   name: {targetObjectHit.transform.parent}");            
        }
        SearchTeslaComponentsWithRaycast(targetObjectHit);
    }

    void SearchTeslaComponentsWithRaycast (RaycastHit targetObjectHit) {
        if (targetObjectHit.collider != null) {
            if (lastObjectHit != null) {
                if (lastObjectHit.GetComponent<HighlightComponentController>().colorActivated == true) {
                    lastObjectHit.GetComponent<HighlightComponentController>().DisableHighlight();
                }
            }                           
            lastObjectHit = targetObjectHit.transform.parent.gameObject;
            lastObjectHit.gameObject.GetComponent<HighlightComponentController>().ActivateHighlight();
        } else {
            if (lastObjectHit != null) {
                if (lastObjectHit.GetComponent<HighlightComponentController>().colorActivated == true) {
                    lastObjectHit.GetComponent<HighlightComponentController>().DisableHighlight();
                }
            }
        }
    }

}
