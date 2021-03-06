using System.Collections.Generic;
using BlyncMorseCode.Configuration;

namespace BlyncMorseCode.Engine
{
    public interface IDisplayEngine
    {
        bool ProcessString(string inputString, Dictionary<char, List<int>> characterMappingDictionary, MorseCodeEngineConfiguration configuration);
        void ReinitializeDevice();
    }
}