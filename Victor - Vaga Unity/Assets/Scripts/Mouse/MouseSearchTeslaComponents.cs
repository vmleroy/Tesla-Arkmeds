using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseSearchTeslaComponents : MonoBehaviour
{
    public GameObject SearchTeslaComponentsWithRaycast (RaycastHit targetObjectHit, GameObject lastObjectHit) {
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
        return lastObjectHit;
    }

}
