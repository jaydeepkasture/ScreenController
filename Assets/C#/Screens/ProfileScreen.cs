using UnityEngine;
using UnityEngine.UI;

namespace Screens
{
    public class ProfileScreen : screen
    {
        public override ScreenName ScreenID => ScreenName.PROFILE;
        [SerializeField] Button privacyBtn, faqBtn, TandCBtn;
        public override void Initialize(ScreenController screenController)
        {
            base.Initialize(screenController);
            AddListners();
        }
        void AddListners()
        {
            privacyBtn.onClick.AddListener(() => screenController.Show(ScreenName.PRIVACY));
            faqBtn.onClick.AddListener(() => screenController.Show(ScreenName.FAQ));
            TandCBtn.onClick.AddListener(() => screenController.Show(ScreenName.TERMS_AND_CONDITONS));
        }
        public override void Hide()
        {
            base.Hide();
        }
        public override void Show(object data = null)
        {
            base.Show(data);
        }
    }

}
