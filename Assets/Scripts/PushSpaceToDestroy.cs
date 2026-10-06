using UnityEngine;
//This script is to Destory a Game Object using the Spacebar

public class PushSpaceToDestroy : MonoBehaviour
{
   
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(gameObject);
        }
}
}
