using System;
using UnityEngine.SceneManagement;

namespace Include
{
    /*public class ZenjectScenesLoadingService : ISceneLoadService
    {
        private ZenjectSceneLoader _loader;

        public ZenjectScenesLoadingService(ZenjectSceneLoader loader)
        {
            _loader = loader;
        }

        public void Load(SceneName sceneName)
        {
            _loader.LoadScene(sceneName.ToString());
        }

        public void LoadWithData<T>(SceneName sceneName, T data, Action callback = null)
        {
            _loader.LoadSceneAsync(sceneName.ToString(), LoadSceneMode.Single, container =>
            {
                container.BindInterfacesAndSelfTo<T>().FromInstance(data).AsSingle();
                //container.Bind<SceneTransitionData<T>>().FromInstance(new SceneTransitionData<T>(data)).AsSingle();
                callback?.Invoke();
            });
        }
    }*/
}