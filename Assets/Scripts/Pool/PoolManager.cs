using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    // turn this class into a singleton for easy accessibility
    private static PoolManager _instance;
    public static PoolManager Instance
    {
        get
        {
            if(_instance == null)
                Debug.LogError("The PoolManager is NULL");

            return _instance;
        }
    }

    [SerializeField]
    private GameObject _bulletContainer;
    [SerializeField]
    private GameObject _bulletPrefab;
    [SerializeField]
    private List<GameObject> _bulletPool;

    void Awake()
    {
        _instance = this;
    }

    void Start()
    {
        _bulletPool = GenerateBullets(10);
    }

    // pregenerate a list of bullets using the bullet prefab
    List<GameObject> GenerateBullets(int amountOfBullets)
    {
        for(int i = 0; i < amountOfBullets; i++)
        {
            GameObject bullet = Instantiate(_bulletPrefab);
            bullet.transform.parent = _bulletContainer.transform;
            bullet.SetActive(false);

            _bulletPool.Add(bullet);
        }
        return _bulletPool;
    }

        /*  loop though the bullet list
            checking for in-active bullet
            found one ? set it active and retrun it to the player
            if no bullets available (all are turned on)
            generate x amount of bullets and run the request bullet method */
    public GameObject RequestBullet()
    {
        foreach(var bullet in _bulletPool)
        {
            if(bullet.activeInHierarchy == false)
            {
                bullet.SetActive(true);
                return bullet;
            }
        }

        // if we made it to this point ... we need to generate more bullets
        // need to create a new bullet
        GameObject newBullet = Instantiate(_bulletPrefab);
        newBullet.transform.parent = _bulletContainer.transform;
        _bulletPool.Add(newBullet);
        return newBullet;

        // return null;
    }
}
