﻿using MelonLoader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelonLoader.anti_cheat_patchs
{
    internal class SignatureCheckPatch
    {
        internal static void Install()
        {
            Core.HarmonyInstance.Patch(Type.GetType("SignatureCheck").GetProperty("Start").GetGetMethod(), typeof(SignatureCheckPatch).GetMethod(nameof(Prefix)).ToNewHarmonyMethod());
        }
        public bool Prefix()
        {
            MelonLogger.Msg("\"SignatureCheck\" is in the game");
            return false;
        }
    }
}