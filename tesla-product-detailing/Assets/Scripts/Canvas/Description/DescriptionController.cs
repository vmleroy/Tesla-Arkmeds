using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DescriptionController : MonoBehaviour
{
    [SerializeField] TMPro.TextMeshProUGUI titleField;
    [SerializeField] TMPro.TextMeshProUGUI descriptionField;
    
    public void ChangeText (string title, string description) {
        titleField.text = title;
        descriptionField.text = description;
    }   
}
