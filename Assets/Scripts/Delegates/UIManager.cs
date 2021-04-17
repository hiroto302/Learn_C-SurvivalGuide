using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public int deathCount;
    public Text currnetHealthText;
    public Text deathCountText;

    public void OnEnable()
    {
        Player_Delegates.OnDamageReceived += UpdateHealth;
        Player_Delegates.onDeath += UpdateDeathCount;
    }

    void Start()
    {
        Player_Delegates.OnDamageReceived(Player_Delegates.Health);
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            Player_Delegates.Health--;
            Player_Delegates.OnDamageReceived(Player_Delegates.Health);
        }
    }

    public void UpdateHealth(int health)
    {
        // display updated heath here
        currnetHealthText.text = "Health : " + health.ToString();
    }

    public void UpdateDeathCount()
    {
        deathCount++;
        deathCountText.text = "Death Count : " + deathCount.ToString();
    }
}