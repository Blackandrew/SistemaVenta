using System;

[assembly: WebActivatorEx.PreApplicationStartMethod(
    typeof(CapaDatos.App_Start.DTIControllsPackage), "PreStart")]

namespace CapaDatos.App_Start {
    public static class DTIControllsPackage {
        public static void PreStart() {
            DTIControls.Share.initializePathProvider();
        }
    }
}