using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainCanvasController : MonoBehaviour
{

    [SerializeField] GameObject descriptionMenu;

    public void ActivateDescriptionField() {
        descriptionMenu.SetActive(true);
    }
    public void DeactivateDescriptionField() {
        descriptionMenu.SetActive(false);
    }
}
