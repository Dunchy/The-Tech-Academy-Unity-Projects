using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    Cube playerCube;
    // Start is called before the first frame update
    void Start()
    {
        playerCube = FindAnyObjectByType<Cube>();
        playerCube.OutOfBounds();
    }

    // Update is called once per frame
    void Update()
    {

    }
};