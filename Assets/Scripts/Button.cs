using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace CharlieHarrop
{
    public class Button : MonoBehaviour
    {
        [SerializeField] private ButtonTrigger trigger;
        [SerializeField] private GameObject redButton;

        private bool buttonPressed = false;
        void Update()
        {
            IsButtonPressed();
        }

        private void IsButtonPressed()
        {
            if (Input.GetKeyDown(KeyCode.E) && trigger.inTriggerArea)
            {
                Debug.Log("EEEEEEEEEEEEEEEEEEEEEE");
                EventManager.current.ButtonPressTrigger();
                if (buttonPressed == false)
                {
                    redButton.transform.position -= new Vector3(0, 0.1f, 0);
                    buttonPressed = true;
                }
                else
                {
                    redButton.transform.position += new Vector3(0, 0.1f, 0);
                    buttonPressed = false;
                }
            }
        }
    }
}

