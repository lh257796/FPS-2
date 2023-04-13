using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Camera playerCamera;
    public float range = 100f;
    private PlayerDamage playerDamage;
    // Start is called before the first frame update
    void Start()
    {
        playerDamage = GetComponentInParent<PlayerDamage>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Shoot();
        }

    }
    private void Shoot()
    {
        RaycastHit hit;
        if(Physics.Raycast(playerCamera.transform.position, playerCamera.transform.forward, out hit, range))
        {
            DummyHealth dummyHealth = hit.transform.GetComponent<DummyHealth>();
            if (dummyHealth != null)
            {
                dummyHealth.TakeDamage(playerDamage.Damage);
            }
        }
    }
}
