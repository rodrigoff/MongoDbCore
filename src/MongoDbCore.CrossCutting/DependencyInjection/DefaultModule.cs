using Autofac;

namespace MongoDbCore.CrossCutting.DependencyInjection
{
    public class DefaultModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
        }
    }
}
