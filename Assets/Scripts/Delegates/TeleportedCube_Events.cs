using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportedCube_Events : MonoBehaviour
{
    void Start()
    {
        Events.onTeleport += Spawn;
    }

    public void Spawn(Vector3 pos)
    {
        transform.position = pos;
    }
    private void OnDisable()
    {
        Events.onTeleport -= Spawn;
    }
}
