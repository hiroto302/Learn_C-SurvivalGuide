using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public int deathCount;
    public Text deathCountText;

    public void OnEnable()
    {
        Player_Delegates.onDeath += UpdateDeathCount;
    }

    public void UpdateDeathCount()
    {
        deathCount++;
        deathCountText.text = "Death Count : " + deathCount.ToString();
    }
}