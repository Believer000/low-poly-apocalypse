/*
 * author : Kirakosyan Nikita
 * e-mail : nikita.kirakosyan.work@gmail.com
 */
using UnityEngine;

namespace BlackMountain
{
    [RequireComponent(typeof(CameraModel))]
    public sealed class CameraController : MonoBehaviour
    {
        private CameraModel _model = null;
        private CameraView _view = null;

        private void Awake()
        {
            _model = GetComponent<CameraModel>();
            _view = GetComponent<CameraView>();
        }

        private void LateUpdate()
        {
            _view.Follow();
        }
    }
}