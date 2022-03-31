using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightComponentController : MonoBehaviour
{

    public bool colorActivated = false;
    Color[] RGB;

    void Start() {
        gameObject.GetComponent<Outline>().enabled = false;
    }

    public void ActivateHighlight() {
        colorActivated = true;
        gameObject.GetComponent<Outline>().enabled = true;
    }

    public void DisableHighlight () {
        colorActivated = false;
        gameObject.GetComponent<Outline>().enabled = false;
    }

}
