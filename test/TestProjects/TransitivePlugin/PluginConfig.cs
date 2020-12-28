using Test.Transitive;
using TransitiveTransitiveDep.v1;

namespace TransitivePlugin
{
    public class PluginConfig
    {
        public TransitiveTransitiveSharedType TransitiveTransitiveType;

        public TransitiveSharedType GetTransitiveType() => new TransitiveSharedType();

        public TransitiveTransitiveSharedType GetTransitiveTransitiveType() => new TransitiveTransitiveSharedType();
    }
}
