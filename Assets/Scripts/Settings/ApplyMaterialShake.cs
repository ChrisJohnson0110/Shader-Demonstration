using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ApplyMaterialShake : MonoBehaviour
{
    [SerializeField] List<Material> mLavaMaterial; //material to change
    [SerializeField] Slider sShakeSlider; //slide to use

    // Start is called before the first frame update
    void Start()
    {
        sShakeSlider.onValueChanged.AddListener(delegate { OnValueChanged(); });
    }

    /// <summary>
    /// when slider value changed apply the value to the given materials _Shake value
    /// </summary>
    void OnValueChanged()
    {
        foreach (Material mat in mLavaMaterial)
        {
            mat.SetVector("_Shake", new Vector2(sShakeSlider.value, sShakeSlider.value));
        }
        
    }
}
