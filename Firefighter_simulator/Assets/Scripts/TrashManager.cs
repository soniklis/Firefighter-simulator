using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TrashManager : MonoBehaviour
{
    public Animator CanvasAnimator;

    public bool CanBeDestroyed;

    // Start is called before the first frame update
    void Start()
    {
        CanvasAnimator.SetBool("ObjectApproached", false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("e") && CanBeDestroyed == true)
        {
            CanvasAnimator.SetBool("ObjectApproached", false);
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CanvasAnimator.SetBool("ObjectApproached", true);
            CanBeDestroyed = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CanvasAnimator.SetBool("ObjectApproached", false);
            CanBeDestroyed = false;
        }
    }

}
