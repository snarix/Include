using System.Collections;
using UnityEngine;

namespace Include
{
    public class MonoBehaviourCoroutineHandler : ICoroutoneHandler
    {
        private MonoBehaviour _monoBehaviour;

        public MonoBehaviourCoroutineHandler(MonoBehaviour monoBehaviour)
        {
            _monoBehaviour = monoBehaviour;
        }

        public Coroutine StartCoroutine(IEnumerator coroutine) => _monoBehaviour.StartCoroutine(coroutine);

        public void StopCoroutine(Coroutine coroutine) => _monoBehaviour.StopCoroutine(coroutine);
    }
}