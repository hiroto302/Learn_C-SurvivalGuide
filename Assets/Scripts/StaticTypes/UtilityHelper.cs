using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CreateObject
{
    public static class UtilityHelper
    {
        public static void CreateObject()
        {
            // Create a new primitive cube
            GameObject.CreatePrimitive(PrimitiveType.Cube);
        }
        public static void SetPositionZero(GameObject obj)
        {
            obj.transform.position = Vector3.zero;
        }
    }
}
