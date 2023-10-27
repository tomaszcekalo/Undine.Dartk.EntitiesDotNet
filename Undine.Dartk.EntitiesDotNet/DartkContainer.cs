using System;
using System.Collections.Generic;
using System.Text;
using Undine.Core;
using Undine.Core.Struct;

namespace Undine.Dartk.EntitiesDotNet
{
    public class DartkContainer : EcsContainer
    {
        public override void AddSystem<A>(UnifiedSystem<A> system)
        {
            throw new NotImplementedException();
        }

        public override void AddSystem<A, B>(UnifiedSystem<A, B> system)
        {
            throw new NotImplementedException();
        }

        public override void AddSystem<A, B, C>(UnifiedSystem<A, B, C> system)
        {
            throw new NotImplementedException();
        }

        public override void AddSystem<A, B, C, D>(UnifiedSystem<A, B, C, D> system)
        {
            throw new NotImplementedException();
        }

        public override IUnifiedEntity CreateNewEntity()
        {
            throw new NotImplementedException();
        }

        public override ISystem GetSystem<A>(UnifiedSystem<A> system)
        {
            throw new NotImplementedException();
        }

        public override ISystem GetSystem<A, B>(UnifiedSystem<A, B> system)
        {
            throw new NotImplementedException();
        }

        public override ISystem GetSystem<A, B, C>(UnifiedSystem<A, B, C> system)
        {
            throw new NotImplementedException();
        }

        public override ISystem GetSystem<A, B, C, D>(UnifiedSystem<A, B, C, D> system)
        {
            throw new NotImplementedException();
        }

        public override void Run()
        {
            throw new NotImplementedException();
        }
    }
}