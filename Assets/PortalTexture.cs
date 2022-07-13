using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTexture : MonoBehaviour
{
     public Camera PC2;
	public Camera PC1;
	public Material Camera_A;
	public Material Camera_B;

    void Start(){
    if (PC1.targetTexture != null)
    {
     	  PC1.targetTexture.Release();
    }
	PC1.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
	Camera_B.mainTexture = PC1.targetTexture;
	
	if (PC2.targetTexture != null)
    {
     	  PC2.targetTexture.Release();
    }
	PC2.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
	Camera_A.mainTexture = PC2.targetTexture;
    }
}