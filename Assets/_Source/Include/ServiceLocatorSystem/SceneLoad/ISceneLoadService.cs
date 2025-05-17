using System;

namespace Include
{
    public interface ISceneLoadService
    {
        void Load(SceneName sceneName);
        void LoadWithData<T>(SceneName sceneName, T data, Action callback = null);
    }
}