using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RimWorld;
using Verse;


namespace RelativeResources
{
    class CompRelativeShearable : CompShearable
    {
        public CompProperties_RelativeShearable Props => (CompProperties_RelativeShearable)this.props;

        private Pawn ParentPawn => (Pawn)this.parent;
        protected override int ResourceAmount => (int)Math.Round(base.ResourceAmount * ParentPawn.BodySize);
    }
    public class CompProperties_RelativeShearable : CompProperties_Shearable
    {
        public CompProperties_RelativeShearable()
        {
            this.compClass = typeof(CompRelativeShearable);
        } 

    }
}
