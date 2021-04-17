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

    /* イベント関数の検証記述
    void Start()
    {
        Player_Delegates.OnDamageReceived(Player_Delegates.Health);
        // Player_Delegates.onDeath(); Player_Delegates のイベント関数なのでこのクラスでは呼ぶことができない。 イベント関数が作成されたクラスで、そのイベントが発生したことを検知した時、このクラスに対応したメソッド(追加したもの)が実行される。
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            Player_Delegates.Health--;
            Player_Delegates.OnDamageReceived(Player_Delegates.Health);
        }
    }
    */

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