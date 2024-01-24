using UnityEngine;
using UnityEditor;

public class AssetImportConfig : MonoBehaviour
{
    [MenuItem("Klazapp/Tools/Apply Art Assets Import Settings")]
    private static void ApplyImportSettings()
    {
        var assetPaths = AssetDatabase.GetAllAssetPaths();
        
        foreach (var assetPath in assetPaths)
        {
            if (!assetPath.StartsWith("Assets/") || (!assetPath.EndsWith(".png") && !assetPath.EndsWith(".jpg"))) 
                continue;
            
            var importer = AssetImporter.GetAtPath(assetPath) as TextureImporter;

            if (importer == null) 
                continue;

            if (importer.mipmapEnabled)
            {
                importer.mipmapEnabled = false;
            }

            //Configure settings for Android
            var settingsAndroid = importer.GetPlatformTextureSettings("Android");
            settingsAndroid.overridden = true;
            settingsAndroid.format = TextureImporterFormat.ETC2_RGBA8;
            settingsAndroid.maxTextureSize = 1024;
            importer.SetPlatformTextureSettings(settingsAndroid);

            //Configure settings for iOS
            var settingsIOS = importer.GetPlatformTextureSettings("iPhone");
            settingsIOS.overridden = true;
            settingsIOS.format = TextureImporterFormat.ASTC_6x6; 
            settingsIOS.maxTextureSize = 1024;
            importer.SetPlatformTextureSettings(settingsIOS);

            AssetDatabase.ImportAsset(assetPath, ImportAssetOptions.ForceUpdate);
        }
        
        AssetDatabase.SaveAssets();
    }
}