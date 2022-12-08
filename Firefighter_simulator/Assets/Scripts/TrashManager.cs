using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashManager : MonoBehaviour
{
    public Animator CanvasAnimator;

    // Start is called before the first frame update
    void Start()
    {
        CanvasAnimator.SetBool("ObjectApproached", false);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            CanvasAnimator.SetBool("ObjectApproached", false);
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
            CanvasAnimator.SetBool("ObjectApproached", true);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
            CanvasAnimator.SetBool("ObjectApproached", false);
    }

}
