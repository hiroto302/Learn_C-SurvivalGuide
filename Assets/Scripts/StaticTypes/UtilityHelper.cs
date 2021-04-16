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

        public static void ChangeColor(GameObject obj, Color color, bool randomColor = false)
        {
            if(randomColor)
            {
                color = new Color(Random.value, Random.value, Random.value);
            }
            obj.GetComponent<MeshRenderer>().material.color = color;
        }
    }
}
