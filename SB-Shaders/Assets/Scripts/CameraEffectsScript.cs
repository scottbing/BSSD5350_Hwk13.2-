using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Allows us to see shader applied without pressing play 
[ExecuteInEditMode]
public class CameraEffectScript : MonoBehaviour
{
 public Material colorMaterial; 
 public Material waveMaterial; 
 public bool activate = false;

 void OnRenderImage(RenderTexture src, RenderTexture dest)
 {
   if (activate)
   {
     //Applies src to dest after passing through material 
     Graphics.Blit(src, dest, waveMaterial);
   }
   else
   {
     Graphics.Blit(src, dest, colorMaterial);
   }
 }
}
