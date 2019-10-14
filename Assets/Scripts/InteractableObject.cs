using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    public GameObject partsUI;

    private bool isActive;

    private void OnMouseDown()
    {
        isActive = !isActive;
        partsUI.SetActive(isActive);
    }
}
