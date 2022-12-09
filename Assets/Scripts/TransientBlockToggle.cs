using CharlieHarrop;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CharlieHarrop
{
    public class TransientBlockToggle : MonoBehaviour
    {

        [SerializeField] private Material tangibleMaterial;
        [SerializeField] private Material intangibleMaterial;
        // Start is called before the first frame update
        void Start()
        {
            EventManager.current.onButtonTrigger += OnBlockAppear;
        }

        private void OnBlockAppear()
        {
            if (gameObject.GetComponent<MeshCollider>().enabled == false)
            {
                gameObject.GetComponent<MeshCollider>().enabled = true;

                gameObject.GetComponent<MeshRenderer>().material = tangibleMaterial;
            }
            else
            {
                gameObject.GetComponent<MeshCollider>().enabled = false;

                gameObject.GetComponent<MeshRenderer>().material = intangibleMaterial;
            }
        }
    }
}

