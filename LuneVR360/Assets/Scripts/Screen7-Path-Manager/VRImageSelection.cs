using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lune.VR360;

namespace Evereal.VRVideoPlayer
{
    public class VRImageSelection : ButtonBase
    {
        public NumberHighlight numberHighlightNextButton;
        //public NumberHighlight numberHighlightPreviousButton;
        public ScreenManager screenManager;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        protected override void OnClick()
        {
            screenManager.HotspotSelection(false);
            numberHighlightNextButton.ResetAnimation();
        }
    }
}