using GameEngine.ContextLayer.ContextPoolModule.ContextData;
using GameEngine.ContextLayer.ContextPool.Context;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("FakeTestApp")]
namespace GameEngine.ContextLayer.ContextPoolModule.ContextPoolController
{
    internal interface IMainContext
    {
        bool SetUp(IContextDataContainerForSetUp contextdata);
        bool Start();
        bool Pause();
        bool TearDown(out IContextDataContainerForTearDown contextdata);

        T GetModule<T>() where T : IEngineModule;
        object GetApi();//fix
    }
}
