namespace Screens
{
    public class TermsAndConditionScreen : screen
    {
        public override ScreenName ScreenID => ScreenName.TERMS_AND_CONDITONS;
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
