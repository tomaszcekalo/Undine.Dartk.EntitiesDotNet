using System;
using System.Collections.Generic;
using System.Text;
using Undine.Core.Struct;

namespace Undine.Dartk.EntitiesDotNet
{
    public class DartkEntity : IUnifiedEntity
    {
        public void AddComponent<A>(in A component) where A : struct
        {
            throw new NotImplementedException();
        }

        public ref A GetComponent<A>() where A : struct
        {
            throw new NotImplementedException();
        }
    }
}