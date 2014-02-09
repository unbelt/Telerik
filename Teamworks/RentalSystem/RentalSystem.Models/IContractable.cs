namespace RentalSystem
{
    public interface IContractable
    {
        bool IsEligible { get; }

        void MakeContract();
    }
}
