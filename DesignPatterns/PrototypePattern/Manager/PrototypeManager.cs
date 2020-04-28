using PrototypePattern.Prototype;
using System.Collections.Generic;

namespace PrototypePattern.Manager
{
    public class PrototypeManager
    {
        private Dictionary<string, IPrototype> _prototypes = new Dictionary<string, IPrototype>();

        public IPrototype this[string key]
        {
            get => _prototypes[key];
            set => _prototypes.Add(key, value);
        }
    }
}
