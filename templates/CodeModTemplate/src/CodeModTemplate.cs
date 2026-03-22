using UnityEngine;

namespace CodeModTemplate {
    public class CodeModTemplate : SimpleModBehaviour {
        public override void OnModLoaded() {
            // Do something.
            Log("{{ModTitle}} is loaded!");
        }

        public override void OnModUnloaded() {
            
        }
    }
}
