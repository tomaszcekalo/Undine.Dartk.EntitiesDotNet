using EntitiesDotNet;
using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;
using Undine.Core;
using Undine.Core.Struct;

namespace Undine.Dartk.EntitiesDotNet
{
    public class DartkSystem<A> : ISystem
        where A : struct
    {
        public UnifiedSystem<A> System { get; set; }
        public EntityArrays Entities { get; set; }

        public void ProcessAll()
        {
            Entities.ForEach((ref A a) =>
                System.ProcessSingleEntity(0, ref a));
        }
    }

    public class DartkSystem<A, B> : ISystem
        where A : struct
        where B : struct
    {
        public UnifiedSystem<A, B> System { get; set; }
        public EntityArrays Entities { get; set; }

        public void ProcessAll()
        {
            Entities.ForEach((ref A a, ref B b) =>
                System.ProcessSingleEntity(0, ref a, ref b));
        }
    }

    public class DartkSystem<A, B, C> : ISystem
        where A : struct
        where B : struct
        where C : struct
    {
        public UnifiedSystem<A, B, C> System { get; set; }
        public EntityArrays Entities { get; set; }

        public void ProcessAll()
        {
            Entities.ForEach((ref A a, ref B b, ref C c) =>
                System.ProcessSingleEntity(0, ref a, ref b, ref c));
        }
    }

    public class DartkSystem<A, B, C, D> : ISystem
        where A : struct
        where B : struct
        where C : struct
        where D : struct
    {
        public UnifiedSystem<A, B, C, D> System { get; set; }
        public EntityArrays Entities { get; set; }

        public void ProcessAll()
        {
            Entities.ForEach((ref A a, ref B b, ref C c, ref D d) =>
                System.ProcessSingleEntity(0, ref a, ref b, ref c, ref d));
        }
    }
}