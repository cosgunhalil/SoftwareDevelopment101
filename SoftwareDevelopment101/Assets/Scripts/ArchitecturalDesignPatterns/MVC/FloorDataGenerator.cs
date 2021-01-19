

namespace SD101.Example.MVC
{
    public class FloorDataGenerator
    {
        private const float minSizeLimit = 1;
        private const float maxSizeLimit = 5;
        public FloorData generateRandomFloorData() 
        {
            return new FloorData() {Size = new UnityEngine.Vector3(
                UnityEngine.Random.Range(minSizeLimit, maxSizeLimit), 
                UnityEngine.Random.Range(minSizeLimit, maxSizeLimit), 
                UnityEngine.Random.Range(minSizeLimit, maxSizeLimit)) 
            };
        }
    }
}

