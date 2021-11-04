using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStateConreoller : MonoBehaviour
{

    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

    }
    IEnumerator StartJump() {

        if (anim.GetBool("isJumping") == false)
        {
            anim.SetBool("isJumping", true);
            yield return new WaitForSeconds(1.2f);
            anim.SetBool("isJumping", false);
        }
        else {
            yield return null;
        }
       
    }
    public void Jump() {
        StartCoroutine(StartJump());
        Debug.Log("Worked Well");
    }

    
}
