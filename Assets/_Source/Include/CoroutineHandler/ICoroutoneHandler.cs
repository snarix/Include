using System.Collections;
using UnityEngine;

namespace Include
{
    public interface ICoroutoneHandler
    {
        Coroutine StartCoroutine(IEnumerator coroutine);
        void StopCoroutine(Coroutine coroutine);
    }
}