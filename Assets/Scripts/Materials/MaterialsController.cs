using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialsController : MonoBehaviour
{
    //Set these Textures in the Inspector
    public Texture AdobeTexture1;
    public Texture NormalTexture1;

    public Texture AdobeTexture2;
    public Texture NormalTexture2;

    //public Texture AdobeTexture3;
    //public Texture NormalTexture3;

    public Material mat;
  
    public void ChangeTextureMaterial1()
    {
        mat.SetTexture("_MainTex", AdobeTexture1);
        mat.SetTexture("_BumpMap", NormalTexture1);
    }

    public void ChangeTextureMaterial2()
    {
        mat.SetTexture("_MainTex", AdobeTexture2);
        mat.SetTexture("_BumpMap", NormalTexture2);
    }


    //// Use this for initialization
    //void Start()
    //{
    //    //Fetch the Renderer from the GameObject
    //    m_Renderer = GetComponent<Renderer>();

    //    //Make sure to enable the Keywords
    //    m_Renderer.material.EnableKeyword("_NORMALMAP");
    //    m_Renderer.material.EnableKeyword("_METALLICGLOSSMAP");

    //    //Set the Texture you assign in the Inspector as the main texture (Or Albedo)
    //    m_Renderer.material.SetTexture("_MainTex", m_MainTexture);
    //    //Set the Normal map using the Texture you assign in the Inspector
    //    m_Renderer.material.SetTexture("_BumpMap", m_Normal);
    //    //Set the Metallic Texture as a Texture you assign in the Inspector
    //    m_Renderer.material.SetTexture("_MetallicGlossMap", m_Metal);
    //}
}
