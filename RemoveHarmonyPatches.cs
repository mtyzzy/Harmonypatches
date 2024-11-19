internal static void RemoveHarmonyPatches()
{
	bool flag = HarmonyPatches.instance != null && HarmonyPatches.IsPatched;
	if (flag)
	{
		HarmonyPatches.instance.UnpatchSelf();
		HarmonyPatches.IsPatched = false;
	}
}
