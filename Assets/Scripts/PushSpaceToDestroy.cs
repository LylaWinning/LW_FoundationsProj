using UnityEngine;
//This script is to Destory a Game Object using the Spacebar

public class PushSpaceToDestroy : MonoBehaviour
{
   
   public GameObject gameObjectToDestroy;//This is a reference to the game object that we want to destroy

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //Destroy(gameObject);//This destroys the game object the script is attached to

            //Destroy(this);//This destroys the script attached to the game object

            //Destroy(this.gameObject);//This destroys the game object the script is attached to

            Destroy(gameObjectToDestroy);//This destroys the game object that we have a reference to
        }
}
}
