using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    public GameObject playerCam;
    public float range = 100f;
    public float damage = 25f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit hit;

        if(Physics.Raycast(playerCam.transform.position, transform.forward, out hit, range))
        {
            EnemieManager enemyManager = hit.transform.GetComponent<EnemieManager>();
            if(enemyManager != null)
            {
                enemyManager.Hit(damage);
            }
        }
    }
}
