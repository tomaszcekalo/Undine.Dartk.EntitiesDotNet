using NSubstitute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Undine.Core.Struct;
using Undine.Dartk.EntitiesDotNet.Tests.Components;

namespace Undine.Dartk.EntitiesDotNet.Tests
{
    [TestClass]
    public class EntityTests
    {
        [TestInitialize]
        public void Init()
        {
        }

        [TestMethod]
        public void ComponentCanBeAdded()
        {
            var container = new DartkContainer();
            var mock = Substitute.For<UnifiedSystem<AComponent>>();
            container.AddSystem(mock);
            container.Init();
            var entity = container.CreateNewEntity();
            entity.AddComponent(new AComponent());
        }

        [TestMethod]
        public void ComponentCanBeRetrieved()
        {
            var container = new DartkContainer();
            var mock = Substitute.For<UnifiedSystem<AComponent>>();
            container.AddSystem(mock);
            container.Init();
            var entity = (DartkEntity)container.CreateNewEntity();
            entity.AddComponent(new AComponent());

            ref var component = ref entity.GetComponent<AComponent>();
            Assert.IsNotNull(component);
        }//
    }
}