using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextureTiling : MonoBehaviour
{
    [SerializeField] Material mLavaMaterial; //material to change
    [SerializeField] Slider sShakeSlider; //slider to use

    // Start is called before the first frame update
    void Start()
    {
        sShakeSlider.onValueChanged.AddListener(delegate { OnValueChanged(); });
    }

    /// <summary>
    /// when slider value changed apply the value to the given materials _TextureTiling value
    /// </summary>
    void OnValueChanged()
    {
        mLavaMaterial.SetVector("_TextureTiling", new Vector2(sShakeSlider.value, sShakeSlider.value));
    }
}
