using CosmosX.Entities.Modules.Absorbing;
using System;
using System.Collections.Generic;
using System.Text;

namespace CosmosX.Entities.Modules.Energy
{
    public class CooldownSystem : BaseAbsorbingModule
    {
        public CooldownSystem(int id, int heatAbsorbing) : base(id, heatAbsorbing)
        {
        }
    }
}
