using UnityEngine;
using UnityEngine.UIElements;

public class TransformTranslate : MonoBehaviour
{ 
    public float movementSpeed;

    public float rotationSpeed;
    
      void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.S))

     {
         transform.Translate(0,0,10);
         Debug.Log("S Key Pressed");
     }

     if (Input.GetKeyDown(KeyCode.W))

     {
         transform.Translate(0,0,-10);
         Debug.Log("W Key Pressed");
     }

     if (Input.GetKeyDown(KeyCode.A))

     {
         transform.Translate(-10,0,0);
         Debug.Log("A Key Pressed");
     }

     if (Input.GetKeyDown(KeyCode.D))

     {
         transform.Translate(10,0,0);
         Debug.Log("D Key Pressed");
     }*/

     if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(transform.forward*movementSpeed*Time.deltaTime);
        }

         if (Input.GetKey(KeyCode.W))

     {
         transform.Translate(-transform.forward*movementSpeed*Time.deltaTime);
        
     }

      if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-transform.right*movementSpeed*Time.deltaTime);
        }

         if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(transform.right*movementSpeed*Time.deltaTime);
        }

{if (Input.GetKey(KeyCode.Q))
            {
                transform.Rotate(transform.up*rotationSpeed*Time.deltaTime);
            }
        }

        {if (Input.GetKey(KeyCode.R))
            {
                transform.Rotate((-1)*transform.up*rotationSpeed*Time.deltaTime);
            }
        }
    }
}
        

