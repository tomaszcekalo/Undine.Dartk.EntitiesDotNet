using EntitiesDotNet;
using System;
using System.Collections.Generic;
using System.Text;
using Undine.Core;
using Undine.Core.Struct;

namespace Undine.Dartk.EntitiesDotNet
{
    public class DartkContainer : EcsContainer
    {
        private EntityManager entityManager = new EntityManager();

        public List<ISystem> Systems { get; private set; } = new List<ISystem>();

        public override void AddSystem<A>(UnifiedSystem<A> system)
        {
            var result = new DartkSystem<A>()
            {
                System = system,
                Entities = entityManager.Entities
            };
            Systems.Add(result);
        }

        public override void AddSystem<A, B>(UnifiedSystem<A, B> system)
        {
            var result = new DartkSystem<A, B>()
            {
                System = system,
                Entities = entityManager.Entities
            };
            Systems.Add(result);
        }

        public override void AddSystem<A, B, C>(UnifiedSystem<A, B, C> system)
        {
            var result = new DartkSystem<A, B, C>()
            {
                System = system,
                Entities = entityManager.Entities
            };
            Systems.Add(result);
        }

        public override void AddSystem<A, B, C, D>(UnifiedSystem<A, B, C, D> system)
        {
            var result = new DartkSystem<A, B, C, D>()
            {
                System = system,
                Entities = entityManager.Entities
            };
            Systems.Add(result);
        }

        public override IUnifiedEntity CreateNewEntity()
        {
            var entity = entityManager.CreateEntity(Archetype.Empty);
            return new DartkEntity()
            {
                Entity = entity
            };
        }

        public override ISystem GetSystem<A>(UnifiedSystem<A> system)
        {
            var result = new DartkSystem<A>()
            {
                System = system,
                Entities = entityManager.Entities
            };
            return result;
        }

        public override ISystem GetSystem<A, B>(UnifiedSystem<A, B> system)
        {
            var result = new DartkSystem<A, B>()
            {
                System = system,
                Entities = entityManager.Entities
            };
            return result;
        }

        public override ISystem GetSystem<A, B, C>(UnifiedSystem<A, B, C> system)
        {
            var result = new DartkSystem<A, B, C>()
            {
                System = system,
                Entities = entityManager.Entities
            };
            return result;
        }

        public override ISystem GetSystem<A, B, C, D>(UnifiedSystem<A, B, C, D> system)
        {
            var result = new DartkSystem<A, B, C, D>()
            {
                System = system,
                Entities = entityManager.Entities
            };
            return result;
        }

        public override void Run()
        {
            foreach (var system in Systems)
            {
                system.ProcessAll();
            }
        }
    }
}