using BepInEx;
using Jotunn.Entities;
using Jotunn.Managers;
using System.IO;

namespace ValheimChineseFixes
{
    [BepInPlugin(PluginGUID, PluginName, PluginVersion)]
    [BepInDependency(Jotunn.Main.ModGuid)]
    internal class ValheimChineseFixes : BaseUnityPlugin
    {
        public const string PluginGUID = "com.ewigl.ValheimChineseFixes";
        public const string PluginName = "Valheim Chinese Fixes";
        public const string PluginVersion = "0.1.0";
        private CustomLocalization localization;
        private const string langCode = "Chinese";

        private void Awake()
        {
            string filePath = Path.Combine(Paths.PluginPath, "ValheimChineseFixes", "Fixes", langCode + ".json");

            localization = LocalizationManager.Instance.GetLocalization();

            localization.AddJsonFile(langCode, File.ReadAllText(filePath));

        }
    }
}