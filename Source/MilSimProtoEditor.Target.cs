

using UnrealBuildTool;
using System.Collections.Generic;

public class MilSimProtoEditorTarget : TargetRules
{
	public MilSimProtoEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V7;

		ExtraModuleNames.AddRange( new string[] { "MilSimProto" } );
	}
}
