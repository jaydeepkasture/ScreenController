using UnityEngine.UI;
using UnityEngine;
namespace Screens
{
    public class LoginScreen : screen
    {
        public override ScreenName ScreenID => ScreenName.LOGIN;
        [SerializeField] InputField emailField, passwordField;

        string email, password;
        public override void Initialize(ScreenController screenController)
        {
            base.Initialize(screenController);
            AddListners();
        }
       [SerializeField] Button loginBtn;
        void AddListners()
        {
            loginBtn.onClick.AddListener(() =>
            {
                if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
                {
                    Debug.Log("Please Enter Valid Email And Password");
                    return;
                }
                object o=new {email, password};
                screenController.Show(ScreenName.LOBBY,o); }
            );
            emailField.onValueChanged.AddListener((v) => { email = v; });
            passwordField.onValueChanged.AddListener((v) => { password = v; });
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
