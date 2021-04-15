using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{
    [SerializeField]
    Transform _target;

    void Update()
    {
        // direction = destination - source;
        Vector3 directionToFace = _target.position - transform.position;
        // Draws a Line SceneView
        Debug.DrawRay(transform.position, directionToFace, Color.green);
        // access our current rotation = Quaternion Look Rotation
        // transform.rotation = Quaternion.LookRotation(directionToFace);
        // make the rotation smooth
        Quaternion targetRotation = Quaternion.LookRotation(directionToFace);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime);

    }
}
