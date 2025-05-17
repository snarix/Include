using System;
using Include;
using UnityEngine;
using UnityEngine.UI;

namespace _Source.Test
{
    public class ExtensionsTester : MonoBehaviour
    {
        [SerializeField] private Button _button;
        [SerializeField] private Transform _transform;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
                _transform.Deactivate();
            if (Input.GetKeyDown(KeyCode.S))
                _transform.Activate();
            if (Input.GetKeyDown(KeyCode.D))
                _transform.Destroy();
        }

        private void OnEnable()
        {
            _button.AddListener(Click);
        }

        private void OnDisable()
        {
            _button.RemoveListener(Click);
            //_button.RemoveAllListeners();
        }

        private void Click()
        {
            Debug.Log("Click");
        }
    }
}