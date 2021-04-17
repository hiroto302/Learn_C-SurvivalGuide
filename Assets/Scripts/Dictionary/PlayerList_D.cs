using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_D
{
    public int id;
    public string name;
    public Player_D(int id, string name)
    {
        this.id = id;
        this.name = name;
    }
}
public class PlayerList_D : MonoBehaviour
{
    public Dictionary<int, Player_D> playerDictionary = new Dictionary<int, Player_D>();
    void Start()
    {
        Player_D p1 = new Player_D(2, "a");
        Player_D p2 = new Player_D(1, "b");
        Player_D p3 = new Player_D(4, "c");

        playerDictionary.Add(p1.id, p1);
        playerDictionary.Add(p2.id, p2);
        playerDictionary.Add(p3.id, p3);

        Debug.Log(p1.id);
        Debug.Log(playerDictionary[p1.id].name);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            var player = playerDictionary[2];
            Debug.Log(player.name);
        }
    }
}
