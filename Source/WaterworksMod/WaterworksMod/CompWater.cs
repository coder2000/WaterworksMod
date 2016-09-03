using Verse;

namespace WaterworksMod
{
    public abstract class CompWater : ThingComp
    {
        public CompProperties_Water Props => this.props as CompProperties_Water;
    }
}