using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusList : MonoBehaviour
{
    public Status Luck;
    public Status Strong;

    void Start()
    {
        Luck = new Status("Luck", 1, "運");
        Strong = CreateStatus("Strong", 2, "腕力");
    }

    Status CreateStatus(string name, int id, string description)
    {
        var status = new Status(name, id ,description);
        return status;
    }
}
