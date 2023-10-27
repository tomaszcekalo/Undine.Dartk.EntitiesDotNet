using System;
using System.Collections.Generic;
using System.Text;
using Undine.Core;
using Undine.Core.Struct;

namespace Undine.Dartk.EntitiesDotNet
{
    public class DartkSystem<A> : ISystem
        where A : struct
    {
        public UnifiedSystem<A> System { get; set; }

        public void ProcessAll()
        {
            throw new NotImplementedException();
        }
    }

    public class DartkSystem<A, B> : ISystem
        where A : struct
        where B : struct
    {
        public UnifiedSystem<A, B> System { get; set; }

        public void ProcessAll()
        {
            throw new NotImplementedException();
        }
    }

    public class DartkSystem<A, B, C> : ISystem
        where A : struct
        where B : struct
        where C : struct
    {
        public UnifiedSystem<A, B, C> System { get; set; }

        public void ProcessAll()
        {
            throw new NotImplementedException();
        }
    }

    public class DartkSystem<A, B, C, D> : ISystem
        where A : struct
        where B : struct
        where C : struct
        where D : struct
    {
        public UnifiedSystem<A, B, C, D> System { get; set; }

        public void ProcessAll()
        {
            throw new NotImplementedException();
        }
    }
}