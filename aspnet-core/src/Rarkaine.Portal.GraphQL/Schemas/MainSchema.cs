using Abp.Dependency;
using GraphQL.Types;
using GraphQL.Utilities;
using Rarkaine.Portal.Queries.Container;
using System;

namespace Rarkaine.Portal.Schemas
{
    public class MainSchema : Schema, ITransientDependency
    {
        public MainSchema(IServiceProvider provider) :
            base(provider)
        {
            Query = provider.GetRequiredService<QueryContainer>();
        }
    }
}