/* Copyright (c) 2017-present Evereal. All rights reserved. */

// #define VRVIDEOPLAYER_OCULUS
// #define VRVIDEOPLAYER_STEAMVR

using System;
using UnityEngine;
#if VRVIDEOPLAYER_STEAMVR
using Valve.VR;
#endif

namespace Evereal.VRVideoPlayer
{
    public class VRInput : MonoBehaviour
    {
        public static VRInput singleton;
#if VRVIDEOPLAYER_STEAMVR
    public SteamVR_Action_Boolean GrabGrip = SteamVR_Input.GetAction<SteamVR_Action_Boolean>("default", "GrabGrip");
#endif
        // Called when Fire1 is released and it's not a double click.
        public event Action OnClick;
        // Called when Fire1 is pressed.
        public event Action OnDown;
        // Called when Fire1 is released.
        public event Action OnUp;
        // Called when a double click is detected.
        public event Action OnDoubleClick;
        // Called when Cancel is pressed.
        public event Action OnCancel;
        //The max time allowed between double clicks
        [SerializeField] private float doubleClickTime = 0.3f;

        // The time when Fire1 was last released.
        private float lastMouseUpTime;

        public float DoubleClickTime { get { return doubleClickTime; } }

        private void Awake()
        {
            if (singleton != null)
                return;
            singleton = this;
        }

        private void Update()
        {
            CheckInput();
        }

        private void CheckInput()
        {
            //OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger)
            if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))
            {
                // If anything has subscribed to OnDown call it.
                if (OnDown != null)
                    OnDown();
            }

            // This if statement is to trigger events based on the information gathered before.
            if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))
            {
                // If anything has subscribed to OnUp call it.
                if (OnUp != null)
                    OnUp();

                // If the time between the last release of Fire1 and now is less
                // than the allowed double click time then it's a double click.
                if (Time.time - lastMouseUpTime < doubleClickTime)
                {
                    // If anything has subscribed to OnDoubleClick call it.
                    if (OnDoubleClick != null)
                        OnDoubleClick();
                }
                else
                {
                    // If it's not a double click, it's a single click.
                    // If anything has subscribed to OnClick call it.
                    if (OnClick != null)
                        OnClick();
                }

                // Record the time when Fire1 is released.
                lastMouseUpTime = Time.time;
            }

            // If the Cancel button is pressed and there are subscribers to OnCancel call it.
            if (OVRInput.GetDown(OVRInput.Button.Back))
            {
                if (OnCancel != null)
                    OnCancel();
            }
        }

        private void OnDestroy()
        {
            // Ensure that all events are unsubscribed when this is destroyed.
            OnClick = null;
            OnDoubleClick = null;
            OnDown = null;
            OnUp = null;
        }
    }
}