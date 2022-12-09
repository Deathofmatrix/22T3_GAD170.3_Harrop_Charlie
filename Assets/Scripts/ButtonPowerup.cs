using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace CharlieHarrop
{
    public class ButtonPowerup : MonoBehaviour
    {
        [SerializeField] private ButtonTrigger trigger;
        [SerializeField] private GameObject redButton;

        private bool buttonPressed = false;
        void Update()
        {
            IsButtonPowerupPressed();
        }

        private void IsButtonPowerupPressed()
        {
            if (Input.GetKeyDown(KeyCode.E) && trigger.inTriggerArea)
            {
                Debug.Log("E pressed");
                EventManager.current.ButtonPressTriggerPowerup();
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

