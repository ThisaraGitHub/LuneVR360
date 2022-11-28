using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lune.VR360;

namespace Evereal.VRVideoPlayer
{
    public class VRImageSelection : ButtonBase
    {
        public GameObject animatorCanvas;
        private Animator animCanvas;

        public GameObject audioSource;
        public InitialControllerInput initialControllerInput;
        public SceneToggleButton sceneToggleButton;
        public GameObject hotspotSwitchButton;
        public GameObject hotspotLoadManualButton;
        public VoiceoverPlay voiceoverPlay;
        public Fade fade;
        public NumberHighlight numberHighlightNextButton;
        public ScreenManager screenManager;
        public LoadImageFromExternalStorage loadImageFromExternalStorage;
        public GameObject screen7;
        Animator screen7Animator;
        public bool isScreen7Enabled = false;
        // Start is called before the first frame update
        void Start()
        {
            screen7Animator = screen7.GetComponent<Animator>();
            hotspotSwitchButton.SetActive(false);
            hotspotLoadManualButton.SetActive(false);
            animCanvas = animatorCanvas.GetComponent<Animator>();
        }

        // Update is called once per frame
        void Update()
        {

        }

        protected override void OnClick()
        {
            if (fade)
            {
                StartCoroutine(fade.StartFadeOut());
                audioSource.SetActive(false);
                voiceoverPlay.StopVoicePlay();
                StartCoroutine(WaitandFadeIn());
                Screen7ActiveStatus(false);

            }
        }

        public void Load360()
        {
            StartCoroutine(WaitandFadeIn());
        }
        IEnumerator WaitandFadeIn()
        {
            yield return new WaitForSeconds(2);
            isScreen7Enabled = true;
            audioSource.SetActive(true);
            initialControllerInput.is360ImageSwitched = true;
            sceneToggleButton.isToggle = false;
            hotspotSwitchButton.SetActive(false);
            hotspotLoadManualButton.SetActive(true);
            //loadImageFromExternalStorage.Switch360Images();
            loadImageFromExternalStorage.Switch360ConsequencesImages();
            yield return new WaitForSeconds(1);
            StartCoroutine(fade.StartFadeIn());
        }

        public void Screen7ActiveStatus(bool status)
        {
            if (!status)
            {
                //screen7Animator.SetInteger("Anim", 0);
                animCanvas.Play("AllPanaleDisable");
            }
            //else
            //{
            //    //screen7Animator.SetInteger("Anim", 1);
            //    animCanvas.Play("Panel-7-IN");
            //}
        }
    }
}