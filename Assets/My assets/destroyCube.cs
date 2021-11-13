using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyCube : MonoBehaviour
{
    void OnMouseDown()
    {
        Destroy(gameObject);
    }
}
