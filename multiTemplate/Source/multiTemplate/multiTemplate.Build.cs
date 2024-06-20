// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.IO;

public class multiTemplate : ModuleRules
{
	public multiTemplate(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
	
		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore" });

		PrivateDependencyModuleNames.AddRange(new string[] {  });

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });
		
		// Uncomment if you are using online features
		PrivateDependencyModuleNames.Add("OnlineSubsystem");

        // To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true

        //added 6/20/24 by gjb
        //add OnlineSubsystemEOS to extend upon the existing subsystem
        PrivateDependencyModuleNames.Add("OnlineSubsystemEOS");
        // Specify path to your SDK's Include directory
        string SDKPath = Path.Combine(ModuleDirectory, "../../ThirdParty/SDK");
        PublicIncludePaths.Add(Path.Combine(SDKPath, "Include"));

        // Add libraries to link against
        PublicAdditionalLibraries.Add(Path.Combine(SDKPath, "Lib", "EOSSDK-Win64-Shipping.lib"));
        PublicAdditionalLibraries.Add(Path.Combine(SDKPath, "Lib", "EOSSDK-Win32-Shipping.lib"));
        //end of section added 6/20/24 by gjb
    }
}
