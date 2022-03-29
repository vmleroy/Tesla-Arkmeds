using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    [SerializeField] Canvas mainCanvas;

    public void ChangeDescriptionField(string description) {
        DescriptionController descriptionComponent = mainCanvas.GetComponentInChildren<DescriptionController>();
        descriptionComponent.ChangeText(description);
    }

}
