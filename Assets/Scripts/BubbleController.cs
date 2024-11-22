using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using Unity.VisualScripting;
using UnityEngine;

public class BubbleController : MonoBehaviour
{
    [SerializeField] private Animator BubbleAnimator;


    private void Start()
    {
        //BubbleMaker();
        StartCoroutine(Destroy());
        
        //BubbleAnimator = GetComponent<Animator>();
    }

   
  
    private IEnumerator Destroy()
    {
        yield return new WaitForSeconds(BubbleAnimator.GetCurrentAnimatorStateInfo(0).length); 
            Destroy(gameObject);
        
      
    }
}
