using eRent.Models.Requests;

namespace eRent.Services.NekretninaStateMachine
{
    public class InitialNekretninaState : BaseState
    {
        public override void Insert(NekretninaInsertRequest insert)
        {
            //base.Insert(insert); 
            CurrentEntity.StateMachine = "draft";
        }
    }
}
