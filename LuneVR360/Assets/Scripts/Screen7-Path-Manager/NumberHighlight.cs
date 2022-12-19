using Assets.SimpleLocalization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Evereal.VRVideoPlayer
{
    public class NumberHighlight : ButtonBase
    {

        [Header("Localized Text Reference")]
        public LocalizedText screen7TittleText;
        public LocalizedText screen7DescriptionText;
        public LocalizedText screen7NextButtonText;

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
                        //hotspotNumberText.text = "Hotspot 1";
                        screen7TittleText.LocalizationKey = "Panel7.Hotspot1Tittle";
                        screen7DescriptionText.LocalizationKey = "Panel7.Hotspot1Description";
                        screen7NextButtonText.LocalizationKey = "Panel7.NextButton";

                        screen7TittleText.Localize();
                        screen7DescriptionText.Localize();
                        screen7NextButtonText.Localize();
                        break;
                    case 1:
                        numberAnimator.Play("Number2Highlight");
                        screen7TittleText.LocalizationKey = "Panel7.Hotspot2Tittle";
                        screen7DescriptionText.LocalizationKey = "Panel7.Hotspot2Description";
                        screen7NextButtonText.LocalizationKey = "Panel7.NextButton";

                        screen7TittleText.Localize();
                        screen7DescriptionText.Localize();
                        screen7NextButtonText.Localize();
                        break;
                    case 2:
                        numberAnimator.Play("Number3Highlight");
                        screen7TittleText.LocalizationKey = "Panel7.Hotspot3Tittle";
                        screen7DescriptionText.LocalizationKey = "Panel7.Hotspot3Description";
                        screen7NextButtonText.LocalizationKey = "Panel7.NextButton";

                        screen7TittleText.Localize();
                        screen7DescriptionText.Localize();
                        screen7NextButtonText.Localize();
                        break;
                    case 3:
                        numberAnimator.Play("Number4Highlight");
                        screen7TittleText.LocalizationKey = "Panel7.Hotspot4Tittle";
                        screen7DescriptionText.LocalizationKey = "Panel7.Hotspot4Description";
                        screen7NextButtonText.LocalizationKey = "Panel7.NextButton";

                        screen7TittleText.Localize();
                        screen7DescriptionText.Localize();
                        screen7NextButtonText.Localize();
                        break;
                    case 4:
                        numberAnimator.Play("Number5Highlight");

                        screen7TittleText.LocalizationKey = "Panel7.Hotspot5Tittle";
                        screen7DescriptionText.LocalizationKey = "Panel7.Hotspot5Description";
                        screen7NextButtonText.LocalizationKey = "Panel7.NextButton";

                        screen7TittleText.Localize();
                        screen7DescriptionText.Localize();
                        screen7NextButtonText.Localize();


                        break;
                    case 5:
                        numberAnimator.Play("Number6Highlight");
                        screen7TittleText.LocalizationKey = "Panel7.Hotspot6Tittle";
                        screen7DescriptionText.LocalizationKey = "Panel7.Hotspot6Description";
                        screen7NextButtonText.LocalizationKey = "Panel7.NextButton";

                        screen7TittleText.Localize();
                        screen7DescriptionText.Localize();
                        screen7NextButtonText.Localize();
                        break;
                    case 6:
                        numberAnimator.Play("Number7Highlight");
                        screen7TittleText.LocalizationKey = "Panel7.Hotspot7Tittle";
                        screen7DescriptionText.LocalizationKey = "Panel7.Hotspot7Description";
                        screen7NextButtonText.LocalizationKey = "Panel7.NextButton";

                        screen7TittleText.Localize();
                        screen7DescriptionText.Localize();
                        screen7NextButtonText.Localize();
                        break;
                    case 7:
                        numberAnimator.Play("Number8Highlight");
                        screen7TittleText.LocalizationKey = "Panel7.Hotspot8Tittle";
                        screen7DescriptionText.LocalizationKey = "Panel7.Hotspot8Description";
                        screen7NextButtonText.LocalizationKey = "Panel7.NextButton";

                        screen7TittleText.Localize();
                        screen7DescriptionText.Localize();
                        screen7NextButtonText.Localize();
                        break;
                    case 8:
                        numberAnimator.Play("Number9Highlight");
                        screen7TittleText.LocalizationKey = "Panel7.Hotspot9Tittle";
                        screen7DescriptionText.LocalizationKey = "Panel7.Hotspot9Description";
                        screen7NextButtonText.LocalizationKey = "Panel7.NextButton";

                        screen7TittleText.Localize();
                        screen7DescriptionText.Localize();
                        screen7NextButtonText.Localize();
                        break;
                }
            }
            if (screen6ContentManager.isBadCityPath2Selected)
            {
                switch (hotspotNumber)
                {
                    case 0:
                        badCityPath2NumberAnimator.Play("P2Number1Highlight");
                        screen7TittleText.LocalizationKey = "Panel7.Hotspot1TittleTrack2";
                        screen7DescriptionText.LocalizationKey = "Panel7.Hotspot1DescriptionTrack2";
                        screen7NextButtonText.LocalizationKey = "Panel7.NextButton";

                        screen7TittleText.Localize();
                        screen7DescriptionText.Localize();
                        screen7NextButtonText.Localize();
                        break;
                    case 1:
                        badCityPath2NumberAnimator.Play("P2Number2Highlight");
                        screen7TittleText.LocalizationKey = "Panel7.Hotspot2TittleTrack2";
                        screen7DescriptionText.LocalizationKey = "Panel7.Hotspot2DescriptionTrack2";
                        screen7NextButtonText.LocalizationKey = "Panel7.NextButton";

                        screen7TittleText.Localize();
                        screen7DescriptionText.Localize();
                        screen7NextButtonText.Localize();
                        break;
                    case 2:
                        badCityPath2NumberAnimator.Play("P2Number3Highlight");
                        screen7TittleText.LocalizationKey = "Panel7.Hotspot3TittleTrack2";
                        screen7DescriptionText.LocalizationKey = "Panel7.Hotspot3DescriptionTrack2";
                        screen7NextButtonText.LocalizationKey = "Panel7.NextButton";

                        screen7TittleText.Localize();
                        screen7DescriptionText.Localize();
                        screen7NextButtonText.Localize();
                        break;
                    case 3:
                        badCityPath2NumberAnimator.Play("P2Number4Highlight");
                        screen7TittleText.LocalizationKey = "Panel7.Hotspot4TittleTrack2";
                        screen7DescriptionText.LocalizationKey = "Panel7.Hotspot4DescriptionTrack2";
                        screen7NextButtonText.LocalizationKey = "Panel7.NextButton";

                        screen7TittleText.Localize();
                        screen7DescriptionText.Localize();
                        screen7NextButtonText.Localize();
                        break;
                }
            }
            if (screen6ContentManager.isBadCityPath3Selected)
            {
                switch (hotspotNumber)
                {
                    case 0:
                        badCityPath3NumberAnimator.Play("P3Number1Highlight");
                        screen7TittleText.LocalizationKey = "Panel7.Hotspot1TittleTrack3";
                        screen7DescriptionText.LocalizationKey = "Panel7.Hotspot1DescriptionTrack3";
                        screen7NextButtonText.LocalizationKey = "Panel7.NextButton";

                        screen7TittleText.Localize();
                        screen7DescriptionText.Localize();
                        screen7NextButtonText.Localize();
                        break;
                    case 1:
                        badCityPath3NumberAnimator.Play("P3Number2Highlight");
                        screen7TittleText.LocalizationKey = "Panel7.Hotspot2TittleTrack3";
                        screen7DescriptionText.LocalizationKey = "Panel7.Hotspot2DescriptionTrack3";
                        screen7NextButtonText.LocalizationKey = "Panel7.NextButton";

                        screen7TittleText.Localize();
                        screen7DescriptionText.Localize();
                        screen7NextButtonText.Localize();
                        break;
                    case 2:
                        badCityPath3NumberAnimator.Play("P3Number3Highlight");
                        screen7TittleText.LocalizationKey = "Panel7.Hotspot3TittleTrack3";
                        screen7DescriptionText.LocalizationKey = "Panel7.Hotspot3DescriptionTrack3";
                        screen7NextButtonText.LocalizationKey = "Panel7.NextButton";

                        screen7TittleText.Localize();
                        screen7DescriptionText.Localize();
                        screen7NextButtonText.Localize();
                        break;
                    case 3:
                        badCityPath3NumberAnimator.Play("P3Number4Highlight");
                        screen7TittleText.LocalizationKey = "Panel7.Hotspot4TittleTrack3";
                        screen7DescriptionText.LocalizationKey = "Panel7.Hotspot4DescriptionTrack3";
                        screen7NextButtonText.LocalizationKey = "Panel7.NextButton";

                        screen7TittleText.Localize();
                        screen7DescriptionText.Localize();
                        screen7NextButtonText.Localize();
                        break;
                    case 4:
                        badCityPath3NumberAnimator.Play("P3Number5Highlight");
                        screen7TittleText.LocalizationKey = "Panel7.Hotspot5TittleTrack3";
                        screen7DescriptionText.LocalizationKey = "Panel7.Hotspot5DescriptionTrack3";
                        screen7NextButtonText.LocalizationKey = "Panel7.NextButton";

                        screen7TittleText.Localize();
                        screen7DescriptionText.Localize();
                        screen7NextButtonText.Localize();
                        break;
                    case 5:
                        badCityPath3NumberAnimator.Play("P3Number6Highlight");
                        screen7TittleText.LocalizationKey = "Panel7.Hotspot6TittleTrack3";
                        screen7DescriptionText.LocalizationKey = "Panel7.Hotspot6DescriptionTrack3";
                        screen7NextButtonText.LocalizationKey = "Panel7.NextButton";

                        screen7TittleText.Localize();
                        screen7DescriptionText.Localize();
                        screen7NextButtonText.Localize();
                        break;
                    case 6:
                        badCityPath3NumberAnimator.Play("P3Number7Highlight");
                        screen7TittleText.LocalizationKey = "Panel7.Hotspot7TittleTrack3";
                        screen7DescriptionText.LocalizationKey = "Panel7.Hotspot7DescriptionTrack3";
                        screen7NextButtonText.LocalizationKey = "Panel7.NextButton";

                        screen7TittleText.Localize();
                        screen7DescriptionText.Localize();
                        screen7NextButtonText.Localize();
                        break;
                    case 7:
                        badCityPath3NumberAnimator.Play("P3Number8Highlight");
                        screen7TittleText.LocalizationKey = "Panel7.Hotspot8TittleTrack3";
                        screen7DescriptionText.LocalizationKey = "Panel7.Hotspot8DescriptionTrack3";
                        screen7NextButtonText.LocalizationKey = "Panel7.NextButton";

                        screen7TittleText.Localize();
                        screen7DescriptionText.Localize();
                        screen7NextButtonText.Localize();
                        break;
                    case 8:
                        badCityPath3NumberAnimator.Play("P3Number9Highlight");
                        screen7TittleText.LocalizationKey = "Panel7.Hotspot9TittleTrack3";
                        screen7DescriptionText.LocalizationKey = "Panel7.Hotspot9DescriptionTrack3";
                        screen7NextButtonText.LocalizationKey = "Panel7.NextButton";

                        screen7TittleText.Localize();
                        screen7DescriptionText.Localize();
                        screen7NextButtonText.Localize();
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