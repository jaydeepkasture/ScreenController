using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Screens
{
    public abstract class screen : MonoBehaviour
    {
        protected GameObject screenObj;
        protected ScreenController screenController;
        protected bool isActive;//check the screen if currently active

        [SerializeField] protected Button backBtn;
        public virtual void Initialize(ScreenController screenController)
        {
            this.screenController = screenController;
            screenObj = gameObject;
            backBtn?.onClick.AddListener(Back);
        }

        public abstract ScreenName ScreenID { get; }

        public virtual void Show(object data = null)
        {
            GetComponent<ScreenSlidingAnimation>().Slide();
            ActivateScreen(true);
            SoundManager.instance.playClick();
            transform.SetAsLastSibling();
        }

        public virtual void Back()
        {
            screenController.Back();
            SoundManager.instance.playClick();

        }

        public virtual void Hide()
        {
            ActivateScreen(false);
        }

        public virtual void ActivateScreen(bool state)
        {
            isActive = state;
            screenObj.SetActive(state);

        }

        protected virtual IEnumerator CallFuntionWithDelay(float delay, Action action)
        {
            yield return new WaitForSeconds(delay);
            action();
        }

    }
}