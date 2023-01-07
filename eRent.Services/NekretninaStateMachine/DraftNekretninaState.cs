using eRent.Models.Requests;

namespace eRent.Services.NekretninaStateMachine
{
    public class DraftNekretninaState : BaseState
    {
        public override void Update(NekretninaUpdateRequest update)
        {
            //base.Update(update); 
            CurrentEntity.StateMachine = "draft"
        }

        public override void Activate()
        {
            CurrentEntity.StateMachine = "active";
            //base.Activate(); 
        }
    }
}
