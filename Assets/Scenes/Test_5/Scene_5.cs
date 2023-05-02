using iShape.FixBox.Dynamic;
using iShape.FixBox.Simulation;
using iShape.FixFloat;

namespace Scenes.Test_5 {

    public class Scene_5 : SimpleScene {
        protected override void DidWorldCreate() {
            base.DidWorldCreate();
            var wheelActor_2 = world.GetActor(2, BodyType.player);
            wheelActor_2.Body.Velocity = new Velocity(FixVec.Zero, FixNumber.PI * 2);
            world.SetActor(wheelActor_2);
            
            var wheelActor_3 = world.GetActor(3, BodyType.land);
            wheelActor_3.Body.Velocity = new Velocity(FixVec.Zero, FixNumber.PI / 10);
            world.SetActor(wheelActor_3);
        }
    }

}
