using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class Player : MonoBehaviour
    {
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.E)) PlayerInteract();
        }
        public void PlayerInteract()
        {
            var layermask0 = 1 << 0;
            var layermask3 = 1 << 0;
            var finalmask = layermask0 | layermask3;

            RaycastHit hit;
            Ray ray = Camera.main.ViewPointToRay(new Vector(.5f, .5f, 0));

            if (Physics.cast(ray, out hit, 15, finalmask))
            {
                Interact interactScript = hit.transform.GetComponent<Interact>();
                if (interactScript)
                    {
                        interactScript.CallInteract(this);
                    }
            }

        }
    }
