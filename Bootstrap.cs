using CommunityCoreLibrary_OshaCompliance;
using System;
using System.Reflection;
using UnityEngine;
using Verse;

namespace OshaCompliance
{
    class Bootstrap : Def
    {
        public string ModName;

        static Bootstrap()
        {
            {
                MethodInfo method1 = typeof(RimWorld.Building_Trap).GetMethod("PathFindCostFor", BindingFlags.Instance | BindingFlags.Public);
                MethodInfo method2 = typeof(Building_Trap_Detour).GetMethod("PathFindCostFor", BindingFlags.Static | BindingFlags.Public);
                if (!Detours.TryDetourFromTo(method1, method2))
                {
                    Debug.LogError("EVERYTHING IS BROKEN");
                    return;
                }
                else
                {
                    Debug.LogError("We're all good!");
                }
            }
        }
    }
}
