using System;

[assembly: WebActivatorEx.PreApplicationStartMethod(
    typeof(CapaNegocio.App_Start.DTIControllsPackage), "PreStart")]

namespace CapaNegocio.App_Start {
    public static class DTIControllsPackage {
        public static void PreStart() {
            DTIControls.Share.initializePathProvider();
        }
    }
}