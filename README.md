# AssetImportConfig Utility for Unity

## Introduction
The `AssetImportConfig` utility, specifically developed for Unity projects, automates the process of configuring import settings for art assets in the Assets folder. It focuses on optimizing settings for different platforms, particularly Android and iOS, ensuring assets are appropriately formatted and sized.

## Features
- Automatically sets import settings for all art assets in the Assets folder.
- Applies ETC2 compressed format with RGBA for Android and an appropriate format for iOS.
- Configures the maximum texture size for both Android and iOS platforms.
- Disables Mipmap generation if it is enabled for the assets.

## Dependencies
To utilize `AssetImportConfig`, your Unity project should meet these requirements.
- **Unity Version**: Minimum Unity 2020.3 LTS or higher.

## Compatibility
| Compatibility        | URP | BRP | HDRP |
|----------------------|-----|-----|------|
| Compatible           | ✔️  | ✔️  | ✔️   |

## Installation
1. Open the Unity Package Manager (`Window` > `Package Manager`).
2. Click `+`, select `Add package from git URL...`, and enter `https://github.com/klazapp/Unity-Asset-Import-Config-Public.git`.
3. Unity will download and make the package available in your project.

## Usage
To use the `AssetImportConfig` utility:
1. Open your Unity project.
2. Navigate to the menu item `Klazapp` > `Tools` > `Apply Art Assets Import Settings`.
4. Click on it to run the script. This will automatically apply the predefined settings to all suitable assets.

## To-Do List (Future Features)
- Support for different asset types (models, audio clips, etc.).
- Customizable import settings through the Unity Editor UI.
- Automated backup creation before applying changes.

## License
This utility is released under the [MIT License](LICENSE).
