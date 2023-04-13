using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    public int BaseDamage;
    public float Damage;
    private FPSCounter fpsCounter;
    // Start is called before the first frame update
    void Start()
    {
        fpsCounter = FindObjectOfType<FPSCounter>();

    }

    // Update is called once per frame
    private void Update()
    {
        float currentFPS = fpsCounter.GetFPS();
        Damage = CalculateDamage(currentFPS);

    }
    private float CalculateDamage(float fps)
    {
        float normalizedFPS = Mathf.Clamp(fps, 1, 300);
        float damageMultiplier = Mathf.Lerp(0.5f, 2.0f, Mathf.InverseLerp(1, 300, normalizedFPS));
        return BaseDamage * damageMultiplier;
    }
}
