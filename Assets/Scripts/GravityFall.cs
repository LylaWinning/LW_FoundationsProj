using UnityEngine;

public class GravityFall: MonoBehaviour

{
void OnSpaceDown()
    {
        gameObject.GetComponent<Rigidbody>().useGravity = true;
}
}
