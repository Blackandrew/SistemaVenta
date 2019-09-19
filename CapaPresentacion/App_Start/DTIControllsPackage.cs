using System;

[assembly: WebActivatorEx.PreApplicationStartMethod(
    typeof(CapaPresentacion.App_Start.DTIControllsPackage), "PreStart")]

namespace CapaPresentacion.App_Start {
    public static class DTIControllsPackage {
        public static void PreStart() {
            DTIControls.Share.initializePathProvider();
        }
    }
}