using UnityEngine;

public class EDownAnim : MonoBehaviour
{

    Animator animator;

    // This Script is to click to trigger an animation on the object the script is attached to.
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.E))
            animator.SetBool("IsClicked", true);
    }
}

