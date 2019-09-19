using System;

[assembly: WebActivatorEx.PreApplicationStartMethod(
    typeof(SisVentas.App_Start.DTIControllsPackage), "PreStart")]

namespace SisVentas.App_Start {
    public static class DTIControllsPackage {
        public static void PreStart() {
            DTIControls.Share.initializePathProvider();
        }
    }
}