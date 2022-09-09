using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lune.VR360
{
    public class ScreenManager : MonoBehaviour
    {
        public GameObject panel1;
        public GameObject panel2;
        public GameObject panel3;
        public GameObject panel4;
        public GameObject panel5;
        public GameObject panel6;
        public GameObject panel7;
        // Start is called before the first frame update
        void Start()
        {

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
                panel1.SetActive(false);
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
                panel2.SetActive(false);
            }

        }
        public void AboutTheApp(bool ActiveStatus)
        {
            if (ActiveStatus)
            {
                panel3.SetActive(true);
            }
            else
            {
                panel3.SetActive(false);
            }
        }
        public void ControlButtonsDescription(bool ActiveStatus)
        {
            if (ActiveStatus)
            {
                panel4.SetActive(true);
            }
            else
            {
                panel4.SetActive(false);
            }
        }
        public void CitySelection(bool ActiveStatus)
        {
            if (ActiveStatus)
            {
                panel5.SetActive(true);
            }
            else
            {
                panel5.SetActive(false);
            }
        }
        public void PathSelection(bool ActiveStatus)
        {
            if (ActiveStatus)
            {
                panel6.SetActive(true);
            }
            else
            {
                panel6.SetActive(false);
            }
        }
        public void HotspotSelection(bool ActiveStatus)
        {
            if (ActiveStatus)
            {
                panel7.SetActive(true);
            }
            else
            {
                panel7.SetActive(false);
            }
        }

    }
}

