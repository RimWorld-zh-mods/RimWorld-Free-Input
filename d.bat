rd /s /q "D:\Game\Steam\steamapps\common\RimWorld\Mods\Free Input\About"
rd /s /q "D:\Game\Steam\steamapps\common\RimWorld\Mods\Free Input\Assemblies"
rd /s /q "D:\Game\Steam\steamapps\common\RimWorld\Mods\Free Input\Defs"
rd /s /q "D:\Game\Steam\steamapps\common\RimWorld\Mods\Free Input\Languages"
xcopy "About" "D:\Game\Steam\steamapps\common\RimWorld\Mods\Free Input\About" /e /d /i /y
xcopy "Assemblies" "D:\Game\Steam\steamapps\common\RimWorld\Mods\Free Input\Assemblies" /e /d /i /y
xcopy "Defs" "D:\Game\Steam\steamapps\common\RimWorld\Mods\Free Input\Defs" /e /d /i /y
xcopy "Languages" "D:\Game\Steam\steamapps\common\RimWorld\Mods\Free Input\Languages" /e /d /i /y
copy "LICENSE" "D:\Game\Steam\steamapps\common\RimWorld\Mods\Free Input\LICENSE" /y
copy "README.md" "D:\Game\Steam\steamapps\common\RimWorld\Mods\Free Input\README.md" /y