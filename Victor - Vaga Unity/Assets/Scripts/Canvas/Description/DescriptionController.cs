using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DescriptionController : MonoBehaviour
{
    [SerializeField] TMPro.TextMeshProUGUI descriptionField;
    public bool active = false;   
    
    public void ChangeText (string text) {
        descriptionField.text = text;
    }
    public void ActivateDescriptionField() {
        gameObject.SetActive(true);
    }
    public void DeactivateDescriptionField() {
        gameObject.SetActive(false);
    }

}
