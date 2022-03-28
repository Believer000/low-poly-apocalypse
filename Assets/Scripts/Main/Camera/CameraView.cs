/*
 * author : Kirakosyan Nikita
 * e-mail : nikita.kirakosyan.work@gmail.com
 */
using UnityEngine;

namespace BlackMountain
{
    [RequireComponent(typeof(CameraModel))]
    public sealed class CameraView : MonoBehaviour
    {
        private CameraModel _model = null;

        private void Awake()
        {
            _model = GetComponent<CameraModel>();
        }

        public void Follow()
        {
            transform.position = _model.target.position + _model.offset;
        }
    }
}