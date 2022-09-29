using Lune.VR360;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Evereal.VRVideoPlayer
{
    public class LoadNext360Manual : ButtonBase
    {
        public ScreenManager screenManager;
        public VoiceoverPlay voiceoverPlay;
        public Fade fade;
        //public VRImageSelection vRImageSelection;
        public LoadImageFromExternalStorage loadImageFromExternalStorage;
        public SceneToggleButton sceneToggleButton;
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
                voiceoverPlay.StopVoicePlay();
                StartCoroutine(fade.StartFadeOut());
                StartCoroutine(WaitandLoad());
            }
            screenManager.ClickAudioPlay();

        }

        IEnumerator WaitandLoad()
        {
            yield return new WaitForSeconds(2);
            sceneToggleButton.isToggle = false;
            NumberHighlight.hotspotNumber += 1;
            //vRImageSelection.Load360();
            loadImageFromExternalStorage.Switch360Images();
            //yield return new WaitForSeconds(2);
            StartCoroutine(fade.StartFadeIn());
            //yield return new WaitForSeconds(1);
            //StartCoroutine(fade.StartFadeOut());
        }



    }
}
