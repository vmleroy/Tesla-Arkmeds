using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCanvasController : MonoBehaviour
{
    public void ActivateDescriptionField() {
        gameObject.GetComponentInChildren<DescriptionController>().gameObject.SetActive(true);
    }
    public void DeactivateDescriptionField() {
        gameObject.GetComponentInChildren<DescriptionController>().gameObject.SetActive(false);
    }
}
