using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CharlieHarrop
{
    public class EventManager : MonoBehaviour
    {
        public static EventManager current;

        public event Action onButtonTrigger;
        public event Action onButtonTriggerPowerup;

        private void Awake()
        {
            current = this;
        }

        public void ButtonPressTrigger()
        {
            if (onButtonTrigger != null)
            {
                onButtonTrigger();
            }
        }public void ButtonPressTriggerPowerup()
        {
            if (onButtonTriggerPowerup != null)
            {
                onButtonTriggerPowerup();
            }
        }
    }
}

