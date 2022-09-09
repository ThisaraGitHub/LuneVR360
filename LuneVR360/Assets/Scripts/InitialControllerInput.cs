using Lune.VR360;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lune.VR360
{
    public class InitialControllerInput : MonoBehaviour
    {
        public ScreenManager screenManager;
        // Start is called before the first frame update
        void Start()
        {
            screenManager.ControllerUI(true);
        }

        // Update is called once per frame
        void Update()
        {
            if (OVRInput.Get(OVRInput.Button.One))
            {
                Debug.Log("A button pressed");
                screenManager.ControllerUI(false);
                screenManager.TittleScreenUI(true);
            }
        }
    }
}