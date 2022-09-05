using Stationeers.Addons;
using Stationeers.Addons.API;
using UnityEngine;

namespace CardboardBoxRevamp.Scripts
{
    public class Plugin : IPlugin
    {
        public void OnLoad()
        {
            Debug.Log("Example Mod: Hello, World!");            
        }

        public void OnUnload()
        {
            Debug.Log("Example Mod: Bye!");
        }
    }
}
