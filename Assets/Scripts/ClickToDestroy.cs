using UnityEngine;

public class ClickToDestroy : MonoBehaviour
{
   public GameObject clickObjToDestroy;

   void  OnMouseDown()
    {
         Debug.Log("Object was clicked");
         //Debug.LogError("Object was clicked");//this log error will stop play mode in unity
         //Debug.LogWarning("Object was clicked");

         Destroy(clickObjToDestroy);

    }
}
