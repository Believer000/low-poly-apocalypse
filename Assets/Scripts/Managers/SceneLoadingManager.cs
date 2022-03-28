/*
 * author : Kirakosyan Nikita
 * e-mail : nikita.kirakosyan.work@gmail.com
 */
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace BlackMountain.Managers
{
    public sealed class SceneLoadingManager : MonoBehaviour
    {
        [Header("UI")]
        public GameObject loadingWindow = null;
        public Slider loadingProgressBar = null;

        public AsyncOperation Async { get; private set; } = null;

        private void Awake()
        {
            loadingWindow.SetActive(false);

            loadingProgressBar.minValue = 0.0f;
            loadingProgressBar.maxValue = 0.9f;
            loadingProgressBar.value = 0;
        }

        private void Update()
        {
            if (Async == null) return;

            loadingProgressBar.value = Async.progress;
        }

        public void LoadScene(int sceneIndex)
        {
            loadingWindow.SetActive(true);
            Async = SceneManager.LoadSceneAsync(sceneIndex);
        }
    }
}