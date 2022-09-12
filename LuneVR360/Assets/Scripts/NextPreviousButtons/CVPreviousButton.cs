using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Evereal.VRVideoPlayer
{
    public class CVPreviousButton : ButtonBase
    {
        public ExampleScript carouselViewScript;
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
            carouselViewScript.ScrollPrevious();
        }
    }
}
