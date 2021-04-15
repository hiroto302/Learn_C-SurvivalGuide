using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crate : MonoBehaviour
{
    [SerializeField]
    GameObject fracturedCrate;
    [SerializeField]
    GameObject explosionEffect;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Instantiate(explosionEffect, transform.position, Quaternion.identity);
            GameObject fracturedCrateObj = Instantiate(fracturedCrate, transform.position, Quaternion.identity);
            // GetComponentsInChildren : 子要素に含む、全てのコンポーネントを取得 (s を忘れずに)
            Rigidbody[] allRigidbodies = fracturedCrateObj.GetComponentsInChildren<Rigidbody>();
            if(allRigidbodies.Length > 0)
            {
                foreach(var body in allRigidbodies)
                {
                    body.AddExplosionForce(500, transform.position, 1);
                }
            }
            Destroy(this.gameObject);
        }
    }
}
