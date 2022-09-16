using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Evereal.VRVideoPlayer
{
    public class NumberHighlight : ButtonBase
    {
        public Text hotspotNumberText;
        public bool isNumberIncreasing = false;
        private static int hotspotNumber = 0;

        public GameObject numberAnimationContainer;
        [SerializeField] public Animator numberAnimator;
        // Start is called before the first frame update
        void Start()
        {
            numberAnimator = numberAnimationContainer.GetComponent<Animator>();
            //numberAnimator.keepAnimatorControllerStateOnDisable = true;


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
                    hotspotNumberText.text = "Hotspot 1";
                    break;
                case 1:
                    numberAnimator.Play("Number2Highlight");
                    hotspotNumberText.text = "Hotspot 2";
                    break;
                case 2:
                    numberAnimator.Play("Number3Highlight");
                    hotspotNumberText.text = "Hotspot 3";
                    break;
                case 3:
                    numberAnimator.Play("Number4Highlight");
                    hotspotNumberText.text = "Hotspot 4";
                    break;
                case 4:
                    numberAnimator.Play("Number5Highlight");
                    hotspotNumberText.text = "Hotspot 5";
                    break;
                case 5:
                    numberAnimator.Play("Number6Highlight");
                    hotspotNumberText.text = "Hotspot 6";
                    break;
                case 6:
                    numberAnimator.Play("Number7Highlight");
                    hotspotNumberText.text = "Hotspot 7";
                    break;
                case 7:
                    numberAnimator.Play("Number8Highlight");
                    hotspotNumberText.text = "Hotspot 8";
                    break;
                case 8:
                    numberAnimator.Play("Number9Highlight");
                    hotspotNumberText.text = "Hotspot 9";
                    break;
            }
        }

        public void ResetAnimation()
        {

            numberAnimator.Play("Number1Highlight", 1, 0);
            numberAnimator.Play("Number2Highlight", 1, 0);
            numberAnimator.Play("Number3Highlight", 1, 0);
            numberAnimator.Play("Number4Highlight", 1, 0);
            numberAnimator.Play("Number5Highlight", 1, 0);
            numberAnimator.Play("Number6Highlight", 1, 0);
            numberAnimator.Play("Number7Highlight", 1, 0);
            numberAnimator.Play("Number86Highlight", 1, 0);
            numberAnimator.Play("Number9Highlight", 1, 0);
        }
    }
}