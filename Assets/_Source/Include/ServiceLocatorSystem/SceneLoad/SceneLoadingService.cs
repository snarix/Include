using System;
using UnityEngine.SceneManagement;

namespace Include
{
    public class SceneLoadingService : ISceneLoadService
    {
        public void Load(SceneName sceneName)
        {
            SceneManager.LoadScene(sceneName.ToString());
        }

        public void LoadWithData<T>(SceneName sceneName, T data, Action callback = null)
        {
            ServiceLocator.RemoveService<SceneTransitionData<T>>();
            ServiceLocator.AddService(new SceneTransitionData<T>(data));
            Load(sceneName);
        }
    }

    public class SceneTransitionData<T>
    {
        private T _data;

        public SceneTransitionData(T data)
        {
            _data = data;
        }

        public T Data => _data;
    }
}