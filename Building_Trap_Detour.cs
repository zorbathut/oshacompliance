using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OshaCompliance
{
    public static class Building_Trap_Detour
    {
        public static ushort PathFindCostFor(this RimWorld.Building_Trap trap, Verse.Pawn p)
        {
            if (trap.KnowsOfTrap(p))
            {
                if (!trap.Armed)
                {
                    return 100;
                }
                else
                {
                    return 800;
                }
            }
            else
            {
                return 0;
            }
        }
    }
}
