using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIDisplay : MonoBehaviour
{
    public Text fpsText;
    private FPSCounter fpsCounter;

    // Start is called before the first frame update
    private void Start()
    {
        fpsCounter = FindObjectOfType<FPSCounter>();
    }

    // Update is called once per frame
    private void Update()
    {
        float currentFPS = fpsCounter.GetFPS();
        fpsText.text = $"FPS: {currentFPS}";
    }
}
