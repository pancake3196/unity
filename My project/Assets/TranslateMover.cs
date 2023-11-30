using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslateMover : TransformController
{
    void Update()
    {
        MoveTranslate(new Vector3(0f, 0.1f, 0f));   
    }
}
