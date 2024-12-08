using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BepInEx;
using HarmonyLib;

namespace PandaWeaponPackMod
{
    [BepInPlugin("panda.weaponpack.mod", "Panda's Weapon Pack Mod", "1.0.0.0")]
    public class Mod_PandaWeaponPackMod : BaseUnityPlugin
    {
        private void OnStartCore()
        {
            string pathToExcelFile = Path.GetDirectoryName(((BaseUnityPlugin)this).Info.Location) + "/WeaponPack.xlsx";
            SourceManager sources = Core.Instance.sources;
            ModUtil.ImportExcel(pathToExcelFile, "Thing", sources.things);
        }
    }
}
