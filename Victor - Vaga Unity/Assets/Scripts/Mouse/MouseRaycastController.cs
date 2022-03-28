using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseRaycastController : MonoBehaviour
{
    [SerializeField] LayerMask teslaComponentsLayerMask = new LayerMask();
    GameObject lastObjectHit = null;

    MouseSearchTeslaComponents mSearchComponents;

    void Awake() {
        mSearchComponents = gameObject.GetComponent<MouseSearchTeslaComponents>();
    }
    
    void Update() {
        MouseRaycast();
    }

    void MouseRaycast() {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit targetObjectHit, 999f, teslaComponentsLayerMask, QueryTriggerInteraction.Ignore)) {
            transform.position = targetObjectHit.point;
            Debug.Log($"mouse collision: {targetObjectHit.collider.name}\n   name: {targetObjectHit.transform.parent}");            
        }
        lastObjectHit = mSearchComponents.SearchTeslaComponentsWithRaycast(targetObjectHit, lastObjectHit);
    }

    

}
