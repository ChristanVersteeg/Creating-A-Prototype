using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createPrimitives : MonoBehaviour
{
    [SerializeField] private GameObject steve;
    void Start()
    {
        Instantiate(steve);

    }
}
