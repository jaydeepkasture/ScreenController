using UnityEngine;

namespace Screens
{
    public class SplashScreen : screen
    {
        public override ScreenName ScreenID => ScreenName.SPLASH;
        public override void Initialize(ScreenController screenController)
        {
            base.Initialize(screenController);
            AddListners();
        }
        void AddListners()
        {

        }
        public override void Hide()
        {
            base.Hide();
        }
        public override void Show(object data = null)
        {
            base.Show(data);
            LeanTween.alphaCanvas(this.GetComponent<CanvasGroup>(), 1, 1)
            .setOnComplete(() => {screenController.Show(ScreenName.LOGIN); });

        }
    }
}