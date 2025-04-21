using System;
using System.Linq;
using Metalama.Framework.Advising;
using Metalama.Framework.Aspects;
using Metalama.Framework.Code;

namespace Northwind.Aspects;

[AttributeUsage(AttributeTargets.Class)]
public class GenerateDtoAttribute : TypeAspect
{
    public override void BuildAspect(IAspectBuilder<INamedType> builder)
    {
        var dtoClassName = builder.Target.Name + "Dto";
        
        var dtoClass = builder.Advice.IntroduceClass(
            builder.Target,
            dtoClassName,
            OverrideStrategy.Default,
            null);
        
        var properties = builder.Target.Properties;

        foreach (var prop in properties)
        {
            if (prop.Accessibility == Accessibility.Public)
            {
                builder.Advice.IntroduceProperty(
                    builder.Target,
                    prop.Name);
            }
        }
    }
}