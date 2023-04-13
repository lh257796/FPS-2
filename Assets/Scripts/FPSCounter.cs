using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSCounter : MonoBehaviour
{
    // Start is called before the first frame update
    public int AvgFrameRate;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float currentFPS = 1 / Time.deltaTime;
        AvgFrameRate = (int)currentFPS;

    }
    public float GetFPS()
    {
        return AvgFrameRate;
    }
}
