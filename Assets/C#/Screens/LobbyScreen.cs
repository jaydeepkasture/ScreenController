using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace Screens
{
    public class LobbyScreen : screen
    {
        public override ScreenName ScreenID => ScreenName.LOBBY;
        [SerializeField] Button settingsBtn, matchmakingBtn, profileBtn;
        public override void Initialize(ScreenController screenController)
        {
            base.Initialize(screenController);
            AddListners();
        }
        void AddListners()
        {
            settingsBtn.onClick.AddListener(()=>screenController.Show(ScreenName.SETTINGS));
            matchmakingBtn.onClick.AddListener(()=>screenController.Show(ScreenName.MATCHMAKING));
             profileBtn.onClick.AddListener(()=>screenController.Show(ScreenName.PROFILE));
        }
        public override void Hide()
        {
            base.Hide();
        }
        public override void Show(object data = null)
        {
            base.Show(data);
            Debug.Log(data.GetType().GetProperty("email"));
            Debug.Log(data.GetType().GetProperty("password"));

        }
        public object GetPropertyValue(object obj, string propertyName)
        {
            foreach (var prop in propertyName.Split('.').Select(s => obj.GetType().GetProperty(s)))
                obj = prop.GetValue(obj, null);

            return obj;
        }
    }

}
