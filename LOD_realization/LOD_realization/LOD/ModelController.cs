using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stride.Core.Mathematics;
using Stride.Input;
using Stride.Engine;
using Stride.Rendering;

namespace LOD_realization.LOD
{
    public class ModelController : SyncScript
    {
        private Entity _target;
        private ModelComponent modelComponent;
        
        public Model Model1;
        public Model Model2;
        public Model Model3;
        
        public Entity Target
        {
            get
            {
                return _target;
            }
            
            set
            {
                _target = value;
            }
        }

        public override void Start()
        {
            modelComponent = Entity.Get<ModelComponent>();
        }

        public override void Update()
        {
            float distance = (_target.Transform.Position-Entity.Transform.Position).Length();
            DebugText.Print(distance.ToString(), new Int2(100, 100));
            if(distance < LODSettings.DistanceLow)
            {
                modelComponent.Model = Model3;
            }
            if(distance < LODSettings.DistanceMiddle)
            {
                modelComponent.Model = Model2;
            }
            if(distance < LODSettings.DistanceHigh)
            {
                modelComponent.Model = Model1;
            }
            if(distance > LODSettings.DistanceLow)
            {
                modelComponent.Model = null;
            }
        }
    }
}
