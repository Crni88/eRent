using eRent.Models.Requests;

namespace eRent.Services.NekretninaStateMachine
{
    public abstract class BaseState
    {
        public DataDB.Nekretnina CurrentEntity { get; set; }

        public string CurrentState { get; set; }

        public virtual DataDB.Nekretnina Insert(NekretninaInsertRequest insert)
        {
            throw new Exception("Not Allowed!");
        }

        public virtual void Update(NekretninaUpdateRequest update)
        {
            throw new Exception("Not Allowed!");
        }
        public virtual void Activate()
        {
            throw new Exception("Not Allowed");
        }
        public virtual void Hide()
        {
            throw new Exception("Not Allowed!");
        }

        public virtual void Fill()
        {
            throw new Exception("Not Allowed");
        }

        public virtual void Empty()
        {
            throw new Exception("Not Allowed!");
        }
        public virtual void Starred()
        {
            throw new Exception("Not Allowed!");
        }

        public virtual void Delete()
        {
            throw new Exception("Not Allowed");
        }

        public static BaseState CreateState(string stateName)
        {
            switch (stateName)
            {
                case "initial":
                    return new InitialNekretninaState();
                case "draft":
                    return new DraftNekretninaState();
                //case "active":
                //    return new ();
                default:
                    return new DraftNekretninaState();
            }
        }
    }
}
