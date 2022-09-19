using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Evereal.VRVideoPlayer
{
    public class LoadNext360Manual : ButtonBase
    {
        public VoiceoverPlay voiceoverPlay;
        public Fade fade;
        public VRImageSelection vRImageSelection;
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

        }

        IEnumerator WaitandLoad()
        {
            yield return new WaitForSeconds(2);
            NumberHighlight.hotspotNumber += 1;
            vRImageSelection.Load360();
            yield return new WaitForSeconds(2);
            StartCoroutine(fade.StartFadeIn());
        }



    }
}
