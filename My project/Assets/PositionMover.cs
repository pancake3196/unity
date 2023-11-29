using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionMover : TransformController
{
    void Update()
    {
        MovePosition(new Vector3(0f, 0.1f, 0f));
    }
}
