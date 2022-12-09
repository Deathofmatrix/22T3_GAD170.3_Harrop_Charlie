using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace CharlieHarrop
{
    public class ButtonTrigger : MonoBehaviour
    {
        [SerializeField] public bool inTriggerArea;
        [SerializeField] private GameObject buttonText;
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                Debug.Log("the collision has been triggered");
                inTriggerArea = true;
                buttonText.SetActive(true);
            }
        }

        private void OnTriggerExit()
        {
            inTriggerArea = false;
            buttonText.SetActive(false);
        }
    }
}

