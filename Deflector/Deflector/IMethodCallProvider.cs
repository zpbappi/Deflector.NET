using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;

namespace Deflector
{
    public interface IMethodCallProvider
    {
        void AddMethodCalls(object target, MethodBase hostMethod, IEnumerable<MethodBase> interceptedMethods, 
            IMethodCallMap methodCallMap, StackTrace stackTrace);
    }
}