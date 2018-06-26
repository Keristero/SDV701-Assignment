using System;

namespace SDV701AdminApplication {
    [Serializable]
    public class ClsDBClass {
        public string UID = Guid.NewGuid().ToString();
    }
}
