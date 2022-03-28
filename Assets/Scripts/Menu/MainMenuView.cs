/*
 * author : Kirakosyan Nikita
 * e-mail : nikita.kirakosyan.work@gmail.com
 */
using UnityEngine;

namespace BlackMountain.MainMenu
{
    public sealed class MainMenuView : MonoBehaviour
    {
        private MainMenuModel _model = null;

        private void Awake()
        {
            _model = GetComponent<MainMenuModel>();
        }

        private void Start()
        {
            _model.versionText.text = Application.version;
        }

        public void ExitGame()
        {
            Application.Quit();
        }
    }
}