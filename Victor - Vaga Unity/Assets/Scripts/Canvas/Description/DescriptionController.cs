using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DescriptionController : MonoBehaviour
{
    [SerializeField] TMPro.TextMeshProUGUI descriptionField;
    
    public void ChangeText (string text) {
        descriptionField.text = text;
    }   
}
