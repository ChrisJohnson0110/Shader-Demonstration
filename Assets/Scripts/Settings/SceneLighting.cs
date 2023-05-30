using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneLighting : MonoBehaviour
{
    [SerializeField] Light lSceneLight; //light to change
    [SerializeField] Slider sLightingSlider; //slider to use
    
    // Start is called before the first frame update
    void Start()
    {
        sLightingSlider.onValueChanged.AddListener(delegate { OnValueChanged(); });
    }

    /// <summary>
    /// when slider value changed set value to given light intensity
    /// </summary>
    void OnValueChanged()
    {
        lSceneLight.intensity = sLightingSlider.value;
    }
}
