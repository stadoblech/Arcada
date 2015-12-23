using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class CRT : MonoBehaviour
{
    #region Variables
    public Shader curShader;
    public float Distortion = 0.1f;
    public float InputGamma = 2.4f;
    public float OutputGamma = 2.2f;
    public bool On = true;

    [Range(0, 1024f)]
    public float cellSize = 512f;


    private Material curMaterial;

    #endregion

    #region Properties
    Material material
    {
        get
        {
            if (curMaterial == null)
            {
                curMaterial = new Material(curShader);
                curMaterial.hideFlags = HideFlags.HideAndDontSave;
            }
            return curMaterial;
        }
    }
    #endregion
    // Use this for initialization
    void Start()
    {
        if (!SystemInfo.supportsImageEffects)
        {
            enabled = false;
            return;
        }

        if (!On)
        {
            enabled = false;
        }
        else
        {
            enabled = true;
        }
    }

    void OnRenderImage(RenderTexture sourceTexture, RenderTexture destTexture)
    {
        if (curShader != null)
        {
            material.SetFloat("_Distortion", Distortion);
            material.SetFloat("_InputGamma", InputGamma);
            material.SetFloat("_OutputGamma", OutputGamma);
            material.SetVector("_TextureSize", new Vector2(cellSize,cellSize)); // Also change this line in the C# code to make the lines thinner or thicker. From 512 --> 256 makes them thicker. From 512 --> 1024 makes them thinner.

            Graphics.Blit(sourceTexture, destTexture, material);
        }
        else
        {
            Graphics.Blit(sourceTexture, destTexture);
        }


    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnDisable()
    {
        if (curMaterial)
        {
            DestroyImmediate(curMaterial);
        }

    }


}
