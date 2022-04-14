namespace Screens
{
    public class PrivacyScreen : screen
    {
        public override ScreenName ScreenID => ScreenName.PRIVACY;
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
        }
    }

}
