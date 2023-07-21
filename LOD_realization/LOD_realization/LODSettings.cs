using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stride.Core.Mathematics;
using Stride.Input;
using Stride.Engine;
using Stride.Core;
using Stride.Core.Annotations;

namespace LOD_realization.LOD
{
    public class LODSettings : StartupScript
    {
        static LODSettings _instance;
        
        [DataMember(1)]
        [DataMemberRange(0, 100, 1)]
        public float distanceHigh;
        [DataMember(2)]
        [DataMemberRange(0, 100, 1)]
        public float distanceMiddle;
        [DataMember(3)]
        [DataMemberRange(0, 100, 1)]
        public float distanceLow;
        
        public override void Start()
        {
            _instance = this;
        }
        
        public static float DistanceHigh
        {
            get
            {
                return _instance.distanceHigh;
            }
            set
            {
                _instance.distanceHigh = value;
            }
        }
                
        public static float DistanceMiddle
        {
            get
            {
                return _instance.distanceMiddle;
            }
            set
            {
                _instance.distanceMiddle = value;
            }
        }
               
        public static float DistanceLow
        {
            get
            {
                return _instance.distanceLow;
            }
            set
            {
                _instance.distanceLow = value;
            }
        }
    }
}
