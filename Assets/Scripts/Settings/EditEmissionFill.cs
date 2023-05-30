using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EditEmissionFill : MonoBehaviour
{
    [SerializeField] List<Material> mLaveMaterial; //materials to update
    [SerializeField] Slider sEmissionFillSlider; //slider to use

    // Start is called before the first frame update
    void Start()
    {
        sEmissionFillSlider.onValueChanged.AddListener(delegate { OnValueChanged(); });
    }

    /// <summary>
    /// when slider value changed apply the value to the given materials _FillPercent value
    /// </summary>
    void OnValueChanged()
    {
        //mLaveMaterial.shader.FindSubshaderTagValue("_Shake_Viscosity") = sShakeSlider.value;
        foreach (Material mat in mLaveMaterial)
        {
            mat.SetFloat("_FillPercent", sEmissionFillSlider.value);
        }

    }
}
