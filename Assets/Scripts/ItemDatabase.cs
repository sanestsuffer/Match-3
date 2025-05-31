using UnityEngine;

public static class ItemDatabase
{
    public static Item[] Items { get; private set; }

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)] public static void Initialize() => Items = Resources.LoadAll<Item>("Items/");
}
