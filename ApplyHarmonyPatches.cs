internal static void ApplyHarmonyPatches()
{
	bool flag = HarmonyPatches.instance == null;
	if (flag)
	{
		HarmonyPatches.instance = new Harmony("com.dedouwe26.gorillatag.cosmetx");
	}
	bool flag2 = !HarmonyPatches.IsPatched;
	if (flag2)
	{
		HarmonyPatches.instance.PatchAll(Assembly.GetExecutingAssembly());
		HarmonyPatches.IsPatched = true;
	}
}
