

using UnrealBuildTool;
using System.Collections.Generic;

public class MilSimProtoTarget : TargetRules
{
	public MilSimProtoTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V7;

		ExtraModuleNames.AddRange( new string[] { "MilSimProto" } );
	}
}
