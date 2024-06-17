using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseController : MonoBehaviour
{
    [SerializeField] LayerMask teslaComponentsLayerMask = new LayerMask();    
    [SerializeField] GameController game;

    GameObject lastComponentHit = null;
    MouseSearchTeslaComponents mSearchComponents;

    void Awake() {
        mSearchComponents = gameObject.GetComponent<MouseSearchTeslaComponents>();
        game = gameObject.GetComponent<GameController>();
    }
    
    void Update() {
        MouseRaycast();
        game.ChangeDescriptionField(lastComponentHit);
    }

    void MouseRaycast() {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit targetObjectHit, 999f, teslaComponentsLayerMask, QueryTriggerInteraction.Ignore)) {
            transform.position = targetObjectHit.point;
            Debug.Log($"mouse collision: {targetObjectHit.collider.name}\n   name: {targetObjectHit.transform.parent}");            
        }
        lastComponentHit = mSearchComponents.SearchTeslaComponentsWithRaycast(targetObjectHit, lastComponentHit);
    }

}
