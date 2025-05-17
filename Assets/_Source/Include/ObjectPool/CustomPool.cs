using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Include
{
    public class CustomPool<T> where T : MonoBehaviour
    {
        private T _prefab;
        private List<T> _objects;

        public CustomPool(T prefab, int prewarmObjects)
        {
            _prefab = prefab;
            _objects = new List<T>();

            for (int i = 0; i < prewarmObjects; i++)
            {
                var obj = Create();
                obj.gameObject.SetActive(false);
            }
        }

        public T Get()
        {
            var obj = _objects.FirstOrDefault(x => !x.gameObject.activeSelf);
            
            if (obj == null)
                obj = Create();
            
            obj.gameObject.SetActive(true);
            return obj;
        }

        public void Release(T obj)
        {
            obj.gameObject.SetActive(false);
        }

        private T Create()
        {
            var obj = GameObject.Instantiate(_prefab);
            _objects.Add(obj);
            return obj;
        }
    }
}