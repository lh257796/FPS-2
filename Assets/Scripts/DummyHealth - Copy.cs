using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyHealth : MonoBehaviour
{
    public GameObject damagePopupPrefab;
    // Start is called before the first frame update
    void Start()
    {

    }
    public void TakeDamage(float damage)
    {
        ShowDamagePopup(damage);
    }
    private void ShowDamagePopup(float damage)
    {
        GameObject damagePopupInstance = Instantiate(damagePopupPrefab, transform.position + Vector3.up, Quaternion.identity);
        damagePopupInstance.GetComponent<TextMesh>().text = damage.ToString("F1");
        Destroy(damagePopupInstance, 1f);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
