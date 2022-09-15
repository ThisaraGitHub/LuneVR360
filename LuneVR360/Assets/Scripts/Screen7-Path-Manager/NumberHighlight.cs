using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Evereal.VRVideoPlayer
{
    public class NumberHighlight : ButtonBase
    {
        public bool isNumberIncreasing = false;
        private static int hotspotNumber = 0;

        public GameObject numberAnimationContainer;
        private Animator numberAnimator;
        // Start is called before the first frame update
        void Start()
        {
            numberAnimator = numberAnimationContainer.GetComponent<Animator>();
        }

        // Update is called once per frame
        void Update()
        {
            AnimateNumbers();
        }
        protected override void OnClick()
        {
            if (isNumberIncreasing)
            {
                if (hotspotNumber < 8)
                {
                    hotspotNumber += 1;
                }
            }
            else if (!isNumberIncreasing)
            {
                if (hotspotNumber > 0)
                {
                    hotspotNumber -= 1;
                }
            }
        }

        private void AnimateNumbers()
        {
            switch (hotspotNumber)
            {
                case 0:
                    numberAnimator.Play("Number1Highlight");
                    break;
                case 1:
                    numberAnimator.Play("Number2Highlight");
                    break;
                case 2:
                    numberAnimator.Play("Number3Highlight");
                    break;
                case 3:
                    numberAnimator.Play("Number4Highlight");
                    break;
                case 4:
                    numberAnimator.Play("Number5Highlight");
                    break;
                case 5:
                    numberAnimator.Play("Number6Highlight");
                    break;
                case 6:
                    numberAnimator.Play("Number7Highlight");
                    break;
                case 7:
                    numberAnimator.Play("Number8Highlight");
                    break;
                case 8:
                    numberAnimator.Play("Number9Highlight");
                    break;
            }
        }
    }
}