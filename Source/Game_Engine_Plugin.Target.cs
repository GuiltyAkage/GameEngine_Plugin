// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class Game_Engine_PluginTarget : TargetRules
{
	public Game_Engine_PluginTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "Game_Engine_Plugin" } );
	}
}
