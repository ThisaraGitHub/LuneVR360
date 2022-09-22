using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Evereal.VRVideoPlayer
{
    public class SceneToggleButton : ButtonBase
    {
        public VoiceoverPlay voiceoverPlay;
        public Fade fade;
        public LoadImageFromExternalStorage loadImageFromExternalStorage;
        public bool isToggle = false;
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
            if (fade)
            {
                StartCoroutine(fade.StartFadeOut());
                StartCoroutine(WaitandSwitch());
            }

        }

        IEnumerator WaitandSwitch()
        {
            voiceoverPlay.StopVoicePlay();
            yield return new WaitForSeconds(2);
            if (isToggle == false)
            {
                //do something
                print("Click 1"); 
                loadImageFromExternalStorage.Switch360ConsequencesImages();
                isToggle = true;
            }
            else if (isToggle == true)
            {
                //do something
                print("Click 2");
                voiceoverPlay.PlayVoicePlay();
                loadImageFromExternalStorage.Switch360Images();
                isToggle = false;
            }
            yield return new WaitForSeconds(1);
            StartCoroutine(fade.StartFadeIn());
        }
    }
}