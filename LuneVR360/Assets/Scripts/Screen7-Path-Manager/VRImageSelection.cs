using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lune.VR360;

namespace Evereal.VRVideoPlayer
{
    public class VRImageSelection : ButtonBase
    {
        public VoiceoverPlay voiceoverPlay;
        public Fade fade;
        public NumberHighlight numberHighlightNextButton;
        public ScreenManager screenManager;
        public LoadImageFromExternalStorage loadImageFromExternalStorage;
        public GameObject screen7;
        Animator screen7Animator;
        // Start is called before the first frame update
        void Start()
        {
            screen7Animator = screen7.GetComponent<Animator>();
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
                voiceoverPlay.StopVoicePlay();
                StartCoroutine(WaitandFadeIn());
                Screen7ActiveStatus(false);
            }
        }

        IEnumerator WaitandFadeIn()
        {
            yield return new WaitForSeconds(2);
            loadImageFromExternalStorage.Switch360Images();
            yield return new WaitForSeconds(1);
            StartCoroutine(fade.StartFadeIn());
        }

        public void Screen7ActiveStatus(bool status)
        {
            if (status)
            {
                screen7Animator.SetInteger("Anim", 0);
            }
            else
            {
                screen7Animator.SetInteger("Anim", 1);
            }
        }
    }
}