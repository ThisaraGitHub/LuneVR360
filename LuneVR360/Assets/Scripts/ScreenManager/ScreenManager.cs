using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lune.VR360
{
    public class ScreenManager : MonoBehaviour
    {
        public GameObject panel1;
        public GameObject panel2;
        // Start is called before the first frame update
        void Start()
        {
            ControllerUI(true);
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void ControllerUI(bool ActiveStatus)
        {
            if (ActiveStatus)
            {
                panel1.SetActive(true);
            }
            else
            {
                DisableAllUI();
            }
        }
        public void TittleScreenUI(bool ActiveStatus)
        {
            if (ActiveStatus)
            {
                panel2.SetActive(true);
            }
            else
            {
                DisableAllUI();
            }

        }

        public void DisableAllUI()
        {
            panel1.SetActive(false);
            panel2.SetActive(false);
        }
    }
}

