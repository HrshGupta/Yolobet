using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deactivate : MonoBehaviour
{
    public void DeactivateObject()
    {
        this.gameObject.SetActive(false);
    }
}
