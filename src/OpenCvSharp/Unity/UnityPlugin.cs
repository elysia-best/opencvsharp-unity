using System;
using System.Collections.Generic;
using System.Text;
using OpenCvSharp.Internal;

namespace OpenCvSharp;
public class UnityPlugin : DisposableCvObject
{
    public static String GetDllExternName()
    {
        return NativeMethods.DllExtern;
    }
}
