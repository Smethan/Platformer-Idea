using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeAtMouse : MonoBehaviour {

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 v3Pos = Input.mousePosition;
            v3Pos.z = 5.12f;
            v3Pos = Camera.main.ScreenToWorldPoint(v3Pos);
            GameObject go = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            go.transform.position = v3Pos;
        }

    }
}
