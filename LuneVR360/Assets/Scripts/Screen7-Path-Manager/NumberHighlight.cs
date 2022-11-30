using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Evereal.VRVideoPlayer
{
    public class NumberHighlight : ButtonBase
    {
        [Header("Path Selection Reference")]
        public ContentManager screen5ContentManager;
        public ContentManager screen6ContentManager;

        [Header("BadCity Path1 Number Animation Reference")]
        public GameObject numberAnimationContainer;
        [SerializeField] public Animator numberAnimator;

        [Header("BadCity Path2 Number Animation Reference")]
        public GameObject badCityPath2NumberAnimationContainer;
        [SerializeField] public Animator badCityPath2NumberAnimator;

        [Header("BadCity Path3 Number Animation Reference")]
        public GameObject badCityPath3NumberAnimationContainer;
        [SerializeField] public Animator badCityPath3NumberAnimator;

        [Header("Others")]
        public VoiceoverPlay voiceoverPlay;
        public Text hotspotNumberText;
        public bool isNumberIncreasing = false;
        public static int hotspotNumber = 0;
        public Screen7PathManager screen7PathManager;

        // Start is called before the first frame update
        void Start()
        {
            numberAnimator = numberAnimationContainer.GetComponent<Animator>();
            badCityPath2NumberAnimator = badCityPath2NumberAnimationContainer.GetComponent<Animator>();
            badCityPath3NumberAnimator = badCityPath3NumberAnimationContainer.GetComponent<Animator>();
        }

        // Update is called once per frame
        void Update()
        {
            AnimateNumbers();
        }
        protected override void OnClick()
        {
            // Bad Designed City
            if (screen6ContentManager.isBadCityPath1Selected)
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
            if (screen6ContentManager.isBadCityPath2Selected)
            {
                if (isNumberIncreasing)
                {
                    if (hotspotNumber < 3)
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
            if (screen6ContentManager.isBadCityPath3Selected)
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

            voiceoverPlay.DisablePlayVoiceoversRandomly();
        }
        private void AnimateNumbers()
        {
            if (screen6ContentManager.isBadCityPath1Selected)
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
            if (screen6ContentManager.isBadCityPath2Selected)
            {
                switch (hotspotNumber)
                {
                    case 0:
                        badCityPath2NumberAnimator.Play("P2Number1Highlight");
                        hotspotNumberText.text = "Hotspot 1";
                        break;
                    case 1:
                        badCityPath2NumberAnimator.Play("P2Number2Highlight");
                        hotspotNumberText.text = "Hotspot 2";
                        break;
                    case 2:
                        badCityPath2NumberAnimator.Play("P2Number3Highlight");
                        hotspotNumberText.text = "Hotspot 3";
                        break;
                    case 3:
                        badCityPath2NumberAnimator.Play("P2Number4Highlight");
                        hotspotNumberText.text = "Hotspot 4";
                        break;
                }
            }
            if (screen6ContentManager.isBadCityPath3Selected)
            {
                switch (hotspotNumber)
                {
                    case 0:
                        badCityPath3NumberAnimator.Play("P3Number1Highlight");
                        hotspotNumberText.text = "Hotspot 1";
                        break;
                    case 1:
                        badCityPath3NumberAnimator.Play("P3Number2Highlight");
                        hotspotNumberText.text = "Hotspot 2";
                        break;
                    case 2:
                        badCityPath3NumberAnimator.Play("P3Number3Highlight");
                        hotspotNumberText.text = "Hotspot 3";
                        break;
                    case 3:
                        badCityPath3NumberAnimator.Play("P3Number4Highlight");
                        hotspotNumberText.text = "Hotspot 4";
                        break;
                    case 4:
                        badCityPath3NumberAnimator.Play("P3Number5Highlight");
                        hotspotNumberText.text = "Hotspot 5";
                        break;
                    case 5:
                        badCityPath3NumberAnimator.Play("P3Number6Highlight");
                        hotspotNumberText.text = "Hotspot 6";
                        break;
                    case 6:
                        badCityPath3NumberAnimator.Play("P3Number7Highlight");
                        hotspotNumberText.text = "Hotspot 7";
                        break;
                    case 7:
                        badCityPath3NumberAnimator.Play("P3Number8Highlight");
                        hotspotNumberText.text = "Hotspot 8";
                        break;
                    case 8:
                        badCityPath3NumberAnimator.Play("P3Number9Highlight");
                        hotspotNumberText.text = "Hotspot 9";
                        break;
                }
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